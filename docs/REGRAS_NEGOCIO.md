# Regras de negócio alinhadas ao backend Web

Referência: código local de `justdothework-web/backend`, conferido em 02/11/2026. A adaptação mantém controllers, repositories, DTOs, WinForms/DevExpress e os provedores SQL Server/PostgreSQL do desktop. Cookies, HTTP, CSRF e paginação da API pertencem ao transporte Web.

## Visualização das tarefas

| Perfil | Consulta e busca por ID | Ações |
| --- | --- | --- |
| Historiador | Todas as atividades, inclusive de outros responsáveis, canceladas e finalizadas. | Criar; trabalhar e encaminhar apenas sua etapa/atribuição. |
| Tech Lead | Todas as atividades. | Criar sem responsável inicial, editar em qualquer status, cancelar abertas, excluir quando permitido e vincular responsável a atividades abertas sem vínculo. Não executa nem conclui etapas. |
| Desenvolvedor | Pendentes de Desenvolvimento da equipe; Executando/Pausado somente quando responsável. | Assumir com Executar, pausar, retomar, liberar a fila normal e encaminhar ao QA depois de assumir. |
| QA Tester | Pendentes de Testes da equipe; Executando/Pausado somente quando responsável. | Assumir com Executar, pausar, retomar, liberar a fila, finalizar ou devolver ao desenvolvedor depois de assumir. |

O filtro está no repository, antes dos filtros de pesquisa. Abrir uma tarefa por ID respeita o mesmo escopo. Atividades antigas sem projeto permanecem consultáveis como `Sem projeto`; cadastrar/editar exige projeto existente. A visibilidade dos botões por linha acompanha as permissões e os repositories validam novamente cada escrita.

## Fila, encaminhamento e devolução

- A etapa inicial é Historiador/Pendente. O Historiador responsável pode descrever e encaminhar sem iniciar um período.
- O início de uma pendente de Desenvolvimento/Testes atribui a tarefa ao usuário autenticado e abre uma execução com sua autoria e etapa. O responsável anterior da pendente normal é uma referência, sem impedir que outro especialista assuma.
- Avançar exige nome, projeto existente e DOCX com texto visível ou imagem. Percorre Historiador → Desenvolvedor → QA Tester → Finalizada. O destinatário deve ter o perfil da próxima etapa.
- Pausar, liberar, encaminhar, cancelar ou finalizar encerra o período aberto na transação. Apenas concluir o QA finaliza a atividade.
- A devolução pelo QA usa o autor da última execução fechada de Desenvolvimento ou, na ausência dela, `UltimoDesenvolvedorId`. Sem evidência ou com perfil inválido, recusa sem alterar os dados.
- A devolução marca `RetornoExclusivo`; apenas o desenvolvedor anterior vê/assume essa pendência. A reserva persiste ao retomar ou voltar a Pendente e é removida no próximo avanço.
- Excluir exige Historiador responsável ou Tech Lead, primeira etapa, Pendente/Análise e nenhuma execução anterior.

## Histórico, modelos e cadastros

- Desenvolvedor e QA consultam períodos de sua autoria, inclusive após a troca de etapa. Autoria legada nula continua nula e usa a atribuição atual apenas como critério de acesso.
- Historiador e Tech Lead consultam todos os períodos e gerenciam modelos/impressão. Especialistas têm menu de Tarefas e Minhas execuções, sem cadastros ou impressão.
- Novos períodos registram `Execucao.UsuarioId` e `Execucao.Etapa`. As grids distinguem autoria e etapa não registradas.
- Modelos preservam o DOCX original quando seu conteúdo não é editado. Edição/exclusão com revisão antiga é recusada. Impressão exige documento com conteúdo, tipo de histórico identificado pela descrição, escolha quando houver múltiplos modelos e de 1 a 100 execuções. O total de descrições das atividades selecionadas é limitado a 40 MiB.
- Usuários são administrados pelo Tech Lead. Nome/logon têm até 30 caracteres, logon não pode ser duplicado e o tipo deve corresponder a um perfil válido. BCrypt usa fator 12 e limite de 72 bytes UTF-8, preservando espaços da senha. Senha em branco na edição mantém o hash; formulários não recebem o hash. Login ambíguo é recusado.
- Projetos vinculados a atividades e usuários vinculados como responsável, último desenvolvedor ou executor não podem ser excluídos.

## Persistência e atualização de estrutura

As operações de atividade usam transação Serializable e versão de status/etapa/responsável. As fichas incluem revisão SHA-256 dos dados e documento, impedindo sobrescrita por uma ficha antiga. O SQL Server usa bloqueio de atualização na disputa por pendências; atribuição e período são confirmados ou revertidos juntos. Datas novas seguem `America/Sao_Paulo`, sem offset, compatíveis com o banco existente.

Os scripts incorporados `AtualizarFluxoSqlServer.sql` e `AtualizarFluxoPostgres.sql` adicionam as colunas de fila/autoria sem inferir dados históricos. São transacionais e idempotentes, aceitando bases que já receberam as extensões Web. O desktop mantém sua atualização de estrutura após autenticação válida; a API Web continua com seu procedimento próprio.

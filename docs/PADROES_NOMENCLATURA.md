# Padrões de nomenclatura

Os nomes de domínio e de ações seguem o português já utilizado no projeto. Termos das camadas e das bibliotecas, como `Controller`, `Repository`, `DTO`, `UserControl` e `GridView`, são mantidos.

## Código

| Elemento | Padrão | Exemplo |
| --- | --- | --- |
| Formulário | `Form` + ação/finalidade + entidade | `FormCadastroUsuario`, `FormVisualizaAtividade` |
| Listagem de cadastros | `Cadastro` + entidade + `UserControl` | `CadastroAtividadeUserControl` |
| Outros controles de tela | finalidade + `UserControl` | `HistoricoUserControl`, `VisualizaExecucaoUserControl` |
| Controller/repository/interface | entidade + sufixo; interface com `I` | `UsuarioController`, `UsuarioRepository`, `IUsuarioRepository` |
| DTO | finalidade + entidade + `DTO` | `FiltroPesquisaAtividadeDTO`, `ResultadoPesquisaAtividadeDTO` |
| Classe, propriedade e método | PascalCase | `UsuarioDTO`, `TipoUsuarioId`, `BuscarPorId` |
| Parâmetro e variável local | camelCase; sem `_` inicial | `atividadeId`, `statusAtual`, `usuarioDTO` |
| Campo privado de negócio | `_` + camelCase | `_usuarioController`, `_cadastroAtividadeUserControl` |
| Instância local de tela | nome da classe em camelCase | `formCadastroUsuario`, `formEditaTexto` |

As entidades persistidas ficam no namespace `JustDoTheWork.Entity.DatabaseClasses`, acompanhando a pasta. Os nomes de tabelas e colunas do banco continuam definidos pelos mappings.

Os métodos de cadastro usam `Inclusao`, `Edicao` e `Exclusao`. As consultas usam `Pesquisar` com filtro, `BuscarPorId`, `BuscarPorLogon`, `BuscarPorAtividadeId`, `PesquisarHistorico` ou `PesquisarPorStatus`, conforme a finalidade. Métodos de carregamento das telas mantêm os prefixos predominantes `Atualiza` e `Carrega`.

## Componentes e eventos

Componentes usam camelCase com prefixo de tipo e um nome que descreve sua função. Esses campos não recebem o `_` dos campos privados de negócio.

| Tipo/finalidade | Prefixo ou padrão | Exemplo |
| --- | --- | --- |
| Botão | `btn` + ação + contexto | `btnSalvarCadastroUsuario`, `btnPesquisarUsuario`, `btnLimpar` |
| Texto, rótulo e combo | `txt`, `lbl`, `combo` | `txtLogon`, `lblTipoUsuario`, `comboTipoUsuario` |
| Editor de documento | `richEdit` | `richEditDescricaoAtividade`, `richEditTextoModelo` |
| Painel/grupo | `panel`, `group` + finalidade | `panelAcoes`, `panelFiltroPesquisa`, `groupInfoAtividade` |
| Dados vinculados | `bindingSource` + finalidade/entidade | `bindingSourceUsuario`, `bindingSourceResultadoPesquisaUsuario` |
| Grid e visualização | `gridControl`, `grid` + contexto | `gridControlUsuario`, `gridUsuario` |
| Coluna | `col` + conteúdo/finalidade | `colNome`, `colAcao`, `colDataInicioExecucao` |
| Editor de coluna | `repository` + finalidade | `repositoryButtonAcao`, `repositoryDataFimExecucao` |
| Data/timer | `data`, `timer` + finalidade | `dataCriacaoPesquisa`, `timerAtualizaGrid` |
| Menu e abas | `accordionElement`, `accordionSeparator`, `tabControl`, `tab` | `accordionElementUsuarios`, `tabControlPrincipal`, `tabInfoAtividade` |

O botão da listagem que abre um novo cadastro usa `btnIncluirEntidade`; o botão do formulário que grava os dados usa `btnSalvarCadastroEntidade`.

Eventos usam `NomeDaTela_Load` ou `nomeDoComponente_Evento`, respeitando o evento efetivamente associado: `repositoryButtonAcao_ButtonPressed`, `repositoryButtonAcao_ButtonClick` e `timerAtualizaGrid_Tick`, por exemplo. Um manipulador compartilhado por vários itens de menu pode descrever a ação comum.

Nomes de componentes, eventos, arquivos `.Designer.cs`, recursos `.resx` e suas chaves devem ser atualizados juntos. Comandos próprios do editor DevExpress mantêm os nomes de seus tipos, em camelCase, sem números arbitrários. Membros exigidos pelas bibliotecas, como `InitializeComponent`, `Dispose`, `Configure` e `Main`, seguem os contratos dessas bibliotecas.

## Grids

`DesignGrid.Configurar` centraliza a apresentação. Colunas de texto ficam alinhadas à esquerda; IDs, datas, indicadores e ações ficam centralizados. Textos têm mais espaço, datas têm largura mínima de 160 e a ação fica à direita, entre 70 e 90 pixels. As larguras informadas por tela definem as proporções, e a grid redistribui o espaço ao redimensionar a janela. Apenas as colunas de ação permitem edição; os demais valores são de leitura.

A `.editorconfig` sugere as regras gerais no editor. Os prefixos de componentes e as exceções dos eventos são conferidos conforme este documento.

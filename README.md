# JustDoTheWork

## 📋 Sobre o Projeto

Sistema de gerenciamento de tarefas orientado a fluxos de trabalho, desenvolvido para controlar todo o ciclo de vida das atividades de forma organizada e eficiente.

A aplicação permite a criação, execução, pausa e conclusão de tarefas, além de realizar o controle de tempo gasto em cada atividade, fornecendo maior rastreabilidade e acompanhamento da produtividade.

O sistema foi projetado com foco em consistência de dados e gerenciamento de estados, garantindo que as transições entre as etapas do fluxo de trabalho ocorram de forma segura e previsível.

---

## 🚀 Funcionalidades

* Cadastro de tarefas
* Início de execução de tarefas
* Pausa e retomada de tarefas
* Finalização de tarefas
* Controle de tempo por atividade
* Gerenciamento do ciclo de vida das tarefas
* Controle de transições de estado
* Persistência de dados em banco relacional
* Interface desktop responsiva e produtiva

---

## 🏗️ Arquitetura

O projeto foi desenvolvido utilizando boas práticas de separação de responsabilidades, permitindo maior manutenibilidade e evolução do sistema.

### Fluxo de Estados

Uma tarefa pode transitar pelos seguintes estados:

```text
Em Análise
   ↓
Pendente
   ↓
Em Execução
   ↓
Pausada
   ↓
Em Execução
   ↓
Concluída
```

As regras de transição são centralizadas em `TransicaoStatusAtividade` (camada de domínio) e aplicadas de forma transacional no `AtividadeController.AlterarStatus`, garantindo que apenas uma atividade fique em execução por vez.

---

## 🛠️ Tecnologias Utilizadas

* C#
* .NET 8 (Windows Forms)
* Dapper (micro-ORM)
* SQL Server / PostgreSQL
* DevExpress (WinForms)
* xUnit (testes unitários)

---

## 💾 Persistência de Dados

O acesso aos dados é realizado através de consultas SQL escritas diretamente na aplicação (Dapper), com suporte a **SQL Server** (padrão) e **PostgreSQL** (detectado automaticamente quando a connection string contém `Host=`).

As operações de escrita são executadas dentro de transações gerenciadas pelo padrão `UnitOfWork`.

### 📌 Configuração do banco

A connection string NÃO deve ser versionada. Configure a variável de ambiente abaixo antes de executar:

```text
JUSTDOTHEWORK_SQLSERVER=Server=localhost;Database=JustDoTheWork;User id=sa;Password=SuaSenha;TrustServerCertificate=True
```

Ou edite a connection string `SqlServer` em `JustDoTheWork.Sistema/App.config`. O script `justdothework_sql.sql` contém o DDL para as duas opções de banco.

---

## 🧪 Testes

A lógica de domínio (transições de estado, duração de execução e filtros de data) possui cobertura em `JustDoTheWork.Tests`:

```bash
dotnet test
```

---

## 🎨 Interface do Usuário

A interface foi construída utilizando componentes DevExpress para oferecer:

* Melhor experiência de uso
* Maior produtividade operacional
* Componentes modernos para desktop
* Navegação intuitiva
* Melhor desempenho visual

---

## 🎯 Objetivos do Projeto

* Centralizar o gerenciamento de tarefas
* Melhorar o acompanhamento das atividades
* Controlar o tempo investido em cada tarefa
* Garantir consistência nas regras de negócio
* Fornecer uma solução desktop robusta e escalável

---

## 📄 Licença

Este projeto foi desenvolvido para fins de estudo e demonstração de competências em desenvolvimento desktop com .NET.

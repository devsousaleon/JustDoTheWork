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
Criada
  ↓
Em Execução
  ↓
Pausada
  ↓
Em Execução
  ↓
Concluída
```

As regras de negócio garantem que apenas transições válidas sejam executadas.

---

## 🛠️ Tecnologias Utilizadas

* C#
* .NET 8
* Entity Framework
* Postgres
* DevExpress
* Windows Desktop Application

---

## 💾 Persistência de Dados

A persistência de dados foi implementada utilizando PostgreSQL como banco de dados relacional.

O acesso aos dados é realizado através de consultas SQL escritas diretamente na aplicação, proporcionando:

- Controle total sobre as consultas executadas
- Maior previsibilidade de desempenho
- Flexibilidade para criação de consultas específicas
- Integração direta com o banco de dados

A estrutura foi desenvolvida para garantir a integridade dos dados e suportar a evolução das regras de negócio do sistema.

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

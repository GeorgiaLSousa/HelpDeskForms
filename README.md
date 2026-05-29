# 🎫 HelpDesk Pro System

Sistema de Help Desk desenvolvido em C# Windows Forms com SQLite para gerenciamento de chamados de suporte técnico.

## 📋 Sobre o Projeto

O HelpDesk Pro System foi desenvolvido com o objetivo de centralizar e organizar solicitações de suporte dentro de uma empresa.

O sistema permite que usuários abram chamados e acompanhem seu andamento, enquanto analistas podem visualizar, gerenciar e atender as solicitações recebidas.

---

## 🚀 Funcionalidades

### Cliente

- Login no sistema
- Cadastro de usuário
- Abertura de novos chamados
- Visualização dos próprios chamados
- Filtro por status
- Acompanhamento do andamento do chamado

### Analista

- Visualização de todos os chamados
- Filtro por status
- Filtro de chamados atribuídos
- Gerenciamento dos atendimentos
- Atualização do status dos chamados

---

## 🖥️ Telas do Sistema

### Login

- Autenticação de usuários
- Redirecionamento baseado no perfil

### Cadastro

- Cadastro de novos usuários
- Validação de informações

### Dashboard Cliente

- Listagem dos chamados do usuário
- Criação de novos chamados
- Consulta de status

### Novo Chamado

- Cadastro de solicitações
- Definição de prioridade
- Seleção de categoria

### Dashboard Analista

- Visualização geral dos chamados
- Controle dos chamadas

---

## 🛠️ Tecnologias Utilizadas

- C#
- .NET Windows Forms
- SQLite
- Entity Framework Core
- Visual Studio 2022

---

## 🗄️ Banco de Dados

O sistema utiliza SQLite como banco de dados local.

Arquivo:

```text
helpdesk.db
```

Principais entidades:

### Usuário

- Id
- Nome
- Email
- CPF
- Senha
- Perfil

### Chamado

- Id
- Título
- Descrição
- Categoria
- Prioridade
- Status
- Data de abertura
- Solicitante

---

## 📌 Perfis de Usuário

### Cliente

Responsável por abrir e acompanhar chamados.

### Analista

Responsável por atender e gerenciar chamados.

---

## 🎨 Interface

O sistema utiliza uma interface moderna inspirada em dashboards corporativos.

Características:

- Layout responsivo para telas Full HD
- Componentes reutilizáveis
- UserControl para cards de chamados
- Navegação simplificada

---

## 📂 Como Executar

### Pré-requisitos

- Visual Studio 2022
- .NET 8 ou superior

### Passos

Clone o repositório:

```bash
git clone https://github.com/RafaelSilvax06/HelpDeskWindowsForms.git
```

Abra a solução:

```text
HelpDeskWindowsForms.sln
```

Execute:

```text
F5
```

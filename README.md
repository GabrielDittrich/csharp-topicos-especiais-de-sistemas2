# 🌐 Tópicos Especiais de Sistemas — C# e .NET

Repositório com projetos, exercícios e atividades desenvolvidos durante a disciplina de **Tópicos Especiais de Sistemas**, do curso de **Análise e Desenvolvimento de Sistemas da Universidade Positivo**.

Ao longo da disciplina, os conteúdos evoluem dos fundamentos de **C#** até o desenvolvimento de **APIs REST com .NET 8**, utilizando **Minimal APIs, Entity Framework Core, MySQL, Swagger e React**.

---

## 📚 Sobre o repositório

O repositório registra a evolução prática dos conteúdos estudados durante a disciplina.

As primeiras atividades trabalham fundamentos da linguagem C# e Programação Orientada a Objetos. Em seguida, são introduzidos conceitos de desenvolvimento web com **ASP.NET Core Minimal APIs**, operações CRUD e persistência de dados.

Nas atividades mais avançadas são trabalhados **Entity Framework Core, MySQL, relacionamentos entre entidades, migrations, Swagger e React**.

O repositório também contém uma API de gerenciamento de petshop desenvolvida como aplicação prática dos conceitos estudados.

---

## 🛠️ Tecnologias utilizadas

### 🔧 Backend

* **C#**
* **.NET 8**
* **ASP.NET Core**
* **Minimal APIs**
* **Entity Framework Core**
* **MySQL**
* **Entity Framework Core InMemory**
* **Swagger / OpenAPI**
* **LINQ**

### 🎨 Frontend

* **React**
* **JavaScript / JSX**
* **React Router**
* **HTML**
* **CSS**

### 🧰 Ferramentas

* **Visual Studio Code**
* **Git**
* **GitHub**
* **MySQL**
* Arquivos `.http` para testes de endpoints

---

## ✨ Conceitos praticados

### C# e Programação Orientada a Objetos

* Classes e objetos
* Atributos
* Métodos
* Métodos estáticos
* Arrays
* Entrada e saída de dados
* Separação da lógica em diferentes classes

### APIs e backend

* ASP.NET Core
* Minimal APIs
* Endpoints REST
* Métodos HTTP `GET`, `POST`, `PUT` e `DELETE`
* Parâmetros de rota
* Recebimento de objetos JSON
* Códigos de status HTTP
* Operações CRUD
* Organização de endpoints através de grupos

### Banco de dados

* Entity Framework Core
* `DbContext`
* `DbSet`
* Persistência em memória
* Persistência com MySQL
* Migrations
* Consultas assíncronas
* LINQ
* Relacionamentos entre entidades
* Relacionamentos um-para-muitos
* Relacionamentos muitos-para-muitos
* Carregamento de dados relacionados com `Include`

### Documentação de APIs

* Swagger
* OpenAPI
* Testes de endpoints
* Arquivos `.http`

### Frontend

* React
* Componentes
* JSX
* React Router
* Estruturação de layouts
* Formulários
* Tabelas
* Navegação entre páginas

---

# 📈 Evolução das atividades

## 🟢 Aula 01 — Introdução ao C#

Primeiro contato com um projeto em **C# e .NET 8**.

A atividade apresenta a estrutura básica de uma aplicação de console e execução do primeiro programa utilizando:

```csharp
Console.WriteLine("Hello, World!");
```

---

## 🟢 Aula 02 — Classes, objetos e métodos

Introdução à Programação Orientada a Objetos através da modelagem de alunos.

Foram praticados conceitos como:

* criação de classes;
* instanciação de objetos;
* atributos;
* arrays de objetos;
* métodos;
* métodos estáticos;
* entrada de dados;
* conversão de valores.

Também foi criada uma classe `Calculadora`, com operações de:

* soma;
* subtração;
* multiplicação;
* divisão.

---

## 🟢 Aula 03 — Introdução às Minimal APIs

Primeiro contato com desenvolvimento web utilizando **ASP.NET Core**.

Foi criada uma aplicação utilizando Minimal API e o primeiro endpoint:

```text
GET /
```

Essa etapa apresenta a estrutura básica de uma aplicação web em .NET e o funcionamento de endpoints HTTP.

---

## 🟢 Aula 04 — API de tarefas e CRUD

Desenvolvimento de uma API para gerenciamento de tarefas utilizando:

* ASP.NET Core Minimal APIs;
* Entity Framework Core;
* banco de dados em memória;
* LINQ;
* operações assíncronas.

A entidade `Tarefa` possui informações como:

* ID;
* nome;
* status de conclusão.

Entre os endpoints implementados estão:

```text
GET    /tarefas
GET    /tarefas/concluidas
GET    /tarefas/{id}
POST   /tarefas
PUT    /tarefas/{id}
DELETE /tarefas/{id}
```

A atividade aplica as quatro operações fundamentais de um **CRUD**.

---

## 🟢 Aula 05 — Entity Framework Core e MySQL

Continuação dos conceitos de persistência de dados.

Além da API de tarefas, foi iniciado um projeto utilizando:

* Entity Framework Core;
* MySQL;
* `DbContext`;
* `DbSet`;
* modelagem da entidade `Pessoa`;
* configuração da conexão com banco de dados.

Essa etapa introduz a utilização de um banco relacional persistente nas aplicações .NET.

---

## 🟢 Aula 06 — Relacionamentos, Swagger e React

Nesta etapa são trabalhados conceitos mais avançados de backend e iniciados os estudos de React.

### 🔧 Backend

Foi desenvolvida uma API utilizando:

* C#;
* .NET 8;
* Entity Framework Core;
* MySQL;
* Swagger;
* migrations;
* consultas assíncronas.

Foram modeladas entidades como:

```text
Cliente
Endereco
Produto
Pedido
ItemPedido
Aluno
Disciplina
```

Entre os relacionamentos estudados estão:

* cliente e endereço;
* cliente e pedidos;
* pedido e itens;
* aluno e disciplinas.

Também foram implementados endpoints CRUD organizados por recursos:

```text
/clientes
/enderecos
/produtos
/pedidos
/alunos
/disciplinas
```

Consultas utilizando `Include` permitem carregar algumas entidades relacionadas através do Entity Framework Core.

### 🎨 React

Também são introduzidos conceitos de frontend com React.

Foram criados componentes para estruturar uma página utilizando elementos como:

* Header;
* Nav;
* Aside;
* Footer;
* páginas separadas;
* CSS.

---

## 🟢 Aula 07 — Introdução e prática com React

Continuação dos estudos de frontend utilizando **React**.

A atividade trabalha a estrutura básica de uma aplicação React e criação de componentes utilizando JSX.

Essa etapa reforça a separação da interface em componentes reutilizáveis.

---

## 🟢 Aula 08 — React Router, formulários e APIs relacionadas

A aula reúne conteúdos de frontend e backend.

### 🎨 Frontend

A aplicação React utiliza:

* React Router;
* componentes de layout;
* navegação entre páginas;
* formulários;
* tabelas;
* estrutura visual para operações CRUD.

Também foram desenvolvidos exemplos separados de HTML e CSS envolvendo:

* formulários;
* controles;
* layouts;
* Grid;
* estrutura de interface CRUD.

### 🔧 Backend

O projeto de API trabalha novamente com:

* .NET 8;
* Minimal APIs;
* Entity Framework Core;
* MySQL;
* Swagger;
* migrations;
* relacionamentos entre entidades.

São utilizados recursos para clientes, endereços, produtos, pedidos, alunos e disciplinas.

---

# 🐾 Projeto PetShop

O repositório também possui uma **API REST para gerenciamento de petshop**, aplicando vários conceitos estudados durante a disciplina.

A aplicação foi desenvolvida utilizando:

* C#;
* .NET 8;
* ASP.NET Core Minimal APIs;
* Entity Framework Core;
* MySQL;
* Swagger;
* migrations.

---

## 📦 Entidades

A API trabalha com três entidades principais:

```text
Pessoa
Animal
Produto
```

---

## ⚙️ Funcionalidades

Para os recursos principais foram implementadas operações de:

* cadastro;
* listagem;
* atualização;
* exclusão.

Exemplos dos grupos de endpoints:

```text
/pessoas
/animais
/produtos
```

As operações utilizam Entity Framework Core para persistência dos dados no MySQL.

---

## 📚 Swagger

A API PetShop possui Swagger configurado para documentação e testes dos endpoints.

Após iniciar o projeto, o endereço do Swagger é exibido de acordo com a porta configurada no ambiente.

Normalmente, pode ser acessado através de:

```text
http://localhost:<porta>/swagger
```

---

# 🗄️ Entity Framework Core

Os projetos utilizam diferentes formas de persistência durante a evolução da disciplina.

### Banco em memória

A API de tarefas utiliza:

```text
Entity Framework Core InMemory
```

permitindo praticar operações CRUD antes da utilização de um banco persistente.

### MySQL

As atividades posteriores utilizam **Entity Framework Core + MySQL**.

Entre os conceitos praticados estão:

* `DbContext`;
* `DbSet`;
* migrations;
* criação de tabelas;
* atualização do banco;
* consultas assíncronas;
* relacionamento entre entidades.

---

# 📁 Estrutura do repositório

```text
csharp-topicos-especiais-de-sistemas/
│
├── Aula01/                 # Introdução ao C#
├── Aula02/                 # Classes, objetos e métodos
├── Aula03/                 # Introdução às Minimal APIs
│
├── Aula04/
│   └── TarefasApi/         # CRUD + EF Core InMemory
│
├── Aula05/
│   ├── TarefasApi/         # API de tarefas
│   └── Restaurante/        # Introdução ao EF Core + MySQL
│
├── Aula06/
│   ├── Aula06_react/       # API, relacionamentos e Swagger
│   └── appfront/           # Introdução ao React
│
├── Aula07/
│   └── Aula07/             # Exercícios com React
│
├── Aula08/
│   ├── m-apis-rel/         # APIs relacionadas + EF Core
│   ├── app-front/          # React + React Router
│   └── Componentes HTML/   # Formulários e layouts
│
├── PetShop/                # API REST com .NET + MySQL
│
└── README.md
```

---

# ▶️ Como executar

Os diretórios representam **atividades independentes**, portanto não existe um único comando para executar todo o repositório.

## ✔️ Pré-requisitos

Para os projetos .NET:

* [.NET SDK 8](https://dotnet.microsoft.com/download/dotnet/8.0)

Para os projetos com MySQL:

* MySQL Server

Para as atividades React:

* Node.js
* npm

---

## 🔙 Executando uma API

Por exemplo, para executar a API de tarefas:

```bash
cd Aula04/TarefasApi
dotnet restore
dotnet run
```

Para executar o projeto PetShop:

```bash
cd PetShop
dotnet restore
dotnet run
```

---

## 📚 Swagger

Nos projetos que possuem Swagger configurado, após iniciar a API acesse:

```text
http://localhost:<porta>/swagger
```

A porta utilizada é informada pelo .NET no terminal durante a execução.

---

## 🎨 Executando uma aplicação React

Por exemplo:

```bash
cd Aula08/app-front
npm install
npm start
```

A aplicação é normalmente disponibilizada em:

```text
http://localhost:3000
```

---

## 🗄️ Configuração do MySQL

Algumas atividades utilizam strings de conexão locais configuradas diretamente nos projetos.

Antes da execução, ajuste a conexão de acordo com o ambiente utilizado.

Para projetos que possuem migrations, o banco pode ser criado ou atualizado utilizando:

```bash
dotnet ef database update
```

> Pode ser necessário instalar a ferramenta `dotnet-ef` caso ela ainda não esteja disponível no ambiente.

---

# 🎓 Contexto acadêmico

Repositório desenvolvido durante a disciplina **Tópicos Especiais de Sistemas**, do curso de **Análise e Desenvolvimento de Sistemas da Universidade Positivo**.

**Professor:** Geucimar Briatore

As atividades registram a evolução dos conteúdos desde fundamentos de C# até desenvolvimento de APIs REST, persistência de dados, relacionamentos entre entidades e introdução ao desenvolvimento de interfaces com React.

---

## ⚠️ Observação

Os projetos foram desenvolvidos com **finalidade acadêmica** e representam diferentes etapas do processo de aprendizado.

Por esse motivo, algumas atividades utilizam implementações simplificadas e configurações locais específicas.

O objetivo do repositório é registrar a evolução prática no desenvolvimento com **C#, .NET, APIs REST, Entity Framework Core, MySQL e React**.

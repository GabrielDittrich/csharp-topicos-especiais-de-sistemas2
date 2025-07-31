# 🌐 Tópicos Especiais de Sistemas - Universidade Positivo

Este repositório reúne os projetos desenvolvidos na disciplina **Tópicos Especiais de Sistemas**, do curso de **Análise e Desenvolvimento de Sistemas da Universidade Positivo**. A disciplina combina **backend em C# com .NET Core** e **frontend com React**, proporcionando uma experiência completa no desenvolvimento de **aplicações web full stack** modernas.

---

## 👨‍🏫 Professor

Geucimar Briatore

---

## 🎯 Objetivo da Disciplina

Capacitar o aluno a desenvolver sistemas web completos, utilizando:
- Técnicas de **Programação Orientada a Objetos (POO)** com C#,
- Criação de **APIs RESTful** com .NET,
- Consumo das APIs em **interfaces dinâmicas React**,
- Documentação com **Swagger**,
- Persistência com **Entity Framework Core** e **MySQL**.

---

## 🛠️ Tecnologias Utilizadas

### 🔧 Backend
- **C#** – Linguagem principal da API
- **.NET Core / Minimal API** – Framework leve e moderno para criação de APIs REST
- **Entity Framework Core** – ORM para mapeamento objeto-relacional
- **Swagger** – Documentação e testes da API
- **MySQL** – Banco de dados relacional

### 🎨 Frontend
- **React** – Biblioteca para criação de interfaces reativas
- **Axios** – Cliente HTTP para requisições à API
- **JavaScript / JSX** – Estrutura de componentes front-end

---

## 📚 Conteúdos Abordados

- Programação orientada a objetos com **classes, métodos e atributos**
- Criação e consumo de **Minimal APIs**
- Estrutura de projeto com **MVC, Repository e DAO**
- Conexão com banco de dados via **Entity Framework Core**
- Validações com **Data Annotations**
- Uso de **LINQ** e expressões **Lambda**
- Documentação de API com **Swagger**
- Integração front-end com **React + Axios**
- Versionamento de código com **Git**

---

## 🚀 Como Executar o Projeto

### ✔️ Pré-requisitos

- [.NET SDK](https://dotnet.microsoft.com/)
- [Node.js](https://nodejs.org/)
- [MySQL Server](https://www.mysql.com/)

### ▶️ Passos

```bash
# Clone o repositório
git clone https://github.com/GabrielDittrich/csharp-topicos-especiais-de-sistemas.git
```
## 🔙 Backend
```bash
cd backend
# Configure a string de conexão no appsettings.json
dotnet restore
dotnet ef database update   # cria o banco no MySQL
dotnet run
```
## 🔜 Frontend
```bash
cd frontend
npm install
npm start
```
## 🌐 Acesse:
- Frontend: http://localhost:3000

- Swagger da API: http://localhost:5000/swagger

### 📁 Estrutura do Projeto

<pre>
   csharp-topicos-especiais-de-sistemas/
├── backend/
│   ├── Controllers/
│   ├── Models/
│   ├── Data/
│   ├── Migrations/
│   └── Program.cs
├── frontend/
│   ├── src/
│   ├── public/
│   └── package.json
</pre>

--- 

#### 📄 Bibliografia da Disciplina
Sharp, J. – Microsoft Visual C# 2008: Passo a Passo

Stellman, A. – Use a Cabeça! C#

Flanagan, D. – JavaScript: O Guia Definitivo

Miletto, E. – Desenvolvimento de Software II: Web com HTML, CSS, JS e PHP

#### 📝 Observações
Este projeto foi desenvolvido com fins educacionais, representando minha experiência com aplicações web full stack, integrando front e back-end com base em boas práticas de arquitetura, documentação e persistência de dados.



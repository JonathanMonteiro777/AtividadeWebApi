# Atividade Web Api

Este repositório contém o código e as instruções para uma aplicação CRUD básica construída usando .NET e o banco de dados SQL Server.

## O que você precisará:

- **Visual Studio Code**: Baixe e instale a versão mais recente do Visual Studio Code a partir de [Visual Studio Code](https://code.visualstudio.com/).
- **SDK .NET**: Baixe e instale o SDK .NET versão 8 a partir de [SDK .NET](https://dotnet.microsoft.com/download).
- **SQL Server Management Studio (SSMS)**: Baixe e instale o SSMS a partir de [SQL Server Management Studio](https://www.microsoft.com/en-us/sql/sql-server-management-studio).
- **Insomnia ou Postman**: Você precisará de uma ferramenta para testar sua API. Insomnia é uma opção popular, mas o Postman também é uma boa opção.

## O que foi feito:

A aplicação agora contém os seguintes recursos:

- **CRUD de Projetos**: Permite criar, ler, atualizar e excluir projetos. Cada projeto possui as propriedades `NomeDoProjeto`, `Area` e `Status`.
  
- **CRUD de Usuários**: Foi implementado um CRUD para gerenciar usuários. Cada usuário tem `Email` e `Senha`.

## O que fazer:

1. **Configurar o banco de dados**:
    - Crie um banco de dados chamado "ExoApi" no SSMS.
    - Utilize o arquivo SQL "cria-db.sql" para criar as tabelas necessárias para os projetos e usuários.

2. **Explorar o projeto**:
    - Abra o arquivo de projeto fornecido ("Atividade Web Api") no Visual Studio Code.
  
3. **Completar as operações CRUD**:
    - O CRUD para **Projetos** e **Usuários** já está implementado. Você pode realizar as seguintes operações para ambos:
      - **Criar**: Enviar dados para criar um novo projeto ou usuário.
      - **Ler**: Obter todos os projetos ou usuários ou buscar por ID.
      - **Atualizar**: Modificar um projeto ou usuário existente.
      - **Deletar**: Excluir um projeto ou usuário.

4. **Testar sua API**:
    - Utilize Insomnia ou Postman para testar os endpoints da API. Os principais endpoints são:
      - `GET /api/projetos` — Lista todos os projetos.
      - `POST /api/projetos` — Cria um novo projeto.
      - `GET /api/projetos/{id}` — Busca um projeto por ID.
      - `PUT /api/projetos/{id}` — Atualiza um projeto existente.
      - `DELETE /api/projetos/{id}` — Exclui um projeto.
      - `GET /api/usuarios` — Lista todos os usuários.
      - `POST /api/usuarios` — Cria um novo usuário.
      - `GET /api/usuarios/{id}` — Busca um usuário por ID.
      - `PUT /api/usuarios/{id}` — Atualiza um usuário existente.
      - `DELETE /api/usuarios/{id}` — Exclui um usuário.

## Este README fornece informações básicas sobre como implementar as funcionalidades desta atividade.

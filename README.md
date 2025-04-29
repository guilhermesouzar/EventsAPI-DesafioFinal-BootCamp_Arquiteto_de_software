# EventsAPI - Desafio Final | BootCamp Arquiteto de Software

> **Autor:** Guilherme de Souza Reis  
> **Desafio:** Projeto Final do BootCamp Arquiteto de Software  
> **Tecnologias:** C# · ASP.NET Core · Entity Framework · Docker · SQL Server  
> **Repositório GitHub:** [🔗 github.com/guilhermesouzar/EventsAPI-DesafioFinal-BootCamp_Arquiteto_de_software](https://github.com/guilhermesouzar/EventsAPI-DesafioFinal-BootCamp_Arquiteto_de_software)

---

## Sobre o Projeto

Esta aplicação foi desenvolvida como parte do desafio final do BootCamp **Arquiteto de Software (DESF5)**, com o objetivo de aplicar conceitos de arquitetura de software, boas práticas de desenvolvimento e organização de código.

A API RESTful tem como domínio o gerenciamento de **eventos de contato com clientes**, com foco em um cenário real de uso, podendo futuramente ser integrada ao **DattaNew**, já em produção.

---

##  Etapas do Desenvolvimento

### 1. Stack e Domínio
- Escolha do ASP.NET Core por familiaridade com C# e alinhamento com prazos.
- Domínio escolhido: **Eventos**, com potencial de uso real.

### 2. Planejamento e Arquitetura
- Modelagem com **C4 Model**.
- Estruturação da aplicação com o padrão **MVC + Service + Repository**.

### 3. Ambiente de Desenvolvimento
- Editor: **Visual Studio Code**  
- Extensões utilizadas:
  - C# Dev Kit
  - .NET Install Tool
  - .NET Extension Pack
  - Swagger
  - Prettier

### 4. Configuração Inicial
- Criação da Model, DbContext e configuração do **Entity Framework Core**.
- Inicialização da API e validação de dependências.

### 5. Banco de Dados
- Utilização de **SQL Server via Docker**.
- Interface com **SSMS** para consultas e verificações.

### 6. Controllers e DTOs
- Criação de endpoints RESTful (GET, POST, PUT, DELETE) de forma assíncrona.
- Utilização de DTOs para transferência de dados entre camadas.

### 7. Service & Repository Pattern
- Interfaces implementadas para garantir **injeção de dependência** e **baixo acoplamento**.
- Validações de funcionalidade do padrão.

### 8. Regras de Negócio
- Reaproveitamento de métodos para implementar regras como **contagem de registros**.
- Inclusão de funcionalidades extras solicitadas no desafio.

### 9. Repositório
- Código-fonte disponível no GitHub com instruções e documentação detalhada.

---

##  Estrutura do Projeto
EventsAPI/
├── Controllers/       # Endpoints HTTP
├── Models/            # Entidades e mapeamento EF
├── Repository/        # Acesso ao banco de dados
├── Service/           # Regras de negócio
├── Interface/         # Interfaces para Service/Repository
├── Migrations/        # Histórico de alterações do banco
├── Properties/        # Configurações do projeto
├── wwwroot/           # Arquivos estáticos
├── appsettings.json   # Configurações da aplicação
├── Program.cs         # Inicialização da aplicação

---

## C4 Model | Diagramas Arquiteturais

A documentação segue o padrão **C4 Model** com os seguintes níveis:

- **Contexto (C1)**: Relação entre o usuário, a API e o banco de dados.  
- **Contêineres (C2)**: Representação da separação entre Controller, Service, Repository e banco.  
- **Componentes (C3)**: Camadas internas de cada contêiner.  
- **Código (C4)**: DTOs, Models e estruturas de mapeamento.

---

## Executando o Projeto

> **Pré-requisitos:**
- [.NET SDK 9.0](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [Docker](https://www.docker.com/)
- SQL Server (via Docker ou local)
- Visual Studio Code (opcional)

### Clonando o repositório

```bash
git clone https://github.com/guilhermesouzar/EventsAPI-DesafioFinal-BootCamp_Arquiteto_de_software
cd EventsAPI-DesafioFinal-BootCamp_Arquiteto_de_software
```

Em seu terminal Docker execute o comando para subir uma instancia SQLServer (porta modificada para 1344) utilizando o arquivo do repositório

```
docker-compose -f docker-compose-sql.yaml up -d

```

No terminal do VSCode execute:

```
dotnet ef migrations add InitialCreate

dotnet ef database update

dotnet run
```

Acesse a aplicação em http://localhost:5244/swagger/index.html

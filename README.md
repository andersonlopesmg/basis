# Basis Store - Desafio Técnico 

> Arquitetura de Software | Clean Architecture | DDD | DevOps

Este repositório contém a solução desenvolvida para o desafio técnico. O projeto foi arquitetado simulando um cenário corporativo real de alta complexidade, priorizando robustez, escalabilidade e manutenibilidade.
A solução entrega uma infraestrutura completa em Docker, observabilidade com ELK Stack, API Gateway e relatórios gerados via código.

## Visão Geral da Solução

O sistema foi desenhado seguindo os princípios da Clean Architecture, garantindo que o domínio permaneça independente de frameworks e infraestrutura.

### Diferenciais Técnicos Implementados
* Domínio Rico (DDD): Uso de Value Objects (ex: `Titulo`, `Preco`) e Aggregate Roots para encapsular regras de negócio e validações.
* Persistência Avançada: Mapeamento N:N explícito com EF Core e Data Seeding programático para gerar massa de dados (50+ livros).
* Observabilidade Centralizada: Logs estruturados com Serilog enviados ao Elasticsearch e visualizados no Kibana.
* Relatórios Code-First: Uso da biblioteca QuestPDF para geração de relatórios PDF via C#.
* Frontend Moderno: Aplicação Angular 21 com Standalone Components e Lazy Loading.
---

## Arquitetura e Tecnologias

### Backend (.NET 8.0)
* Clean Architecture (Domain, Application, Infrastructure, API)
* Padrão Use Case
* Entity Framework Core 8
* Serilog
* QuestPDF

### Frontend (Angular 21)
* Standalone Components
* Lazy Loading
* PrimeNG e Bootstrap
* Services modulares

### Infraestrutura (Docker Compose)
O ambiente sobe 5 contêineres:

1. SQL Server 2022
2. Elasticsearch
3. Kibana
4. Kong API Gateway
5. Kafka & Zookeeper (mensageria futura) - havia criado com o objetivo de enviar uma mensagem ao alterar valor.
---

## Como Executar o Projeto

### Pré-requisitos
* Docker Desktop ou Docker Engine
* .NET 8.0 SDK
* Node.js (LTS)
* Angular CLI
* EF Core CLI
* Cliente SQL (SSMS, Azure Data Studio ou DBeaver)

Instalação do EF Core CLI:
```bash
dotnet tool install --global dotnet-ef
```
---

## Passo 1: Subir a Infraestrutura (Docker)

```bash
docker compose up -d
```

Aguarde cerca de 30 segundos para o SQL Server estar pronto.

---

## Passo 2: Configuração Manual do Banco de Dados

Conectar:

```
Servidor: localhost,1433
Usuário: sa
Senha: BasisDeveloper2025!
```

Executar o script em:

```
./sql-init/init.sql
```

Isso cria o banco `basis_store` e o usuário `basis` com a senha `Basis@1234`.
_A aplicação foi versionado com os valores de connection string no appsettings.development, estes valores foram versionados, pois esta aplicação não é de produção e assim facilita a execução e testes._

---

## Passo 3: Aplicar Migrations e Seeding

```bash
dotnet ef database update --project Basis.Store.Infrastructure --startup-project Basis.Store.Api
```

Este comando cria as tabelas e popula com livros, autores e assuntos aleatórios.

---

## Passo 4: Iniciar o Backend

```bash
cd Basis.Store.Api
dotnet run
```

API:  
https://localhost:7073  
Swagger:  
https://localhost:7073/swagger

---

## Passo 5: Iniciar o Frontend

```bash
cd Frontend
npx npm install
npx ng serve
```

Frontend:  
http://localhost:4200

---

## Acessos Úteis

* Aplicação Web: http://localhost:4200
* Swagger: https://localhost:7073/swagger
* Kibana: http://localhost:8000/kibana - através do kong
* Index Pattern: `basis-store-api-*`

---

## Testando as Funcionalidades

* Tela "Livros"
* Download do relatório PDF (QuestPDF)
* Logs estruturados no Kibana
---

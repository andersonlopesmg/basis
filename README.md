# basis
Projeto de teste basis tecnologia desenvolvido por Anderson Lopes

# Instruções para execução da aplicação

## Infra
No Doker Desktop ou Docker convencional executar ´docker compose up -d´ usando o arquivo de docker existente na pasta 'infra' do projeto.

Quando os containners estiverem ativivos, conectar no SQL 'localhost:1433' com o usuário 'SA' e senha 'SA@Pa$$w0rd123' e executar o script existente na pasta 'infra/sql-init/init.sql'
Este script irá gerar:
1. Banco de dados utilizado pela aplicação 'basis_store'
2. Usuário utilizado pela aplicação: usuario: '**basis**' senha: '**Basis@1234**'
   
_A aplicação foi versionado com os valores de connection string no appsettings.development, estes valores foram versionados, pois esta aplicação não é de produção e assim então facilita a execução e testes._



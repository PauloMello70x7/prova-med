# Prova Prover

Para execução do projeto é necessário realizar os seguintes passos:


## Scripts para criação do banco de dados

Após a execução do procedimento acima, é preciso executar o scripts localizados na pasta "_Sql", os mesmos irão criar as tabelas do modelo de domínio e as tabelas referentes ao Identity, além de criar um usuário de teste para que os testes consigam realizar o login, recuperar o Token e executarem. 
* Porém também foi implementado o método para cadastrar um novo usuário caso seja preciso.

## O que foi implementado?

- DDD
- Entity Framework Core
- SQL Server
- Testes
- Logger
- Autenticação no sistema com Identity com JWT
- Swagger

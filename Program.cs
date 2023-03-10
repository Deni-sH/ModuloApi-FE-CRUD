
using Microsoft.EntityFrameworkCore;
using ModuloAPI.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AgendaContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

/*

Webapi trabalha com requisições HTTP e tambem utiliza verbos HTTt pra realizar suas chamadas
Controller: é uma classe que vai agrupar as suas requisições HTTP e vai disponibilizar seus endpoints.
Ou seja vai agrupar todas as ações em comum e vai agrupar em uma controller

dotnet new watch = hot reload
= toda mudança que eu fizer no meu código eu não preciso parar e executar denovo
porque ele vai ficar monitorando, e se houver mudanças ele vai automaticamente
pegar essas mudanças.  


Qual a principal função de uma API?
r: Disponibilizar métodos (endpoints) e serviços, permitindo a comunicação e integração entre diferentes sistemas

O que a sigla "API" significa?
r: Application Programming Interface

Para criar uma API através do .NET CLI, utilizamos o comando:
r: dotnet new webapi

É muito importante documentarmos a nossa API, principalmente quando ela será disponibilizada na internet para outras 
pessoas utilizarem. Para documentar a nossa API de uma maneira rápida e prática, podemos utilizar 
uma especificação, chamada de:
r: Swagger/OpenAPI

dotnet tool install --global dotnet-ef






--- Entity Framework AND CRUD
O EF é um framework ORN (Object-Relational Mapping) criado para facilitar a integração com o banco de dados
mapeando tabelas e gerando SQL de forma automática.

Para vc persistir(salvar) dados de um programa c# para um banco de dados vc tem que fazer a comunicação da mesma
lingua do banco de dados.

Persistencia dos dados ou seja eu quero salvar um usuário por exemplo e esse usuário que eu estou salvando 
eu vou inserir no meu programa(API) e esses dados que a API recebeu, eu quero salvar em uma tabela no meu
banco de dados pra quando eu encerrar minha API eu nao perca esses dados. eles continuem sendo salvos no
meu banco de dados e eu possa obter quando eu quiser esses dados, inclusive retornando na minha API
SQL principal meio de comunicação entre o banco de dados.

EF = Ele é capaz de abstrair toda essa comunicação e geração do SQL de forma automática.
ou seja
= o Entity Framework ele é um ORM ele facilita a comunicação com o banco de dados onde vc nao precisa
ficar escrevendo suas query de forma manual e tambem ele consegue mapear as suas tabelas do banco de dados 
vc é capaz de trabalhar com banco de dados sem escrever uma unica query usando o EF

---CRUD

CREATE - insert
READ - Select
UPDATE - Update 
DELETE - Delete

tegração com o banco de dados


Criação ->DbContext > Entities Contato(representa tabela do banco de dados)>AgendaContext(representar o banco de dados)>dbSet para
representar uma tabela>Cadastramos a conexão em Development >configuração no Program pra usar a conexão padrão;

--migration
dotnet-ef migrations add CriacaoTabelaContato


Para obtermos um recurso, ou seja, um determinado registro de uma API, usamos o verbo HTTP:
r: GET

Qual o significado de CRUD?
r: CREATE, RED, UPDATE, DELETE.

Ao obtermos um recurso de uma API, podemos passar algumas informações, dentre elas, o ID. 
Caso determinado ID não exista, então a API nos retornará um resultado HTTP, que é:
r: 404 NOT FOUND.

O Entity Framework é muito usado em diversos projetos, pois auxilia muito o 
desenvolvedor na construção de uma aplicação. Dentre suas principais 
vantagens, podemos citar:
r: Fácil integração com banco de dados, como criação de tabelas e execução de comandos CRUD no banco de dados, sem a necessidade de excrevermos comandos SQL.

Para inserirmos um novo recurso de uma API, ou seja, incluir um novo registro, usamos o verbo HTTP:
r: POST.

Para apagarmos um novo recurso de uma API, ou seja, remover um registro existente, usamos o verbo HTTP:
r: DELETE.

Para atualizarmos um recurso de uma API, ou seja, atualizar um registro existente, usamos o verbo HTTP:
r: PUT.

---API
Application Programming Interface: é uma forma de comunicação entre computadores ou programas de
computadores.
Em outras palavras, é um software que fornece informações para outro software.
Integração entre sistemas, ela serve pra buscar uma informação contida em um outro sistema ou em um
outro lugar e retornar essa informação até voce.
Intermédio entre o server e o cliente
Cada API tem uma entrada diferente, retorna diferente.
Pensa que uma API é um outro sistema que vc precisa saber usar esse sistema pra fazer uma integração com o seu sistema
ou pra vc poder obter uma informação que vc deseja.










*/

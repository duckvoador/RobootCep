# RobotCep 

## O que é o RobotCep?
RobotCep é um projeto que tem como objetivo criar um robô capaz de buscar informações sobre endereços a partir de CEPs.
Utilizando uma base de dados PostgreSQL, o projeto permite atualizar e consultar dados de endereços de forma eficiente.
Vale lembrar que esse he uma base generica para atualizações de bancos em massa e deve ser adquado de acordo a nescecidade.
Esse projeto foi construido para rodar em ambientes em nuvem (ex.AWS, Azure) porem nessa versão armazenada tomei a liberdade de configura-lo em um ambiente local, com recursos suficientes para replicalo e efetuar ajustes em ambientes de teste locais.


## Como funciona?
1. Um Robô fica escutando por meio de um End-point um determinado campo do banco de dados.
2. Ao observar que houve um registro que atende a um requisito o Robô ativa uma consulta via um end-point. No caso espcifico obtendo o Numero do CEP.  
3. Em seguida com o dado adquirido o robô fas uma consulta e obtem os dados a serem armazenados. Nesse caso Puxamos os dados de uma Api de consulta de endereços mas poderiamos puxar de uma pagina Web
4. O robo com os dados preparados ativa um end-poit para atualizaçã dos dados no banco.


## Pré-requisitos
* Docker
* Git
* SDK .NET

## Instalação e Execução
 1. Inicialmente gere um banco no Docker. No nosso exempolo use o codigo a seguir 
 1.1 Cria o volume para armazenar dados:  docker volume create meu_volume
 1.2 Cria container com senha e volume: docker run -p 5432:5432 -e POSTGRES_PASSWORD=123456 -v meu_volume:/var/lib/postgresql/data -d postgres
 1.3 Efetue a parametrização do banco teste  com a consulta a seguir:
    1.3.1 Para Criar as tabelas :
     CREATE TABLE "Enderecos" (
	"Id" serial  PRIMARY KEY,
	"CEP" VARCHAR (15),
	"Logadouro" VARCHAR(200),
	"Bairro" VARCHAR(200),
	"UF" VARCHAR(10),
	"Status" INT,
	"Robo" VARCHAR(20)) ;
    1.3.2 Consulte o banco:
	 SELECT "Id", "CEP", "Logadouro", "Bairro", "UF", "Status", "Robo"
	 FROM public."Enderecos";

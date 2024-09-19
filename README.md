# RobotCep

## Comando gerar container Docker com Banco Postgresql:
### Cria o volume para armazenar dados:  docker volume create meu_volume
### Cria container com senha e volume: docker run -p 5432:5432 -e POSTGRES_PASSWORD=123456 -v meu_volume:/var/lib/postgresql/data -d postgres

##Consulta para criação do banco experimnetal:
### CREATE TABLE "Endereco" (
	"Id" serial  PRIMARY KEY,
	"CEP" VARCHAR (15),
	"Logradouro" VARCHAR(200),
	"Bairro" VARCHAR(200),
	"US" VARCHAR(2),
	"Status" INT,
	"Robo" VARCHAR(20)
) ;
SELECT "Id", "CEP", "Logradouro", "Bairro", "US", "Status", "Robo"
FROM public."Endereco";

/* POSTGRES */

CREATE DATABASE justdothework;

CREATE TABLE atividade(

	id SERIAL PRIMARY KEY,
	nome VARCHAR(50) NOT NULL, 
	descricao TEXT,
	status INT NOT NULL,
	projetoId INT, 
	datacriacao TIMESTAMP NOT NULL,
	datafinalizacao TIMESTAMP NULL
);

CREATE TABLE Execucao(

	id SERIAL PRIMARY KEY,
	datainicio TIMESTAMP NOT NULL,
	datafim TIMESTAMP NULL,
	atividadeid INT NOT NULL

);

CREATE TABLE projeto(

	id SERIAL PRIMARY KEY,
	nome VARCHAR(50) NOT NULL
);


ALTER TABLE atividade
ADD CONSTRAINT fk_projeto_atividade FOREIGN KEY(projetoid) REFERENCES projetoid)

ALTER TABLE execucao
ADD CONSTRAINT fk_atividade_execucao FOREIGN KEY(atividadeid) REFERENCES atividade(id)

CREATE TABLE modelorelatorio(

	id SERIAL PRIMARY KEY,
	descricao VARCHAR(50) NOT NULL,
	tipomodeloid INT NOT NULL,
	texto TEXT,
	ativo BOOLEAN NOT NULL
);

CREATE TABLE tipomodelo(

	id SERIAL PRIMARY KEY,
	descricao VARCHAR(50) NOT NULL
);

ALTER TABLE modelorelatorio
ADD CONSTRAINT fk_tipoModelo_modelorelatorio FOREIGN KEY(tipomodeloid) REFERENCES tipomodelo(id)

INSERT INTO tipomodelo VALUES ('Histórico Execução')

/* SQL SERVER */

CREATE DATABASE JustDoTheWork;

CREATE TABLE Atividade(

	Id INT IDENTITY PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL, 
	Descricao VARCHAR(MAX),
	Status INT NOT NULL,
	ProjetoId INT, 
	DataCriacao DATETIME NOT NULL,
	DataFinalizacao DATETIME NULL
);

CREATE TABLE Execucao(

	Id INT IDENTITY PRIMARY KEY,
	DataInicio DATETIME NOT NULL,
	DataFim DATETIME NULL,
	AtividadeId INT NOT NULL

);

CREATE TABLE Projeto(

	Id INT IDENTITY PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL
);


ALTER TABLE Atividade
ADD CONSTRAINT FK_Projeto_Atividade FOREIGN KEY(ProjetoId) REFERENCES Projeto(Id)

ALTER TABLE Execucao
ADD CONSTRAINT FK_Atividade_Execucao FOREIGN KEY(AtividadeId) REFERENCES Atividade(Id)


CREATE TABLE ModeloRelatorio(

	Id INT IDENTITY PRIMARY KEY,
	Descricao VARCHAR(50) NOT NULL,
	TipoModeloId INT NOT NULL,
	Texto VARBINARY(MAX),
	Ativo BIT NOT NULL
);

CREATE TABLE TipoModelo(

	Id INT IDENTITY PRIMARY KEY,
	Descricao VARCHAR(50) NOT NULL

);

ALTER TABLE ModeloRelatorio
ADD CONSTRAINT FK_TipoModelo_ModeloRelatorio FOREIGN KEY(TipoModeloId) REFERENCES TipoModelo(Id)

INSERT INTO TipoModelo VALUES ('Histórico Execução')
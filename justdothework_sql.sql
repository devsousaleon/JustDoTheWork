/* POSTGRESQL — execute somente esta seção no banco justdothework.
   A criação do banco deve ser feita antes, com CREATE DATABASE justdothework.
   Para atualizar uma instalação existente, o aplicativo aplica os scripts
   JustDoTheWork.Infrastructure/Scripts/AtualizarFluxo*.sql após o login. */

CREATE TABLE tipousuario (
    id SERIAL PRIMARY KEY,
    tipo VARCHAR(50) NOT NULL
);
INSERT INTO tipousuario (tipo) VALUES ('Historiador'), ('Desenvolvedor'), ('QA Tester'), ('Tech Lead');

CREATE TABLE usuario (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(30) NOT NULL,
    logon VARCHAR(30) NOT NULL,
    senha VARCHAR(100) NOT NULL,
    tipousuarioid INT NOT NULL REFERENCES tipousuario(id)
);
CREATE INDEX ix_usuario_logon ON usuario(logon);

CREATE TABLE projeto (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(50) NOT NULL
);
CREATE TABLE atividade (
    id SERIAL PRIMARY KEY,
    nome VARCHAR(50) NOT NULL,
    descricao BYTEA,
    status INT NOT NULL DEFAULT 2,
    projetoid INT NULL REFERENCES projeto(id),
    datacriacao TIMESTAMP NOT NULL,
    datafinalizacao TIMESTAMP NULL,
    etapa INT NOT NULL DEFAULT 1,
    usuarioresponsavelid INT NULL,
    ultimodesenvolvedorid INT NULL REFERENCES usuario(id),
    retornoexclusivo BOOLEAN NOT NULL DEFAULT FALSE,
    CONSTRAINT fk_usuarioresponsavel_atividade FOREIGN KEY (usuarioresponsavelid) REFERENCES usuario(id)
);
CREATE INDEX ix_atividade_usuarioresponsavelid_status ON atividade(usuarioresponsavelid, status);
CREATE INDEX ix_atividade_projetoid ON atividade(projetoid);
CREATE INDEX ix_atividade_status ON atividade(status);
CREATE TABLE execucao (
    id SERIAL PRIMARY KEY,
    datainicio TIMESTAMP NOT NULL,
    datafim TIMESTAMP NULL,
    atividadeid INT NOT NULL REFERENCES atividade(id),
    usuarioid INT NULL REFERENCES usuario(id),
    etapa INT NULL
);
CREATE INDEX ix_execucao_atividadeid ON execucao(atividadeid);
CREATE INDEX ix_execucao_atividade_etapa_datafim ON execucao(atividadeid, etapa, datafim);
CREATE TABLE tipomodelo (
    id SERIAL PRIMARY KEY,
    descricao VARCHAR(50) NOT NULL
);
INSERT INTO tipomodelo (descricao) VALUES ('Histórico Execução');
CREATE TABLE modelorelatorio (
    id SERIAL PRIMARY KEY,
    descricao VARCHAR(50) NOT NULL,
    tipomodeloid INT NOT NULL REFERENCES tipomodelo(id),
    texto BYTEA,
    ativo BOOLEAN NOT NULL
);

/* SQL SERVER — execute somente esta seção no banco JustDoTheWork.
   A criação do banco deve ser feita antes, com CREATE DATABASE JustDoTheWork.
   As senhas de usuários devem conter hash BCrypt. Cadastre o primeiro Tech Lead
   com o ID do tipo consultado no banco, sem assumir IDs fixos. */

CREATE TABLE TipoUsuario (
    Id INT IDENTITY PRIMARY KEY,
    Tipo VARCHAR(50) NOT NULL
);
INSERT INTO TipoUsuario (Tipo) VALUES ('Historiador'), ('Desenvolvedor'), ('QA Tester'), ('Tech Lead');
CREATE TABLE Usuario (
    Id INT IDENTITY PRIMARY KEY,
    Nome VARCHAR(30) NOT NULL,
    Logon VARCHAR(30) NOT NULL,
    Senha VARCHAR(100) NOT NULL,
    TipoUsuarioId INT NOT NULL REFERENCES TipoUsuario(Id)
);
CREATE INDEX IX_Usuario_Logon ON Usuario(Logon);
CREATE TABLE Projeto (
    Id INT IDENTITY PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL
);
CREATE TABLE Atividade (
    Id INT IDENTITY PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL,
    Descricao VARBINARY(MAX),
    Status INT NOT NULL DEFAULT 2,
    ProjetoId INT NULL REFERENCES Projeto(Id),
    DataCriacao DATETIME NOT NULL,
    DataFinalizacao DATETIME NULL,
    Etapa INT NOT NULL CONSTRAINT DF_Atividade_Etapa DEFAULT 1,
    UsuarioResponsavelId INT NULL,
    UltimoDesenvolvedorId INT NULL,
    RetornoExclusivo BIT NOT NULL CONSTRAINT DF_Atividade_RetornoExclusivo DEFAULT 0,
    CONSTRAINT FK_Atividade_UltimoDesenvolvedor FOREIGN KEY (UltimoDesenvolvedorId) REFERENCES Usuario(Id),
    CONSTRAINT FK_UsuarioResponsavel_Atividade FOREIGN KEY (UsuarioResponsavelId) REFERENCES Usuario(Id)
);
CREATE INDEX IX_Atividade_UsuarioResponsavelId_Status ON Atividade(UsuarioResponsavelId, Status);
CREATE INDEX IX_Atividade_ProjetoId ON Atividade(ProjetoId);
CREATE INDEX IX_Atividade_Status ON Atividade(Status);
CREATE TABLE Execucao (
    Id INT IDENTITY PRIMARY KEY,
    DataInicio DATETIME NOT NULL,
    DataFim DATETIME NULL,
    AtividadeId INT NOT NULL REFERENCES Atividade(Id),
    UsuarioId INT NULL,
    Etapa INT NULL,
    CONSTRAINT FK_Execucao_Usuario FOREIGN KEY (UsuarioId) REFERENCES Usuario(Id)
);
CREATE INDEX IX_Execucao_AtividadeId ON Execucao(AtividadeId);
CREATE INDEX IX_Execucao_Atividade_Etapa_DataFim ON Execucao(AtividadeId, Etapa, DataFim) INCLUDE (UsuarioId);
CREATE TABLE TipoModelo (
    Id INT IDENTITY PRIMARY KEY,
    Descricao VARCHAR(50) NOT NULL
);
INSERT INTO TipoModelo (Descricao) VALUES ('Histórico Execução');
CREATE TABLE ModeloRelatorio (
    Id INT IDENTITY PRIMARY KEY,
    Descricao VARCHAR(50) NOT NULL,
    TipoModeloId INT NOT NULL REFERENCES TipoModelo(Id),
    Texto VARBINARY(MAX),
    Ativo BIT NOT NULL
);

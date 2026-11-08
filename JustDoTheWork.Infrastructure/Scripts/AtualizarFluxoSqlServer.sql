DECLARE @resultado INT;
EXEC @resultado = sys.sp_getapplock @Resource = N'JustDoTheWork.FluxoAtividade',
    @LockMode = 'Exclusive', @LockOwner = 'Transaction', @LockTimeout = 15000;
IF @resultado < 0
    THROW 50001, 'Não foi possível obter o bloqueio para atualizar a estrutura de atividades.', 1;

IF COL_LENGTH(N'dbo.Atividade', N'Etapa') IS NULL
BEGIN
    ALTER TABLE dbo.Atividade ADD Etapa INT NOT NULL CONSTRAINT DF_Atividade_Etapa DEFAULT (1) WITH VALUES;
    EXEC(N'UPDATE dbo.Atividade SET Etapa = 4 WHERE Status = 6; UPDATE dbo.Atividade SET Status = 2 WHERE Status = 1;');
END;
IF COL_LENGTH(N'dbo.Atividade', N'UsuarioResponsavelId') IS NULL
    ALTER TABLE dbo.Atividade ADD UsuarioResponsavelId INT NULL;
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_UsuarioResponsavel_Atividade' AND parent_object_id = OBJECT_ID(N'dbo.Atividade'))
    EXEC(N'ALTER TABLE dbo.Atividade ADD CONSTRAINT FK_UsuarioResponsavel_Atividade FOREIGN KEY (UsuarioResponsavelId) REFERENCES dbo.Usuario(Id);');
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_Atividade_UsuarioResponsavelId_Status' AND object_id = OBJECT_ID(N'dbo.Atividade'))
    EXEC(N'CREATE INDEX IX_Atividade_UsuarioResponsavelId_Status ON dbo.Atividade(UsuarioResponsavelId, Status);');

-- Compatível com as extensões do backend Web; não infere autoria de períodos antigos.
IF COL_LENGTH(N'dbo.Atividade', N'UltimoDesenvolvedorId') IS NULL
    ALTER TABLE dbo.Atividade ADD UltimoDesenvolvedorId INT NULL;
IF COL_LENGTH(N'dbo.Atividade', N'RetornoExclusivo') IS NULL
    ALTER TABLE dbo.Atividade ADD RetornoExclusivo BIT NOT NULL CONSTRAINT DF_Atividade_RetornoExclusivo DEFAULT (0) WITH VALUES;
IF COL_LENGTH(N'dbo.Execucao', N'UsuarioId') IS NULL
    ALTER TABLE dbo.Execucao ADD UsuarioId INT NULL;
IF COL_LENGTH(N'dbo.Execucao', N'Etapa') IS NULL
    ALTER TABLE dbo.Execucao ADD Etapa INT NULL;
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_Atividade_UltimoDesenvolvedor' AND parent_object_id = OBJECT_ID(N'dbo.Atividade'))
    EXEC(N'ALTER TABLE dbo.Atividade ADD CONSTRAINT FK_Atividade_UltimoDesenvolvedor FOREIGN KEY (UltimoDesenvolvedorId) REFERENCES dbo.Usuario(Id);');
IF NOT EXISTS (SELECT 1 FROM sys.foreign_keys WHERE name = N'FK_Execucao_Usuario' AND parent_object_id = OBJECT_ID(N'dbo.Execucao'))
    EXEC(N'ALTER TABLE dbo.Execucao ADD CONSTRAINT FK_Execucao_Usuario FOREIGN KEY (UsuarioId) REFERENCES dbo.Usuario(Id);');
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'IX_Execucao_Atividade_Etapa_DataFim' AND object_id = OBJECT_ID(N'dbo.Execucao'))
    EXEC(N'CREATE INDEX IX_Execucao_Atividade_Etapa_DataFim ON dbo.Execucao(AtividadeId, Etapa, DataFim) INCLUDE (UsuarioId);');

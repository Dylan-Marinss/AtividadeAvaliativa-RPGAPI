BEGIN TRANSACTION;
ALTER TABLE [TB_PERSONAGENS] ADD [FotoPersonagem] varbinary(max) NULL;

ALTER TABLE [TB_PERSONAGENS] ADD [UsuarioId] int NULL;

CREATE TABLE [TB_USUARIO] (
    [Id] int NOT NULL IDENTITY,
    [Username] varchar(200) NOT NULL,
    [PasswordHash] varbinary(max) NULL,
    [PasswordSalt] varbinary(max) NULL,
    [Foto] varbinary(max) NULL,
    [Latitude] float NULL,
    [Longitude] float NULL,
    [DataAcesso] datetime2 NULL,
    [Perfil] varchar(200) NULL DEFAULT 'Jogador',
    [Email] varchar(200) NULL,
    CONSTRAINT [PK_TB_USUARIO] PRIMARY KEY ([Id])
);

UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 1;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 2;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 3;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 4;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 5;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 6;
SELECT @@ROWCOUNT;


UPDATE [TB_PERSONAGENS] SET [FotoPersonagem] = NULL, [UsuarioId] = 1
WHERE [Id] = 7;
SELECT @@ROWCOUNT;


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'Latitude', N'Longitude', N'PasswordHash', N'PasswordSalt', N'Perfil', N'Username') AND [object_id] = OBJECT_ID(N'[TB_USUARIO]'))
    SET IDENTITY_INSERT [TB_USUARIO] ON;
INSERT INTO [TB_USUARIO] ([Id], [DataAcesso], [Email], [Foto], [Latitude], [Longitude], [PasswordHash], [PasswordSalt], [Perfil], [Username])
VALUES (1, NULL, 'emailaleatorio@gmail.com', NULL, -23.520024100000001E0, -46.596497999999997E0, 0xE6E080534251FD83F8897216B874F41C8716A8D7CC93313B3933E2F8B2590D42B787CEAEAFDD6461C3598C4A40F69A02DCA85916DC23D8AF5B8F7E8235022D84, 0x0D88C3D32FB38CAA0DAD5CDBE74F3F88257D1DF4E5BD7A4E7BE0C9294A55363C7786A6D30E45B8C6272937CF20EDD5DAC17DBFB6535431A62D39C78EEE7260EAF4435BB4A03012829380C96ED4324C4AA00460AB41FB0AA63D93BE3DE7CCAE79EA74FEF5F25E1B765446C894BFFA0456BD037A7BE4CA10F5002825E2029ECB9A, 'Admin', 'UsuarioAdmin');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'DataAcesso', N'Email', N'Foto', N'Latitude', N'Longitude', N'PasswordHash', N'PasswordSalt', N'Perfil', N'Username') AND [object_id] = OBJECT_ID(N'[TB_USUARIO]'))
    SET IDENTITY_INSERT [TB_USUARIO] OFF;

CREATE INDEX [IX_TB_PERSONAGENS_UsuarioId] ON [TB_PERSONAGENS] ([UsuarioId]);

ALTER TABLE [TB_PERSONAGENS] ADD CONSTRAINT [FK_TB_PERSONAGENS_TB_USUARIO_UsuarioId] FOREIGN KEY ([UsuarioId]) REFERENCES [TB_USUARIO] ([Id]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20251001224823_MigracaoUsuario', N'9.0.9');

COMMIT;
GO


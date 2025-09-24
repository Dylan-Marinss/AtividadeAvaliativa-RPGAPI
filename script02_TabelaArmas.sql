BEGIN TRANSACTION;
CREATE TABLE [TB_ARMA] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Dano] int NOT NULL,
    CONSTRAINT [PK_TB_ARMA] PRIMARY KEY ([Id])
);

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ARMA]'))
    SET IDENTITY_INSERT [TB_ARMA] ON;
INSERT INTO [TB_ARMA] ([Id], [Dano], [Nome])
VALUES (1, 3, 'Ak-47'),
(2, 5, 'Scar-L'),
(3, 6, 'Magnum'),
(4, 4, '.38'),
(5, 2, 'Cacetete'),
(6, 7, 'MP-40'),
(7, 9, 'Deagle');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Dano', N'Nome') AND [object_id] = OBJECT_ID(N'[TB_ARMA]'))
    SET IDENTITY_INSERT [TB_ARMA] OFF;

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250924005315_MigracaoArma', N'9.0.9');

COMMIT;
GO


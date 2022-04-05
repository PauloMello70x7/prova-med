-- Executar este comando primeiro
CREATE DATABASE ProvaMed
-- Executar este comando primeiro

-- Executar estes comandos em sequida
Use ProvaMed

IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Contato] (
    [Id] uniqueidentifier NOT NULL,
    [Nome] varchar(100) NOT NULL,
    [DataNascimento] datetime NOT NULL,
    [Documento] varchar(14) NOT NULL,
    CONSTRAINT [PK_Contato] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20191228051345_initial', N'2.2.6-servicing-10079');

GO



-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/21/2016 22:10:16
-- Generated from EDMX file: D:\KEJ\Clientes\Desarrollo\Propio\PruebasTecnicas\Banlinea\ChessAPI\DAL\AjedrezContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ajedrez];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TipoFichaDBFichaDB]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FichaDBSet] DROP CONSTRAINT [FK_TipoFichaDBFichaDB];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FichaDBSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FichaDBSet];
GO
IF OBJECT_ID(N'[dbo].[TipoFichaDBSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoFichaDBSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FichaDBSet'
CREATE TABLE [dbo].[FichaDBSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [X] int  NOT NULL,
    [Y] int  NOT NULL,
    [TipoFichaDBId] int  NOT NULL
);
GO

-- Creating table 'TipoFichaDBSet'
CREATE TABLE [dbo].[TipoFichaDBSet] (
    [Id] int  NOT NULL,
    [Nombre] nvarchar(20)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'FichaDBSet'
ALTER TABLE [dbo].[FichaDBSet]
ADD CONSTRAINT [PK_FichaDBSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TipoFichaDBSet'
ALTER TABLE [dbo].[TipoFichaDBSet]
ADD CONSTRAINT [PK_TipoFichaDBSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TipoFichaDBId] in table 'FichaDBSet'
ALTER TABLE [dbo].[FichaDBSet]
ADD CONSTRAINT [FK_TipoFichaDBFichaDB]
    FOREIGN KEY ([TipoFichaDBId])
    REFERENCES [dbo].[TipoFichaDBSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoFichaDBFichaDB'
CREATE INDEX [IX_FK_TipoFichaDBFichaDB]
ON [dbo].[FichaDBSet]
    ([TipoFichaDBId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
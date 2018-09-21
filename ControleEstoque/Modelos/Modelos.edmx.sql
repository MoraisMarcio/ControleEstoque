
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/20/2018 22:51:06
-- Generated from EDMX file: D:\Programacao\Projetos\ControleEstoque\ControleEstoque\Modelos\Modelos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [LojaDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Endereco] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Inventarios'
CREATE TABLE [dbo].[Inventarios] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Fornecedores'
CREATE TABLE [dbo].[Fornecedores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ItemInventarios'
CREATE TABLE [dbo].[ItemInventarios] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Estoque] int  NOT NULL,
    [InventarioId] int  NOT NULL,
    [ProdutoId] int  NOT NULL
);
GO

-- Creating table 'Produtos'
CREATE TABLE [dbo].[Produtos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [PrecoCusto] decimal(18,0)  NOT NULL,
    [Estoque] int  NOT NULL,
    [Cod] int  NOT NULL,
    [UN] nvarchar(3)  NOT NULL
);
GO

-- Creating table 'ItemNotaEntradas'
CREATE TABLE [dbo].[ItemNotaEntradas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Quantidade] float  NOT NULL,
    [ValorUnitario] decimal(18,0)  NOT NULL,
    [ProdutoId] int  NOT NULL,
    [NotaEntradaId] int  NOT NULL
);
GO

-- Creating table 'NotaEntradas'
CREATE TABLE [dbo].[NotaEntradas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Numero] int  NOT NULL,
    [DataEntrada] datetime  NOT NULL,
    [DataEmissao] datetime  NOT NULL,
    [ValorTotal] decimal(18,0)  NOT NULL,
    [FornecedorId] int  NOT NULL
);
GO

-- Creating table 'ItemNotaSaidas'
CREATE TABLE [dbo].[ItemNotaSaidas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Quantidade] float  NOT NULL,
    [ValorUnitario] decimal(18,0)  NOT NULL,
    [ProdutoId] int  NOT NULL,
    [NotaSaidaId] int  NOT NULL
);
GO

-- Creating table 'NotaSaidas'
CREATE TABLE [dbo].[NotaSaidas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataVenda] datetime  NOT NULL,
    [ValorTotal] decimal(18,0)  NOT NULL,
    [TipoPagamento] nvarchar(max)  NOT NULL,
    [ClienteId] int  NOT NULL
);
GO

-- Creating table 'Recebimentos'
CREATE TABLE [dbo].[Recebimentos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DataVendimento] datetime  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [NotaSaidaId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Inventarios'
ALTER TABLE [dbo].[Inventarios]
ADD CONSTRAINT [PK_Inventarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fornecedores'
ALTER TABLE [dbo].[Fornecedores]
ADD CONSTRAINT [PK_Fornecedores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemInventarios'
ALTER TABLE [dbo].[ItemInventarios]
ADD CONSTRAINT [PK_ItemInventarios]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Produtos'
ALTER TABLE [dbo].[Produtos]
ADD CONSTRAINT [PK_Produtos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemNotaEntradas'
ALTER TABLE [dbo].[ItemNotaEntradas]
ADD CONSTRAINT [PK_ItemNotaEntradas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NotaEntradas'
ALTER TABLE [dbo].[NotaEntradas]
ADD CONSTRAINT [PK_NotaEntradas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemNotaSaidas'
ALTER TABLE [dbo].[ItemNotaSaidas]
ADD CONSTRAINT [PK_ItemNotaSaidas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NotaSaidas'
ALTER TABLE [dbo].[NotaSaidas]
ADD CONSTRAINT [PK_NotaSaidas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Recebimentos'
ALTER TABLE [dbo].[Recebimentos]
ADD CONSTRAINT [PK_Recebimentos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [InventarioId] in table 'ItemInventarios'
ALTER TABLE [dbo].[ItemInventarios]
ADD CONSTRAINT [FK_InventarioItemInventario]
    FOREIGN KEY ([InventarioId])
    REFERENCES [dbo].[Inventarios]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InventarioItemInventario'
CREATE INDEX [IX_FK_InventarioItemInventario]
ON [dbo].[ItemInventarios]
    ([InventarioId]);
GO

-- Creating foreign key on [ProdutoId] in table 'ItemInventarios'
ALTER TABLE [dbo].[ItemInventarios]
ADD CONSTRAINT [FK_ProdutoItemInventario]
    FOREIGN KEY ([ProdutoId])
    REFERENCES [dbo].[Produtos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoItemInventario'
CREATE INDEX [IX_FK_ProdutoItemInventario]
ON [dbo].[ItemInventarios]
    ([ProdutoId]);
GO

-- Creating foreign key on [ProdutoId] in table 'ItemNotaEntradas'
ALTER TABLE [dbo].[ItemNotaEntradas]
ADD CONSTRAINT [FK_ProdutoItemNotaEntrada]
    FOREIGN KEY ([ProdutoId])
    REFERENCES [dbo].[Produtos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoItemNotaEntrada'
CREATE INDEX [IX_FK_ProdutoItemNotaEntrada]
ON [dbo].[ItemNotaEntradas]
    ([ProdutoId]);
GO

-- Creating foreign key on [NotaEntradaId] in table 'ItemNotaEntradas'
ALTER TABLE [dbo].[ItemNotaEntradas]
ADD CONSTRAINT [FK_NotaEntradaItemNotaEntrada]
    FOREIGN KEY ([NotaEntradaId])
    REFERENCES [dbo].[NotaEntradas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NotaEntradaItemNotaEntrada'
CREATE INDEX [IX_FK_NotaEntradaItemNotaEntrada]
ON [dbo].[ItemNotaEntradas]
    ([NotaEntradaId]);
GO

-- Creating foreign key on [FornecedorId] in table 'NotaEntradas'
ALTER TABLE [dbo].[NotaEntradas]
ADD CONSTRAINT [FK_FornecedorNotaEntrada]
    FOREIGN KEY ([FornecedorId])
    REFERENCES [dbo].[Fornecedores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FornecedorNotaEntrada'
CREATE INDEX [IX_FK_FornecedorNotaEntrada]
ON [dbo].[NotaEntradas]
    ([FornecedorId]);
GO

-- Creating foreign key on [ProdutoId] in table 'ItemNotaSaidas'
ALTER TABLE [dbo].[ItemNotaSaidas]
ADD CONSTRAINT [FK_ProdutoItemNotaSaida]
    FOREIGN KEY ([ProdutoId])
    REFERENCES [dbo].[Produtos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoItemNotaSaida'
CREATE INDEX [IX_FK_ProdutoItemNotaSaida]
ON [dbo].[ItemNotaSaidas]
    ([ProdutoId]);
GO

-- Creating foreign key on [NotaSaidaId] in table 'ItemNotaSaidas'
ALTER TABLE [dbo].[ItemNotaSaidas]
ADD CONSTRAINT [FK_NotaSaidaItemNotaSaida]
    FOREIGN KEY ([NotaSaidaId])
    REFERENCES [dbo].[NotaSaidas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NotaSaidaItemNotaSaida'
CREATE INDEX [IX_FK_NotaSaidaItemNotaSaida]
ON [dbo].[ItemNotaSaidas]
    ([NotaSaidaId]);
GO

-- Creating foreign key on [ClienteId] in table 'NotaSaidas'
ALTER TABLE [dbo].[NotaSaidas]
ADD CONSTRAINT [FK_ClienteNotaSaida]
    FOREIGN KEY ([ClienteId])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteNotaSaida'
CREATE INDEX [IX_FK_ClienteNotaSaida]
ON [dbo].[NotaSaidas]
    ([ClienteId]);
GO

-- Creating foreign key on [NotaSaidaId] in table 'Recebimentos'
ALTER TABLE [dbo].[Recebimentos]
ADD CONSTRAINT [FK_NotaSaidaRecebimento]
    FOREIGN KEY ([NotaSaidaId])
    REFERENCES [dbo].[NotaSaidas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NotaSaidaRecebimento'
CREATE INDEX [IX_FK_NotaSaidaRecebimento]
ON [dbo].[Recebimentos]
    ([NotaSaidaId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
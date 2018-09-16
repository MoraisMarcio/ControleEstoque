
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/16/2018 11:29:10
-- Generated from EDMX file: C:\PROGRAMAÇÃO\POSITIVO\CSharp\ControleEstoque\ControleEstoque\Modelos\Modelos.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EstoqueDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ProdutoEstoque]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produtos] DROP CONSTRAINT [FK_ProdutoEstoque];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutoItemEntrada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemEntradas] DROP CONSTRAINT [FK_ProdutoItemEntrada];
GO
IF OBJECT_ID(N'[dbo].[FK_CompraItemEntrada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemEntradas] DROP CONSTRAINT [FK_CompraItemEntrada];
GO
IF OBJECT_ID(N'[dbo].[FK_FornecedorCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Compras] DROP CONSTRAINT [FK_FornecedorCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutoItemSaida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemSaidas] DROP CONSTRAINT [FK_ProdutoItemSaida];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaItemSaida]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ItemSaidas] DROP CONSTRAINT [FK_VendaItemSaida];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteVenda]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Vendas] DROP CONSTRAINT [FK_ClienteVenda];
GO
IF OBJECT_ID(N'[dbo].[FK_VendaRecebimento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Recebimentos] DROP CONSTRAINT [FK_VendaRecebimento];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Produtos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produtos];
GO
IF OBJECT_ID(N'[dbo].[Estoques]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estoques];
GO
IF OBJECT_ID(N'[dbo].[ItemEntradas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemEntradas];
GO
IF OBJECT_ID(N'[dbo].[Compras]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Compras];
GO
IF OBJECT_ID(N'[dbo].[Fornecedores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fornecedores];
GO
IF OBJECT_ID(N'[dbo].[ItemSaidas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ItemSaidas];
GO
IF OBJECT_ID(N'[dbo].[Vendas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Vendas];
GO
IF OBJECT_ID(N'[dbo].[Clientes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clientes];
GO
IF OBJECT_ID(N'[dbo].[Recebimentos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Recebimentos];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Produtos'
CREATE TABLE [dbo].[Produtos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Unidade] nvarchar(max)  NOT NULL,
    [PrecoCusto] decimal(18,0)  NOT NULL,
    [PrecoVenda] decimal(18,0)  NOT NULL,
    [EmEstoque] float  NOT NULL,
    [EstoqueId] int  NOT NULL,
    [Estoque_Id] int  NOT NULL
);
GO

-- Creating table 'Estoques'
CREATE TABLE [dbo].[Estoques] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [ProdutoId] int  NOT NULL
);
GO

-- Creating table 'ItemEntradas'
CREATE TABLE [dbo].[ItemEntradas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProdutoId] int  NOT NULL,
    [PrecoUnitario] decimal(18,0)  NOT NULL,
    [Quantidade] float  NOT NULL,
    [Produto_Id] int  NOT NULL,
    [Compra_Id] int  NOT NULL
);
GO

-- Creating table 'Compras'
CREATE TABLE [dbo].[Compras] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FornecedorId] int  NOT NULL,
    [ItemEntradaId] int  NOT NULL,
    [PrecoTotal] decimal(18,0)  NOT NULL,
    [Data] datetime  NOT NULL,
    [Fornecedor_Id] int  NOT NULL
);
GO

-- Creating table 'Fornecedores'
CREATE TABLE [dbo].[Fornecedores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ItemSaidas'
CREATE TABLE [dbo].[ItemSaidas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProdutoId] int  NOT NULL,
    [PrecoUnitario] decimal(18,0)  NOT NULL,
    [Quantidade] float  NOT NULL,
    [Produto_Id] int  NOT NULL,
    [Venda_Id] int  NOT NULL
);
GO

-- Creating table 'Vendas'
CREATE TABLE [dbo].[Vendas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ClienteId] int  NOT NULL,
    [ItemSaidaId] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [PrecoTotal] decimal(18,0)  NOT NULL,
    [Cliente_Id] int  NOT NULL
);
GO

-- Creating table 'Clientes'
CREATE TABLE [dbo].[Clientes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(9)  NOT NULL,
    [Bairro] nvarchar(max)  NOT NULL,
    [Endereco] nvarchar(max)  NOT NULL,
    [NumResidencial] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Recebimentos'
CREATE TABLE [dbo].[Recebimentos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [VendaId] int  NOT NULL,
    [DataVencimento] datetime  NOT NULL,
    [Valor] decimal(18,0)  NOT NULL,
    [Venda_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Produtos'
ALTER TABLE [dbo].[Produtos]
ADD CONSTRAINT [PK_Produtos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Estoques'
ALTER TABLE [dbo].[Estoques]
ADD CONSTRAINT [PK_Estoques]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemEntradas'
ALTER TABLE [dbo].[ItemEntradas]
ADD CONSTRAINT [PK_ItemEntradas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Compras'
ALTER TABLE [dbo].[Compras]
ADD CONSTRAINT [PK_Compras]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fornecedores'
ALTER TABLE [dbo].[Fornecedores]
ADD CONSTRAINT [PK_Fornecedores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemSaidas'
ALTER TABLE [dbo].[ItemSaidas]
ADD CONSTRAINT [PK_ItemSaidas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [PK_Vendas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Clientes'
ALTER TABLE [dbo].[Clientes]
ADD CONSTRAINT [PK_Clientes]
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

-- Creating foreign key on [Estoque_Id] in table 'Produtos'
ALTER TABLE [dbo].[Produtos]
ADD CONSTRAINT [FK_ProdutoEstoque]
    FOREIGN KEY ([Estoque_Id])
    REFERENCES [dbo].[Estoques]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoEstoque'
CREATE INDEX [IX_FK_ProdutoEstoque]
ON [dbo].[Produtos]
    ([Estoque_Id]);
GO

-- Creating foreign key on [Produto_Id] in table 'ItemEntradas'
ALTER TABLE [dbo].[ItemEntradas]
ADD CONSTRAINT [FK_ProdutoItemEntrada]
    FOREIGN KEY ([Produto_Id])
    REFERENCES [dbo].[Produtos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoItemEntrada'
CREATE INDEX [IX_FK_ProdutoItemEntrada]
ON [dbo].[ItemEntradas]
    ([Produto_Id]);
GO

-- Creating foreign key on [Compra_Id] in table 'ItemEntradas'
ALTER TABLE [dbo].[ItemEntradas]
ADD CONSTRAINT [FK_CompraItemEntrada]
    FOREIGN KEY ([Compra_Id])
    REFERENCES [dbo].[Compras]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompraItemEntrada'
CREATE INDEX [IX_FK_CompraItemEntrada]
ON [dbo].[ItemEntradas]
    ([Compra_Id]);
GO

-- Creating foreign key on [Fornecedor_Id] in table 'Compras'
ALTER TABLE [dbo].[Compras]
ADD CONSTRAINT [FK_FornecedorCompra]
    FOREIGN KEY ([Fornecedor_Id])
    REFERENCES [dbo].[Fornecedores]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FornecedorCompra'
CREATE INDEX [IX_FK_FornecedorCompra]
ON [dbo].[Compras]
    ([Fornecedor_Id]);
GO

-- Creating foreign key on [Produto_Id] in table 'ItemSaidas'
ALTER TABLE [dbo].[ItemSaidas]
ADD CONSTRAINT [FK_ProdutoItemSaida]
    FOREIGN KEY ([Produto_Id])
    REFERENCES [dbo].[Produtos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoItemSaida'
CREATE INDEX [IX_FK_ProdutoItemSaida]
ON [dbo].[ItemSaidas]
    ([Produto_Id]);
GO

-- Creating foreign key on [Venda_Id] in table 'ItemSaidas'
ALTER TABLE [dbo].[ItemSaidas]
ADD CONSTRAINT [FK_VendaItemSaida]
    FOREIGN KEY ([Venda_Id])
    REFERENCES [dbo].[Vendas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaItemSaida'
CREATE INDEX [IX_FK_VendaItemSaida]
ON [dbo].[ItemSaidas]
    ([Venda_Id]);
GO

-- Creating foreign key on [Cliente_Id] in table 'Vendas'
ALTER TABLE [dbo].[Vendas]
ADD CONSTRAINT [FK_ClienteVenda]
    FOREIGN KEY ([Cliente_Id])
    REFERENCES [dbo].[Clientes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteVenda'
CREATE INDEX [IX_FK_ClienteVenda]
ON [dbo].[Vendas]
    ([Cliente_Id]);
GO

-- Creating foreign key on [Venda_Id] in table 'Recebimentos'
ALTER TABLE [dbo].[Recebimentos]
ADD CONSTRAINT [FK_VendaRecebimento]
    FOREIGN KEY ([Venda_Id])
    REFERENCES [dbo].[Vendas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaRecebimento'
CREATE INDEX [IX_FK_VendaRecebimento]
ON [dbo].[Recebimentos]
    ([Venda_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
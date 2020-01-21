/*
Created		18/01/2020
Modified		18/01/2020
Project		
Model			
Company		
Author		
Version		
Database		MS SQL 2005 
*/


Create table [Cliente]
(
	[ClienteId] Integer Identity NOT NULL,
	[EstadoId] Char(1) NULL,
	[CidadeId] Char(1) NULL,
	[NomeCliente] Varchar(255) NULL,
	[EmailCliente] Varchar(200) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([ClienteId])
) 
go

Create table [Cidade]
(
	[CidadeId] Integer Identity NOT NULL,
	[EstadoId] Integer NOT NULL,
	[Nome] Varchar(250) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([CidadeId])
) 
go

Create table [Estado]
(
	[EstadoId] Integer Identity NOT NULL,
	[Nome] Varchar(250) NULL,
	[Sigla] Char(2) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([EstadoId])
) 
go

Create table [Produto]
(
	[ProdutoId] Integer Identity NOT NULL,
	[NomeProduto] Varchar(250) NULL,
	[DescricaoProduto] Text NULL,
	[ValorProduto] Decimal(18,2) NULL,
	[DataFabricacao] Datetime NULL,
	[DataValidade] Datetime NULL,
	[FotoProduto] Varchar(200) NULL,
	[ProdutoPromocao] Char(1) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([ProdutoId])
) 
go

Create table [Avaliacao]
(
	[AvaliacaoId] Integer Identity NOT NULL,
	[ProdutoId] Integer NOT NULL,
	[ClienteId] Integer NOT NULL,
	[Titulo] Varchar(250) NULL,
	[Descricao] Text NULL,
	[QuantidadeEstrela] Integer NULL,
	[AvaliacaoUtil] Char(1) NULL,
	[Ativo] Char(1) NULL,
	[DataCadastro] Datetime NULL,
	[DataAlteracao] Datetime NULL,
Primary Key ([AvaliacaoId])
) 
go


Alter table [Avaliacao] add  foreign key([ClienteId]) references [Cliente] ([ClienteId])  on update no action on delete no action 
go
Alter table [Cidade] add  foreign key([EstadoId]) references [Estado] ([EstadoId])  on update no action on delete no action 
go
Alter table [Avaliacao] add  foreign key([ProdutoId]) references [Produto] ([ProdutoId])  on update no action on delete no action 
go


Set quoted_identifier on
go


Set quoted_identifier off
go


/* Roles permissions */



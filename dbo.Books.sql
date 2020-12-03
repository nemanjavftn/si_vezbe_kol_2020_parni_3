CREATE TABLE [dbo].[Books] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (50) NOT NULL,
    [NumberOfPages] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


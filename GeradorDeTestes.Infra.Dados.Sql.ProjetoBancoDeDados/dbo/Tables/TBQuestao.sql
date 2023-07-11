CREATE TABLE [dbo].[TBQuestao] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [titulo]          VARCHAR (100) NOT NULL,
    [opcaoA]          VARCHAR (100) NOT NULL,
    [opcaoB]          VARCHAR (100) NOT NULL,
    [opcaoC]          VARCHAR (100) NOT NULL,
    [opcaoD]          VARCHAR (100) NOT NULL,
    [respostaCorreta] VARCHAR (100) NOT NULL,
    [materia_id]      INT           NOT NULL,
    CONSTRAINT [PK_TBQuestao] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBQuestao_TBMateria] FOREIGN KEY ([materia_id]) REFERENCES [dbo].[TBMateria] ([Id])
);


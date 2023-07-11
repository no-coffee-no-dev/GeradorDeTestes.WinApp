CREATE TABLE [dbo].[TBTestes] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [titulo]        VARCHAR (MAX) NOT NULL,
    [dataDeGeracao] DATETIME      NOT NULL,
    [disciplina_id] INT           NOT NULL,
    [materia_id]    INT           NOT NULL,
    [quantQuestoes] INT           NOT NULL,
    CONSTRAINT [PK_TBTestes] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_TBTestes_TBDisciplina] FOREIGN KEY ([disciplina_id]) REFERENCES [dbo].[TBDisciplina] ([Id]),
    CONSTRAINT [FK_TBTestes_TBMateria] FOREIGN KEY ([materia_id]) REFERENCES [dbo].[TBMateria] ([Id])
);


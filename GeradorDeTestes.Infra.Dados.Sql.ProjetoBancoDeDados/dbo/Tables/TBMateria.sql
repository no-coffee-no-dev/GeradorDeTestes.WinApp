CREATE TABLE [dbo].[TBMateria] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [nome]          VARCHAR (MAX) NOT NULL,
    [serie]         CHAR (2)      NOT NULL,
    [id_disciplina] INT           NOT NULL,
    CONSTRAINT [PK_TBMateria] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_id_disciplina] FOREIGN KEY ([id_disciplina]) REFERENCES [dbo].[TBDisciplina] ([Id])
);


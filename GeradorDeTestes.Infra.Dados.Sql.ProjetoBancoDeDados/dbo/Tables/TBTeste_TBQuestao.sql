CREATE TABLE [dbo].[TBTeste_TBQuestao] (
    [questao_id] INT NOT NULL,
    [teste_id]   INT NULL,
    CONSTRAINT [FK_TBTeste_TBQuestao_TBQuestao] FOREIGN KEY ([questao_id]) REFERENCES [dbo].[TBQuestao] ([Id])
);


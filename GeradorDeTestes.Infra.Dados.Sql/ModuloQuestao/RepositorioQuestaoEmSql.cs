using GeradorDeTestes.Dominio.ModuloQuestao;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestao
{
    public class RepositorioQuestaoEmSql : RepositorioBaseEmSql<Questao, MapeadorQuestao>, IRepositorioQuestao
    {
        public override string SqlInserir => @"INSERT INTO [DBO].[TBQUESTAO]
                                       ([TITULO]
                                       ,[OPCAOA]
                                       ,[OPCAOB]
                                       ,[OPCAOC]
                                       ,[OPCAOD]
                                       ,[RESPOSTACORRETA]
                                       ,[MATERIA_ID])
                                 VALUES
                                       (
                                         @TITULO,
                                         @OPCAOA,
                                         @OPCAOB,
                                         @OPCAOC,
                                         @OPCAOD,
                                         @RESPOSTACORRETA,
                                         @MATERIA_ID
                                       );
                              SELECT SCOPE_IDENTITY();";

        public override string SqlBuscarTodos => @"SELECT 
                                                   TBQ.[ID]
                                                  ,TBQ.[TITULO]
                                                  ,TBQ.[OPCAOA]
                                                  ,TBQ.[OPCAOB]
                                                  ,TBQ.[OPCAOC]
                                                  ,TBQ.[OPCAOD]
                                                  ,TBQ.[RESPOSTACORRETA]
                                                  ,TBQ.[MATERIA_ID]
                                                  ,TBM.[NOME]
                                                  ,TBM.[SERIE]
                                              FROM 
                                                [DBO].[TBQUESTAO] TBQ INNER JOIN TBMATERIA TBM ON TBQ.MATERIA_ID = TBM.ID;";

        public override string SqlDeletar => @"DELETE FROM [dbo].[TBQuestao]
                                                 WHERE [ID] = @ID;";

        public override string SqlBuscaId => @"SELECT 
                                                   TBQ.[ID]
                                                  ,TBQ.[TITULO]
                                                  ,TBQ.[OPCAOA]
                                                  ,TBQ.[OPCAOB]
                                                  ,TBQ.[OPCAOC]
                                                  ,TBQ.[OPCAOD]
                                                  ,TBQ.[RESPOSTACORRETA]
                                                  ,TBQ.[MATERIA_ID]
                                                  ,TBM.[NOME]
                                                  ,TBM.[SERIE]
                                              FROM 
                                                [DBO].[TBQUESTAO] TBQ INNER JOIN TBMATERIA TBM ON TBQ.MATERIA_ID = TBM.ID
                                              WHERE TBQ.[ID] = @ID;";

        public override string SqlEditar => @"UPDATE [DBO].[TBQUESTAO]
                                       SET 
                                           [TITULO] = @TITULO
                                          ,[OPCAOA] = @OPCAOA
                                          ,[OPCAOB] = @OPCAOB
                                          ,[OPCAOC] = @OPCAOC
                                          ,[OPCAOD] = @OPCAOD
                                          ,RESPOSTACORRETA] = @RESPOSTACORRETA
                                          ,[MATERIA_ID] = @MATERIA_ID
                                     WHERE 
                                           [ID] = @ID;";

        public List<string> RetornarTodasAsOpcoes()
        {
            throw new NotImplementedException();
        }
    }
}

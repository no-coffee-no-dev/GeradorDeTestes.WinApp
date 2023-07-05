using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDeTestes.Dominio.ModuloQuestao;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestao
{
    public class RepositorioQuestaoEmSql : RepositorioBaseEmSql<Questao, MapeadorQuestao>
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
                                         @MATERIA_ID
                                       );
                              SELECT SCOPE_IDENTITY();";

        public override string SqlBuscarTodos => @"SELECT 
                                                   [ID]
                                                  ,[TITULO]
                                                  ,[OPCAOA]
                                                  ,[OPCAOB]
                                                  ,[OPCAOC]
                                                  ,[OPCAOD]
                                                  ,[MATERIA_ID]
                                              FROM 
                                                [DBO].[TBQUESTAO];";

        public override string SqlDeletar => @"DELETE FROM [dbo].[TBQuestao]
                                                 WHERE [ID] = @ID;";

        public override string SqlBuscaId => @"SELECT 
                                                   [ID]
                                                  ,[TITULO]
                                                  ,[OPCAOA]
                                                  ,[OPCAOB]
                                                  ,[OPCAOC]
                                                  ,[OPCAOD]
                                                  ,[MATERIA_ID]
                                              FROM 
                                                [DBO].[TBQUESTAO]
                                              WHERE [ID] = @ID;";

        public override string SqlEditar => @"UPDATE [DBO].[TBQUESTAO]
                                       SET 
                                           [TITULO] = @TITULO
                                          ,[OPCAOA] = @OPCAOA
                                          ,[OPCAOB] = @OPCAOB
                                          ,[OPCAOC] = @OPCAOC
                                          ,[OPCAOD] = @OPCAOD
                                          ,[MATERIA_ID] = @MATERIA_ID
                                     WHERE 
                                           [ID] = @ID;";
    }
}

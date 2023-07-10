using GeradorDeTestes.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloTeste
{
    public class RepositorioTesteEmSql : RepositorioBaseEmSql<Teste, MapeadorTeste>, IRepositorioTeste
    {
        public override string SqlInserir => @"INSERT INTO [DBO].[TBTESTE]
                                       ([TITULO]
                                       ,[QUANTQUESTOES]
                                       ,[DISCIPLINA_ID]
                                       ,[MATERIA_ID])
                                 VALUES
                                       (
                                        @TITULO
                                        @QUANTQUESTOES
                                        @DISCIPLINA_ID
                                        @MATERIA_ID
		                               );";

        public override string SqlBuscarTodos => @"SELECT 
                                                   [ID]
                                                  ,[TITULO]
                                                  ,[QUANTQUESTOES]
                                                  ,[DISCIPLINA_ID]
                                                  ,[MATERIA_ID]
                                              FROM [DBO].[TBTESTE]";

        public override string SqlDeletar => @"DELETE FROM [DBO].[TBTESTE]
                                                         WHERE 
                                                        [ID] = @ID";

        public override string SqlBuscaId => @"SELECT 
                                                   [ID]
                                                  ,[TITULO]
                                                  ,[QUANTQUESTOES]
                                                  ,[DISCIPLINA_ID]
                                                  ,[MATERIA_ID]
                                              FROM [DBO].[TBTESTE]
                                                     WHERE 
                                                  [ID] = @ID";

        public override string SqlEditar => @"UPDATE [DBO].[TBTESTE]
                                   SET [TITULO] = 
                                      ,[QUANTQUESTOES] = 
                                      ,[DISCIPLINA_ID] =
                                      ,[MATERIA_ID] = 
                                 WHERE
                                    [ID] = @ID;";
    }
}

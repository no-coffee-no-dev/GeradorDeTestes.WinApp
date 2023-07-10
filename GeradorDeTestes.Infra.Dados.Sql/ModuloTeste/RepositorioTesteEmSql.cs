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
                                       ,[DATADEGERACAO]
                                       ,[QUANTQUESTOES]
                                       ,[DISCIPLINA_ID]
                                       ,[MATERIA_ID])
                                 VALUES
                                       (
                                        @TITULO,
                                        @DATADEGERACAO,
                                        @QUANTQUESTOES,
                                        @DISCIPLINA_ID,
                                        @MATERIA_ID
		                               );";

        public override string SqlBuscarTodos => @"SELECT 
                                                   TBT.[ID]
                                                  ,TBT.[TITULO]
                                                  ,TBT.[DATADEGERACAO]
                                                  ,TBT.[QUANTQUESTOES]


                                                  ,TBD.ID AS ID_DISCIPLINA
												  ,TBD.NOME AS DISCIPLINA

                                                  ,TBM.ID AS ID_MATERIA
												  ,TBM.NOME AS MATERIA

                                              FROM [DBO].[TBTESTE] TBT 
											  INNER JOIN TBDISCIPLINA TBD ON 
											  TBT.DISCIPLINA_ID = TBD.ID
											  INNER JOIN TBMATERIA TBM ON
											  TBT.MATERIA_ID = TBM.ID;";

        public override string SqlDeletar => @"DELETE FROM [DBO].[TBTESTE]
                                                         WHERE 
                                                        [ID] = @ID";

        public override string SqlBuscaId => @"SELECT 
                                                   TBT.[ID]
                                                  ,TBT.[TITULO]
                                                  ,TBT.[DATADEGERACAO]
                                                  ,TBT.[QUANTQUESTOES]


                                                  ,TBD.ID AS ID_DISCIPLINA
												  ,TBD.NOME AS DISCIPLINA

                                                  ,TBM.ID AS ID_MATERIA
												  ,TBM.NOME AS MATERIA

                                              FROM [DBO].[TBTESTE] TBT 
											  INNER JOIN TBDISCIPLINA TBD ON 
											  TBT.DISCIPLINA_ID = TBD.ID
											  INNER JOIN TBMATERIA TBM ON
											  TBT.MATERIA_ID = TBM.ID;
                                                     WHERE 
                                                  [ID] = @ID";

        public override string SqlEditar => @"UPDATE [DBO].[TBTESTE]
                                   SET [TITULO] = @TITULO
                                      ,[QUANTQUESTOES] = @QUANTQUESTOES
                                      ,[DATADEGERACAO] = @DATADEGERACAO
                                      ,[DISCIPLINA_ID] = @DISCIPLINA_ID
                                      ,[MATERIA_ID] = @MATERIA_ID
                                 WHERE
                                    [ID] = @ID;";
        public string SqlBuscarPerguntas => @"SELECT 
		                                TBQ.TITULO
	                                   ,TBT.TITULO

                                FROM TBTESTE_TBQUESTAO TBT_TBQ 
                                INNER JOIN TBQUESTAO TBQ ON TBT_TBQ.QUESTAO_ID = TBQ.ID 
                                INNER JOIN TBTESTE TBT ON TBT_TBQ.TESTE_ID = TBT.ID
                                        WHERE TBT.ID = @ID;";
    }
}

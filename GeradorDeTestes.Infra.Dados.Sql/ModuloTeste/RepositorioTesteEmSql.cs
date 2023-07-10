using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloTeste
{
    public class RepositorioTesteEmSql : RepositorioBaseEmSql<Teste, MapeadorTeste>, IRepositorioTeste
    {
        public override string SqlInserir => @"INSERT INTO [DBO].[TBTESTES]
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
		                               );  
                                    SELECT SCOPE_IDENTITY();";

        public override string SqlBuscarTodos => @"SELECT 
                                                   TBT.[ID]
                                                  ,TBT.[TITULO]
                                                  ,TBT.[DATADEGERACAO]
                                                  ,TBT.[QUANTQUESTOES]


                                                  ,TBD.ID
												  ,TBD.NOME 

                                                  ,TBM.ID 
												  ,TBM.NOME as NOME_MATERIA
												  ,TBM.SERIE

                                              FROM [DBO].[TBTESTES] TBT 
											  INNER JOIN TBDISCIPLINA TBD ON 
											  TBT.DISCIPLINA_ID = TBD.ID
											  INNER JOIN TBMATERIA TBM ON
											  TBT.MATERIA_ID = TBM.ID;";

        public override string SqlDeletar => @"DELETE FROM [DBO].[TBTESTES]
                                                         WHERE 
                                                        [ID] = @ID";

        public override string SqlBuscaId => @"SELECT 
                                                   TBT.[ID]
                                                  ,TBT.[TITULO]
                                                  ,TBT.[DATADEGERACAO]
                                                  ,TBT.[QUANTQUESTOES]


                                                  ,TBD.ID
												  ,TBD.NOME 

                                                  ,TBM.ID
												  ,TBM.NOME AS as NOME_MATERIA

                                              FROM [DBO].[TBTESTES] TBT 
											  INNER JOIN TBDISCIPLINA TBD ON 
											  TBT.DISCIPLINA_ID = TBD.ID
											  INNER JOIN TBMATERIA TBM ON
											  TBT.MATERIA_ID = TBM.ID;
                                                     WHERE 
                                                  [ID] = @ID";

        public override string SqlEditar => @"UPDATE [DBO].[TBTESTES]
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
                                INNER JOIN TBTESTES TBT ON TBT_TBQ.TESTE_ID = TBT.ID
                                        WHERE TBT.ID = @ID;";

        public  string SqlInserirQuestoes => @"INSERT INTO [DBO].[TBTESTE_TBQUESTAO]
                                                           (
                                                            [QUESTAO_ID]
                                                           ,[TESTE_ID])
                                                     VALUES
                                                           (
                                                            @QUESTAO_ID
                                                            ,@TESTE_ID
                                                            );";




        public void Inserir(Teste novaEntidade, List<Questao> questoes)
        {

            SqlConnection conexao = new(ENDERECOBANCO);
            conexao.Open();

            SqlCommand comandoInserir = conexao.CreateCommand();
            comandoInserir.CommandText = SqlInserir;

            mapeador.ConfigurarParametros(comandoInserir, novaEntidade);

            object id = comandoInserir.ExecuteScalar();

            novaEntidade.id = Convert.ToInt32(id);

            conexao.Close();

            foreach (Questao questao in questoes)
            {
                AdicionarItem(novaEntidade, questao);
            }
        }

        private void AdicionarItem(Teste teste, Questao questao)
        {
            //obter a conexão com o banco e abrir ela
            SqlConnection conexaoComBanco = new SqlConnection(ENDERECOBANCO);
            conexaoComBanco.Open();

            //cria um comando e relaciona com a conexão aberta
            SqlCommand comandoInserir = conexaoComBanco.CreateCommand();
            comandoInserir.CommandText = SqlInserirQuestoes;

            //adiciona os parâmetros no comando
            comandoInserir.Parameters.AddWithValue("QUESTAO_ID", questao.id);
            comandoInserir.Parameters.AddWithValue("TESTE_ID", teste.id);

            //executa o comando
            comandoInserir.ExecuteNonQuery();

            //fecha conexão
            conexaoComBanco.Close();
        }

    }
}

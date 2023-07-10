using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using Microsoft.Data.SqlClient;

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
                                          ,[RESPOSTACORRETA] = @RESPOSTACORRETA
                                          ,[MATERIA_ID] = @MATERIA_ID
                                     WHERE 
                                           [ID] = @ID;";
        public string SqlBuscarRespostas => @"SELECT 
                                                   TBQ.[OPCAOA]
                                                  ,TBQ.[OPCAOB]
                                                  ,TBQ.[OPCAOC]
                                                  ,TBQ.[OPCAOD]
                                                  ,TBQ.[RESPOSTACORRETA]
                                              FROM 
                                                [DBO].[TBQUESTAO] TBQ 
                                              WHERE TBQ.[ID] = @ID;";
        public string SqlBuscarQuestoesDaMateria => @"SELECT 
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
                                                WHERE TBM.ID = @ID;";


        public List<string> RetornarTodasAsOpcoes(Questao questao)
        {
            SqlConnection conexao = new(ENDERECOBANCO);
            conexao.Open();

            SqlCommand comandoSelecionarTodasRespostas = conexao.CreateCommand();
            comandoSelecionarTodasRespostas.CommandText = SqlBuscarRespostas;

            comandoSelecionarTodasRespostas.Parameters.AddWithValue("ID", questao.id);

            SqlDataReader leitorEntidades = comandoSelecionarTodasRespostas.ExecuteReader();

            List<string> respostas = new();

            while (leitorEntidades.Read())
            {
                respostas = mapeador.ConverterApenasRespostas(leitorEntidades);
            }

            conexao.Close();

            return respostas;
        }

        public List<Questao> RetornarTodasAsQuestoesDaMateria(Materia materia)
        {
            SqlConnection conexao = new(ENDERECOBANCO);
            conexao.Open();

            SqlCommand comandoSelecionarTodasQueatoesDeUmaMateria = conexao.CreateCommand();
            comandoSelecionarTodasQueatoesDeUmaMateria.CommandText = SqlBuscarQuestoesDaMateria;

            comandoSelecionarTodasQueatoesDeUmaMateria.Parameters.AddWithValue("ID", materia.id);

            SqlDataReader leitorEntidades = comandoSelecionarTodasQueatoesDeUmaMateria.ExecuteReader();

            List<Questao> questoes = new();

            while (leitorEntidades.Read())
            {
                Questao questao = mapeador.ConverterParaEntidade(leitorEntidades);
                questoes.Add(questao);
            }
            conexao.Close();
            return questoes;
        }
    }
}

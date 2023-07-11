using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloQuestao;
using iText.StyledXmlParser.Jsoup.Select;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloDisciplina
{
    public class RepositorioDisciplinaEmSql : RepositorioBaseEmSql<Disciplina, MapeadorDisciplina>, IRepositorioDisciplina
    {
        public override string SqlInserir => @"INSERT INTO [DBO].[TBDISCIPLINA]
                                       ([NOME]) VALUES (@NOME);
                              SELECT SCOPE_IDENTITY();";

        public override string SqlBuscarTodos => @"SELECT [ID]
                                                      ,[NOME]
                                                  FROM [DBO].[TBDISCIPLINA]";

        public override string SqlDeletar => @"DELETE FROM [dbo].[TBDISCIPLINA]
                                                 WHERE [ID] = @ID;";

        public override string SqlBuscaId => @"SELECT [ID]
                                                      ,[NOME]
                                                  FROM [DBO].[TBDISCIPLINA] WHERE [TBDISCIPLINA].[ID] = @ID;";

        public override string SqlEditar => @"UPDATE [DBO].[TBDISCIPLINA]
                                                SET [NOME] = @NOME WHERE [ID] = @ID;";

        public string SqlBuscarQuestoesRelacionadas => @"SELECT Q.titulo
                                              FROM[dbo].[TBMateria] as M INNER JOIN TBQuestao Q on Q.materia_id = M.id WHERE M.id_disciplina = @ID;";

        public List<string> RetornarQuestoesRelacionadas(Disciplina disciplina)
        {
            SqlConnection conexao = new(ENDERECOBANCO);
            conexao.Open();

            SqlCommand comandoSelecionarQuestoesRelacionadas = conexao.CreateCommand();
            comandoSelecionarQuestoesRelacionadas.Parameters.AddWithValue("ID", disciplina.id);

            comandoSelecionarQuestoesRelacionadas.CommandText = SqlBuscarQuestoesRelacionadas;

            SqlDataReader leitorEntidades = comandoSelecionarQuestoesRelacionadas.ExecuteReader();

            List<string> entidades = new();

            while (leitorEntidades.Read())
            {
                string titulo = Convert.ToString(leitorEntidades["TITULO"]);
                entidades.Add(titulo);
            }

            conexao.Close();

            return entidades;
        }
    }
}
//SELECT Q.titulo
//  FROM[dbo].[TBMateria] as M INNER JOIN TBQuestao Q on Q.materia_id = M.id WHERE M.id_disciplina = 5;
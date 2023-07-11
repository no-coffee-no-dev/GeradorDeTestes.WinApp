using GeradorDeTestes.Dominio.ModuloDisciplina;
using Microsoft.Data.SqlClient;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloDisciplina
{
    public class MapeadorDisciplina : MapeadorBase<Disciplina>
    {
        public override void ConfigurarParametros(SqlCommand comando, Disciplina novaEntidade)
        {
            comando.Parameters.AddWithValue("ID", novaEntidade.id);
            comando.Parameters.AddWithValue("NOME", novaEntidade.nome);
        }

        public override Disciplina ConverterParaEntidade(SqlDataReader leitorEntidades)
        {
            int idDisciplina = Convert.ToInt32(leitorEntidades["ID"]);
            string nome = Convert.ToString(leitorEntidades["NOME"]);

            Disciplina disciplina = new(nome);
            disciplina.id = idDisciplina;
            return disciplina;

        }
    }
}
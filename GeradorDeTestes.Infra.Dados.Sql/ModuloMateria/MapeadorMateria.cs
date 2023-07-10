using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using Microsoft.Data.SqlClient;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloMateria
{
    public class MapeadorMateria : MapeadorBase<Materia>
    {
        public override void ConfigurarParametros(SqlCommand comandoEditar, Materia novaEntidade)
        {
            comandoEditar.Parameters.AddWithValue("ID", novaEntidade.id);
            comandoEditar.Parameters.AddWithValue("NOME", novaEntidade.nome);
            comandoEditar.Parameters.AddWithValue("SERIE", novaEntidade.serie);
            comandoEditar.Parameters.AddWithValue("ID_DISCILINA", novaEntidade.disiplina.id);
        }

        public override Materia ConverterParaEntidade(SqlDataReader leitorEntidades)
        {
            int idMateria = Convert.ToInt32(leitorEntidades["ID"]);
            string nome = Convert.ToString(leitorEntidades["NOME"]);
            string serie = Convert.ToString(leitorEntidades["SERIE"]);
            Materia materia = new(nome, new Disciplina(""), serie);
            materia.id = idMateria;
            return materia;

        }
    }
}

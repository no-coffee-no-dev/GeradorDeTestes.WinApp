using GeradorDeTestes.Dominio.Compartilhado;

namespace RepositorioBaseEmSql
{
    public abstract class RepositorioBaseEmSql<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {

        public const string ENDERECOBANCO = "Data Source=(LocalDB)\\MSSqlLocalDB;" +
              "Initial Catalog=Festas_InfantisDB;" +
              "Integrated Security=True;" +
              "Pooling=False";

        public abstract string SqlInserir { get; }
        public abstract string SqlBuscarTodos { get; }
        public abstract string SqlDeletar { get; }
        public abstract string SqlBuscaId { get; }
        public abstract string SqlEditar { get; }


        public void Atualizar(int id, TEntidade entidade)
        {
            SqlConnection conexao = new(ENDERECOBANCO);
            conexao.Open();

            SqlCommand comandoEditar = conexao.CreateCommand();
            comandoEditar.CommandText = SqlEditar;

            ConfigurarParametros(comandoEditar, entidade);

            comandoEditar.ExecuteNonQuery();

            conexao.Close();
        }

        public TEntidade Busca(int id)
        {
            SqlConnection conexao = new(ENDERECOBANCO);

            conexao.Open();

            SqlCommand comandoSelecao = conexao.CreateCommand();
            comandoSelecao.CommandText = SqlBuscaId;

            comandoSelecao.Parameters.AddWithValue("ID", id);

            SqlDataReader leitorEntidades = comandoSelecao.ExecuteReader();

            TEntidade entidade = null;

            if (leitorEntidades.Read())
                entidade = ConverterParaEntidade(leitorEntidades);

            conexao.Close();

            return entidade;
        }

        public void Deletar(int id)
        {
            SqlConnection conexao = new(ENDERECOBANCO);
            conexao.Open();

            SqlCommand comandoDeletar = conexao.CreateCommand();
            comandoDeletar.CommandText = SqlDeletar;

            comandoDeletar.Parameters.AddWithValue("ID", id);

            comandoDeletar.ExecuteNonQuery();

            conexao.Close();
        }

        public void Inserir(TEntidade novaEntidade)
        {
            SqlConnection conexao = new(ENDERECOBANCO);
            conexao.Open();

            SqlCommand comandoInserir = conexao.CreateCommand();
            comandoInserir.CommandText = SqlInserir;

            ConfigurarParametros(comandoInserir, novaEntidade);

            object id = comandoInserir.ExecuteScalar();

            novaEntidade.id = Convert.ToInt32(id);

            conexao.Close();
        }

        public List<TEntidade> RetornarTodos()
        {
            SqlConnection conexao = new(ENDERECOBANCO);
            conexao.Open();

            SqlCommand comandoSelecionarTodos = conexao.CreateCommand();
            comandoSelecionarTodos.CommandText = SqlBuscarTodos;

            SqlDataReader leitorEntidades = comandoSelecionarTodos.ExecuteReader();

            List<TEntidade> entidades = new();

            while (leitorEntidades.Read())
            {
                TEntidade entidade = ConverterParaEntidade(leitorEntidades);

                entidades.Add(entidade);

            }

            conexao.Close();

            return entidades;
        }
    }
}
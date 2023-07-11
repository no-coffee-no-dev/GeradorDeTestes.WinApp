using GeradorDeTestes.Dominio.Compartilhado;
using Microsoft.Data.SqlClient;

namespace GeradorDeTestes.Infra.Dados.Sql.Compartilhado
{
    public abstract class RepositorioBaseEmSql<TEntidade, TMapeador>
        where TEntidade : EntidadeBase<TEntidade>
        where TMapeador : MapeadorBase<TEntidade>, new()
    {

        public const string ENDERECOBANCO = "Data Source=(LocalDB)\\MSSqlLocalDB;" +
              "Initial Catalog = GeradorDeTestes;" +
              "Integrated Security=True;" +
              "Pooling=False";


        public abstract string SqlInserir { get; }
        public abstract string SqlBuscarTodos { get; }
        public abstract string SqlDeletar { get; }
        public abstract string SqlBuscaId { get; }
        public abstract string SqlEditar { get; }

        protected RepositorioBaseEmSql()
        {
            mapeador = new TMapeador();
        }

        protected TMapeador mapeador;


        public void Atualizar(int id, TEntidade entidade)
        {
            SqlConnection conexao = new(ENDERECOBANCO);
            conexao.Open();

            SqlCommand comandoEditar = conexao.CreateCommand();
            comandoEditar.CommandText = SqlEditar;

            mapeador.ConfigurarParametros(comandoEditar, entidade);

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
                entidade = mapeador.ConverterParaEntidade(leitorEntidades);

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

        public virtual void Inserir(TEntidade novaEntidade)
        {
            SqlConnection conexao = new(ENDERECOBANCO);
            conexao.Open();

            SqlCommand comandoInserir = conexao.CreateCommand();
            comandoInserir.CommandText = SqlInserir;

            mapeador.ConfigurarParametros(comandoInserir, novaEntidade);

            object id = comandoInserir.ExecuteScalar();

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
                TEntidade entidade = mapeador.ConverterParaEntidade(leitorEntidades);

                entidades.Add(entidade);

            }

            conexao.Close();

            return entidades;
        }


    }
}

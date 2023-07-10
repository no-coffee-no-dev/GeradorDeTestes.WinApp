using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Infra.Dados.Sql.ModuloMateria;
using Microsoft.Data.SqlClient;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestao
{
    public class MapeadorQuestao : MapeadorBase<Questao>
    {
        public override void ConfigurarParametros(SqlCommand comando, Questao novaEntidade)
        {
            comando.Parameters.AddWithValue("ID", novaEntidade.id);
            comando.Parameters.AddWithValue("TITULO", novaEntidade.titulo);
            comando.Parameters.AddWithValue("OPCAOA", novaEntidade.opcoaoA);
            comando.Parameters.AddWithValue("OPCAOB", novaEntidade.opcoaoB);
            comando.Parameters.AddWithValue("OPCAOC", novaEntidade.opcoaoC);
            comando.Parameters.AddWithValue("OPCAOD", novaEntidade.opcoaoD);
            comando.Parameters.AddWithValue("RESPOSTACORRETA", novaEntidade.respostaCorreta);
            comando.Parameters.AddWithValue("MATERIA_ID", novaEntidade.materia.id);
        }

        public override Questao ConverterParaEntidade(SqlDataReader leitorEntidades)
        {
            int idQuestao = Convert.ToInt32(leitorEntidades["ID"]);
            string titulo = Convert.ToString(leitorEntidades["TITULO"]);
            string opcaoA = Convert.ToString(leitorEntidades["OPCAOA"]);
            string opcaoB = Convert.ToString(leitorEntidades["OPCAOB"]);
            string opcaoC = Convert.ToString(leitorEntidades["OPCAOC"]);
            string opcaoD = Convert.ToString(leitorEntidades["OPCAOD"]);
            string respostaCorreta = Convert.ToString(leitorEntidades["RESPOSTACORRETA"]);

            Materia materia = new MapeadorMateria().ConverterParaEntidade(leitorEntidades);

            Questao questao = new Questao(titulo,opcaoA,opcaoB,opcaoC,opcaoD,respostaCorreta,materia);
            questao.id = idQuestao;

            return questao;
        }
        public  Questao ConverterParaQuestaoDoTeste(SqlDataReader leitorEntidades)
        {
            int idQuestao = Convert.ToInt32(leitorEntidades["ID"]);
            string titulo = Convert.ToString(leitorEntidades["TITULO"]);

            Materia materia = new MapeadorMateria().ConverterParaEntidade(leitorEntidades);
            Questao questao = new Questao(titulo);
            questao.id = idQuestao;

            return questao;
        }
        public List<string> ConverterApenasRespostas(SqlDataReader leitorEntidades)
        {
            List<string> respostas = new();

            string opcaoA = Convert.ToString(leitorEntidades["OPCAOA"]);
            string opcaoB = Convert.ToString(leitorEntidades["OPCAOB"]);
            string opcaoC = Convert.ToString(leitorEntidades["OPCAOC"]);
            string opcaoD = Convert.ToString(leitorEntidades["OPCAOD"]);


            respostas.Add(opcaoA);
            respostas.Add(opcaoB);
            respostas.Add(opcaoC);
            respostas.Add(opcaoD);

            return respostas;
        }
    }
}

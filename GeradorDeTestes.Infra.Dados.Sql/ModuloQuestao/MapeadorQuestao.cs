using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using GeradorDeTestes.Dominio.ModuloQuestao;
using Microsoft.Data.SqlClient;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestao
{
    public class MapeadorQuestao : MapeadorBase<Questao>
    {
        public override void ConfigurarParametros(SqlCommand comandoEditar, Questao novaEntidade)
        {
            comandoEditar.Parameters.AddWithValue("ID", novaEntidade.id);
            comandoEditar.Parameters.AddWithValue("TITULO", novaEntidade.titulo);
            comandoEditar.Parameters.AddWithValue("OPCAOA", novaEntidade.opcoaoA);
            comandoEditar.Parameters.AddWithValue("OPCAOB", novaEntidade.opcoaoB);
            comandoEditar.Parameters.AddWithValue("OPCAOC", novaEntidade.opcoaoC);
            comandoEditar.Parameters.AddWithValue("OPCAOD", novaEntidade.opcoaoD);
            comandoEditar.Parameters.AddWithValue("RESPOSTACORRETA", novaEntidade.respostaCorreta);
            comandoEditar.Parameters.AddWithValue("MATERIA_ID", novaEntidade.materia.id);
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
            int materiaId = Convert.ToInt32(leitorEntidades["MATERIA_ID"]);

            Materia materia = new();
            materia.id = materiaId;

            Questao questao = new Questao(titulo,opcaoA,opcaoB,opcaoC,opcaoD,respostaCorreta,materia);
            questao.id = idQuestao;

            return questao;
        }
    }
}

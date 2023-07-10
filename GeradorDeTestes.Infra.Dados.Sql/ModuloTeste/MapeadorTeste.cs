using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.Dominio.ModuloTeste;
using GeradorDeTestes.Infra.Dados.Sql.ModuloDisciplina;
using GeradorDeTestes.Infra.Dados.Sql.ModuloMateria;
using GeradorDeTestes.Infra.Dados.Sql.ModuloQuestao;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloTeste
{
    public class MapeadorTeste : MapeadorBase<Teste>
    {
        public override void ConfigurarParametros(SqlCommand comando, Teste novaEntidade)
        {
            comando.Parameters.AddWithValue("ID", novaEntidade.id);
            comando.Parameters.AddWithValue("TITULO", novaEntidade.titulo);
            comando.Parameters.AddWithValue("DATADEGERACAO", novaEntidade.dataDeGeracao);
            comando.Parameters.AddWithValue("QUANTQUESTOES", novaEntidade.quantQuestoes);
            comando.Parameters.AddWithValue("DISCIPLINA_ID", novaEntidade.disciplina.id);
            comando.Parameters.AddWithValue("MATERIA_ID", novaEntidade.materia.id);
        }

        public override Teste ConverterParaEntidade(SqlDataReader leitorEntidades)
        {
            int idTeste = Convert.ToInt32(leitorEntidades["ID"]);
            string titulo = Convert.ToString(leitorEntidades["TITULO"]);
            DateTime dataDeGeracao = Convert.ToDateTime(leitorEntidades["DATADEGERACAO"]);
            int quanquestoes = Convert.ToInt32(leitorEntidades["QUANTQUESTOES"]);
       

            Materia materia = new MapeadorMateria().ConverterParaEntidade(leitorEntidades);

            Disciplina disciplina = new MapeadorDisciplina().ConverterParaEntidade(leitorEntidades);

            List<Questao> questoes = ObterQuestoes(leitorEntidades); 

            Teste teste = new Teste(titulo, dataDeGeracao,disciplina, materia,quanquestoes,questoes);
            teste.id = idTeste;

            return teste;
        }

        private List<Questao> ObterQuestoes(SqlDataReader leitorEntidades)
        {
            List<Questao> questoes = new();
            Questao questao = new MapeadorQuestao().ConverterParaQuestaoDoTeste(leitorEntidades);
            questoes.Add(questao);
                   
            
            return questoes;
        }
    }
}

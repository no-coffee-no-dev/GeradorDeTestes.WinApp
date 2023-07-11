using GeradorDeTestes.Dominio.Compartilhado;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloTeste
{
    public class Teste : EntidadeBase<Teste>
    {
        public string titulo;
        public DateTime dataDeGeracao;
        public Disciplina disciplina;
        public Materia materia;
        public int quantQuestoes;
        public List<Questao> listaQuestoes;

        public Teste(string titulo, DateTime dataDeGeracao, Disciplina disciplina, Materia materia, int quantQuestoes, List<Questao> listaQuestoes)
        {
            this.titulo = titulo;
            this.dataDeGeracao = dataDeGeracao;
            this.disciplina = disciplina;
            this.materia = materia;
            this.quantQuestoes = quantQuestoes;
            this.listaQuestoes = listaQuestoes;
        }

        public override void Atualizar(Teste entidadeAtualizada)
        {
            titulo = entidadeAtualizada.titulo;
            dataDeGeracao = entidadeAtualizada.dataDeGeracao;
            disciplina = entidadeAtualizada.disciplina;
            materia = entidadeAtualizada.materia;
            quantQuestoes = entidadeAtualizada.quantQuestoes;
            listaQuestoes = entidadeAtualizada.listaQuestoes;

        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("O campo 'titulo' é obrigatório");
            if (listaQuestoes.Count < 1)
                erros.Add("O Teste tem q ter no mínimo 1 questão");

            return erros.ToArray();
        }
    }
}

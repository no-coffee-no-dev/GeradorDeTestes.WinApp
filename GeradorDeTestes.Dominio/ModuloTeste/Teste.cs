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


        public override string ToString()
        {
            return $"{titulo}";
        }

    }
}

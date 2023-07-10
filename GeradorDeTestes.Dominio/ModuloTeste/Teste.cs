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
        public Disciplina disciplina;
        public Materia materia;
        public int quantQuestoes;
        public List<Questao> listaQuestoes;
        public override void Atualizar(Teste entidadeAtualizada)
        {
            titulo = entidadeAtualizada.titulo;
            disciplina = entidadeAtualizada.disciplina;
            materia = entidadeAtualizada.materia;
            quantQuestoes = entidadeAtualizada.quantQuestoes;
            listaQuestoes = entidadeAtualizada.listaQuestoes;

        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}

using GeradorDeTestes.Dominio.ModuloQuestao;
using System;

namespace GeradorDeTestes.Dominio.ModuloDisciplina
{
    public interface IRepositorioDisciplina : IRepositorio<Disciplina>
    {
        List<string> RetornarQuestoesRelacionadas(Disciplina disciplina);
        public List<Disciplina> RetornarDisciplinasPorNome(Disciplina disciplina);
    }
}
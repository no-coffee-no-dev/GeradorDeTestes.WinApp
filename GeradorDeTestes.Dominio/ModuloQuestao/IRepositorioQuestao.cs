using GeradorDeTestes.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloQuestao
{
    public interface IRepositorioQuestao : IRepositorio<Questao>
    {
        List<string> RetornarTodasAsOpcoes(Questao questao);
        List<Questao> RetornarTodasAsQuestoesDaMateria(Materia materia);
        List<Questao> RetornarQuestoesPorTitulo(Questao questao);
    }
}

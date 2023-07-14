using GeradorDeTestes.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloTeste
{
    public interface IRepositorioTeste : IRepositorio<Teste>
    {
        public void Inserir(Teste novaEntidade, List<Questao> questoes);
        public List<Questao> RetornarTodasAsRespostas(int id);
        public List<Teste> RetornarTestesPorTitulo(Teste teste);
    }
}

using GeradorDeTestes.Aplicacao.Compartilhado;
using GeradorDeTestes.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Aplicacao.ModuloQuestao
{
    public class ServicoQuestao : ServicoBase<Questao>
    {
        IRepositorioQuestao repositorioQuestao;
        ValidadorQuestao validadorQuestao;
        public ServicoQuestao(IRepositorioQuestao repositorioQuestao, ValidadorQuestao validadorQuestao) : base(repositorioQuestao,validadorQuestao)
        {
            this.repositorioQuestao = repositorioQuestao;
            this.validadorQuestao = validadorQuestao;
        }

        protected override bool EntidadeDuplicada(Questao questao)
        {
            List<Questao> questoes = repositorioQuestao.RetornarQuestoesPorTitulo(questao);

            if (questoes.Exists(q => q.titulo == questao.titulo && q.id != questao.id))
                return true;

            return false;
        }
    }
}

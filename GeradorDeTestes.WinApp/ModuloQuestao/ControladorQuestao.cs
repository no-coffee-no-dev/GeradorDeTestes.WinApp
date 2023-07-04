using GeradorDeTestes.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.ModuloQuestao
{
    public class ControladorQuestao : ControladorBase
    {
        private IRepositorioQuestao repositorioQuestao;
        private TabelaQuestoesControl tabelaCategoria;

        public ControladorQuestao(IRepositorioQuestao repositorioQuestao)
        {
            this.repositorioQuestao = repositorioQuestao;
        }

        public override string ToolTipInserir => "Inserir nova Questão";

        public override string ToolTipEditar => "Editar Questão existente";

        public override string ToolTipExcluir => "Excluir uma Questão existente";

        public override bool BotaoInserirAtivado => true;

        public override bool BotaoDeletarAtivado => true;

        public override bool BotaoEditarAtivado => true;

        public override bool BotaoVisualizarItensAtivado => false;

        public override bool BotaoConfigurarDescontoAtivado => false;

        public override void CarregarEntidades()
        {
            throw new NotImplementedException();
        }

        public override void Deletar()
        {
            throw new NotImplementedException();
        }

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {

            TelaQuestaoForm telaQuestao = new TelaQuestaoForm();

            DialogResult opcaoEscolhida = telaCategoria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Categoria categoria = telaCategoria.Categoria;

                repositorioCategoria.Inserir(categoria);

                CarregarDespesas();
            }
        }

        public UserControl ObterListagem()
        {
            if (tabelaCategoria == null)
                tabelaCategoria = new TabelaQuestoesControl();

            CarregarEntidades();

            return tabelaCategoria;
        }

        public string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }

        private Questao ObterQuestaoSelecionada()
        {
            int id = tabelaCategoria.ObterIdSelecionado();

            return repositorioQuestao.Busca(id);
        }
    }
}

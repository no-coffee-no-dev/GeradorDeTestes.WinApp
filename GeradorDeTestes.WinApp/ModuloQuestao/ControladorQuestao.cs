using GeradorDeTestes.Dominio.ModuloMateria;
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
        private IRepositorioMateria repositorioMateria;
        private TabelaQuestoesControl tabelaCategoria;

        public ControladorQuestao(IRepositorioQuestao repositorioQuestao, IRepositorioMateria repositorioMateria)
        {
            this.repositorioQuestao = repositorioQuestao;
            this.repositorioMateria = repositorioMateria;
        }

        public override string ToolTipInserir => "Inserir nova Questão";

        public override string ToolTipEditar => "Editar Questão existente";

        public override string ToolTipExcluir => "Excluir uma Questão existente";
        public override string ToolTipVisualizarItens=> "Visualizar Respostas";

        public override bool BotaoInserirAtivado => true;

        public override bool BotaoDeletarAtivado => true;

        public override bool BotaoEditarAtivado => true;

        public override bool BotaoVisualizarItensAtivado => false;

        public override bool BotaoConfigurarDescontoAtivado => false;

        public override void CarregarEntidades()
        {
            List<Questao> questoes = repositorioQuestao.RetornarTodos();
            tabelaCategoria.AtualizarRegistros(questoes);
        }

        public override void Deletar()
        {
            Questao questao = ObterQuestaoSelecionada();

            if (questao == null)
            {
                MessageBox.Show($"Selecione uma Questã primeiro!",
                    "Exclusão de Questões",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a Questao {questao.titulo}?", "Exclusão de Questões",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioQuestao.Deletar(questao.id);

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            Questao questao = ObterQuestaoSelecionada();

            if (questao == null)
            {
                MessageBox.Show($"Selecione uma Questão primeiro!",
                    "Edição de Questões",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaQuestaoForm telaQuestao = new TelaQuestaoForm(repositorioMateria);
            telaQuestao.Questao = questao;

            DialogResult opcaoEscolhida = telaQuestao.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioQuestao.Atualizar(telaQuestao.Questao.id, telaQuestao.Questao);

                CarregarEntidades();
            }
        }

        public override void Inserir()
        {

            TelaQuestaoForm telaQuestao = new TelaQuestaoForm(repositorioMateria);

            DialogResult opcaoEscolhida = telaQuestao.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Questao questao = telaQuestao.Questao;

                repositorioQuestao.Inserir(questao);

                CarregarEntidades();
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCategoria == null)
                tabelaCategoria = new TabelaQuestoesControl();

            CarregarEntidades();

            return tabelaCategoria;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Questões";
        }

        public override void VisualizarItems()
        {

            Questao questao = ObterQuestaoSelecionada();
            TelaVisualizarItemsForm telaVisualizarItems = new TelaVisualizarItemsForm(repositorioQuestao, questao);
            telaVisualizarItems.ShowDialog();
        }

        private Questao ObterQuestaoSelecionada()
        {
            int id = tabelaCategoria.ObterIdSelecionado();

            return repositorioQuestao.Busca(id);
        }
    }
}

using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using GeradorDeTestes.WinApp.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.ModuloMateria
{
    internal class ControladorMateria : ControladorBase
    {
        private IRepositorioMateria repositorioMateria;
        private IRepositorioDisciplina repositorioDisciplina;
        private TabelaMateriaControl tabelaMateria;

        public ControladorMateria(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override string ToolTipInserir => "Inserir nova materia";

        public override string ToolTipEditar => "Editar materia";

        public override string ToolTipExcluir => "Excluir materia";

        public override bool BotaoInserirAtivado => true;

        public override bool BotaoDeletarAtivado => true;

        public override bool BotaoEditarAtivado => true;

        public override bool BotaoVisualizarItensAtivado => false;

        public override bool BotaoGerarPDFAtivado => false;

        public override bool BotaoDuplicarTesteAtivado => false;

        public override void CarregarEntidades()
        {
            List<Materia> materias = repositorioMateria.RetornarTodos();
            tabelaMateria.AtualizarRegistros(materias);
        }

        public override void Deletar()
        {
            Materia materias = ObterMateriaSelecionada();

            if (materias == null)
            {
                MessageBox.Show($"Selecione uma materia primeiro!",
                    "Exclusão de Materia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a Materia {materias.nome}?", "Exclusão de Materia",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioMateria.Deletar(materias.id);

                CarregarEntidades();
            }
        }

        public override void Editar()
        {
            Materia materia = ObterMateriaSelecionada();

            if (materia == null)
            {
                MessageBox.Show($"Selecione uma materia primeiro!",
                    "Edição de Materias",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaMateriaForm telaMateria = new TelaMateriaForm(repositorioDisciplina);
            telaMateria.Materia = materia;

            DialogResult opcaoEscolhida = telaMateria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioMateria.Atualizar(telaMateria.Materia.id, telaMateria.Materia);

                CarregarEntidades();
            }
        }

        private Materia ObterMateriaSelecionada()
        {
            int id = tabelaMateria.ObterIdSelecionado();
            return repositorioMateria.Busca(id);
        }

        public override void Inserir()
        {
            TelaMateriaForm telaMateria = new TelaMateriaForm(repositorioDisciplina);

            DialogResult opcaoEscolhida = telaMateria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Materia materia = telaMateria.Materia;

                repositorioMateria.Inserir(materia);

                CarregarEntidades();
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaMateria == null)
                tabelaMateria = new TabelaMateriaControl();

            CarregarEntidades();

            return tabelaMateria;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Materia";
        }
    }
}

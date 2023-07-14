using FluentResults;
using GeradorDeTestes.Aplicacao.ModuloDisciplina;
using GeradorDeTestes.Aplicacao.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloMateria;


namespace GeradorDeTestes.WinApp.ModuloMateria
{
    internal class ControladorMateria : ControladorBase
    {
        private IRepositorioMateria repositorioMateria;
        private IRepositorioDisciplina repositorioDisciplina;
        private TabelaMateriaControl tabelaMateria;

        private ServicoMateria servicoMateria;

        public ControladorMateria(IRepositorioMateria repositorioMateria, IRepositorioDisciplina repositorioDisciplina, ServicoMateria servicoMateria)
        {
            this.repositorioMateria = repositorioMateria;
            this.repositorioDisciplina = repositorioDisciplina;
            this.servicoMateria = servicoMateria;
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
            Materia materia = ObterMateriaSelecionada();

            if (materia == null)
            {
                MessageBox.Show($"Selecione uma materia primeiro!",
                    "Exclusão de Materia",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a Materia {materia.nome}?", "Exclusão de Materia",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                Result resultado = servicoMateria.Deletar(materia);

                if (resultado.IsFailed)
                {
                    MessageBox.Show(resultado.Errors[0].Message, "Exclusão de Materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

            telaMateria.onInserirEntidade += servicoMateria.Atualizar;

            DialogResult opcaoEscolhida = telaMateria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
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

            telaMateria.onInserirEntidade += servicoMateria.Inserir;

            DialogResult opcaoEscolhida = telaMateria.ShowDialog();

            Materia materia = telaMateria.Materia;

            if (opcaoEscolhida == DialogResult.OK)
            {
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

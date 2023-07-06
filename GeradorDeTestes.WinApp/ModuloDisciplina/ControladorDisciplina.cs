﻿namespace GeradorDeTestes.WinApp.ModuloDisciplina
{
    public class ControladorDisciplina : ControladorBase
    {
        private IRepositorioDisciplina repositorioDisciplina;
        private TabelaDisciplinaControl tabelaDisciplina;

        public ControladorDisciplina(IRepositorioDisciplina repositorioDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
        }

        public override string ToolTipInserir => "Inserir nova disciplina";

        public override string ToolTipEditar => "Editar disciplina existente";

        public override string ToolTipExcluir => "Editar disciplina existente";


        public override bool BotaoInserirAtivado => true;

        public override bool BotaoDeletarAtivado => true;

        public override bool BotaoEditarAtivado => true;

        public override bool BotaoVisualizarItensAtivado => true;

        public override void Deletar()
        {

            Disciplina disciplina = ObterEntidadeSelecionado();

            if (disciplina == null)
            {
                MessageBox.Show($"Selecione uma disciplina primeiro!",
                    "Exclusão de desciplinas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a disciplina {disciplina.nome}?", "Exclusão de Disciplinas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDisciplina.Deletar(disciplina.id);

                CarregarEntidades();
            }
        }

        public override void Editar()
        {

            Disciplina disciplina = ObterEntidadeSelecionado();

            if (disciplina == null)
            {
                MessageBox.Show($"Selecione uma disciplina primeiro!",
                    "Edição de disciplinas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaDisciplinaForm telaDisciplina = new TelaDisciplinaForm();
            telaDisciplina.Disciplina = disciplina;

            DialogResult opcaoEscolhida = telaDisciplina.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDisciplina.Atualizar(telaDisciplina.Disciplina.id, telaDisciplina.Disciplina);

                CarregarEntidades();
            }
        }

        public override void Inserir()
        {
            TelaDisciplinaForm telaCliente = new TelaDisciplinaForm();

            DialogResult opcaoEscolhida = telaDisciplina.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Disciplina disciplina = telaDisciplina.Disciplina;

                repositorioDisciplina.Inserir(disciplina);

                CarregarEntidades();
            }
        }


        public override UserControl ObterListagem()
        {
            if (tabelaDisciplina == null)
                tabelaDisciplina = new TabelaDisciplinaControl();

            CarregarEntidades();

            return tabelaDisciplina;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de disciplinas";
        }

        public Disciplina ObterEntidadeSelecionado()
        {
            int id = tabelaDisciplina.ObterIdSelecionado();

            return repositorioDisciplina.Busca(id);
        }

        public override void CarregarEntidades()
        {
            List<Disciplina> disciplina = repositorioDisciplina.RetornarTodas();
            tabelaDisciplina.AtualizarRegistros(disciplina);
        }
    }
}
using FluentValidation;
using GeradorDeTestes.Aplicacao.Compartilhado;
using GeradorDeTestes.Dominio.ModuloDisciplina;
using GeradorDeTestes.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Aplicacao.ModuloDisciplina
{
    public class ServicoDisciplina : ServicoBase<Disciplina>
    {
        IRepositorioDisciplina repositorioDisciplina;
        ValidadorDisciplina validadorDisciplina;
        public ServicoDisciplina(IRepositorioDisciplina repositorioDisciplina, ValidadorDisciplina validadorDisciplina) : base(repositorioDisciplina, validadorDisciplina)
        {
            this.repositorioDisciplina = repositorioDisciplina;
            this.validadorDisciplina = validadorDisciplina;
        }

        protected override bool EntidadeDuplicada(Disciplina disciplina)
        {
            List<Disciplina> disciplinas = repositorioDisciplina.RetornarDisciplinasPorNome(disciplina);

            if (disciplinas.Exists(d => d.nome == disciplina.nome && d.id != disciplina.id))
                return true;

            return false;
        }
    }
}

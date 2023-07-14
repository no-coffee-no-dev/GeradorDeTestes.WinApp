using FluentValidation;
using GeradorDeTestes.Aplicacao.Compartilhado;
using GeradorDeTestes.Dominio.ModuloMateria;
using GeradorDeTestes.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Aplicacao.ModuloMateria
{
    public class ServicoMateria : ServicoBase<Materia>
    {
        IRepositorioMateria repositorioMateria;
        ValidadorMateria validadorMateria;
        public ServicoMateria(IRepositorioMateria repositorioMateria, ValidadorMateria validadorMateria) : base(repositorioMateria, validadorMateria)
        {
            this.repositorioMateria = repositorioMateria;
            this.validadorMateria = validadorMateria;
        }

        protected override bool EntidadeDuplicada(Materia materia)
        {
            List<Materia> materias = repositorioMateria.RetornarMateriasPorTitulo(materia);
            if (materias.Exists(m => m.nome == materia.nome && m.id != materia.id))
                return true;

            return false;
        }
    }
}

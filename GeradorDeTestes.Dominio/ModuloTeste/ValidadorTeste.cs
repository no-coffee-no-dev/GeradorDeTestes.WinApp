using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloTeste
{
    public class ValidadorTeste : AbstractValidator<Teste>
    {
        public ValidadorTeste()
        {
            RuleFor(t => t.titulo).NotEmpty().NotNull().MinimumLength(3);
            RuleFor(t => t.listaQuestoes).NotEmpty();
        }

    }
}

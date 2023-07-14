using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloMateria
{
    public class ValidadorMateria : AbstractValidator<Materia>
    {
        public ValidadorMateria()
        {
            RuleFor(m => m.nome).NotEmpty().NotNull().MinimumLength(3);
            RuleFor(m => m.serie).NotEmpty().NotNull();
            RuleFor(m => m.disiplina).NotNull();
        }
    }
}

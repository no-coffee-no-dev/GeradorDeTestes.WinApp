using FluentValidation;
using GeradorDeTestes.Dominio.ModuloTeste;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloQuestao
{
    public class ValidadorQuestao : AbstractValidator<Questao>
    {
        public ValidadorQuestao()
        {
            RuleFor(t => t.titulo).NotEmpty().NotNull().MinimumLength(3);
            RuleFor(t => t.respostaCorreta).NotEmpty().NotNull().MinimumLength(5);
            RuleFor(t => t.opcoaoA).NotEmpty().NotNull().MinimumLength(5);
            RuleFor(t => t.opcoaoB).NotEmpty().NotNull().MinimumLength(5);
            RuleFor(t => t.opcoaoC).NotEmpty().NotNull().MinimumLength(5);
            RuleFor(t => t.opcoaoD).NotEmpty().NotNull().MinimumLength(5);
        }

    }
}

using GeradorDeTestes.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloQuestao
{
    public class Questao : EntidadeBase<Questao>
    {
        public string titulo;
        public string opcoaoA;
        public string opcoaoB;
        public string opcoaoC;
        public string opcoaoD;
        public string respostaCorreta;
        public Materia materia;

        public Questao(string titulo, string opcoaoA, string opcoaoB, string opcoaoC, string opcoaoD, string respostaCorreta, Materia materia)
        {
            this.titulo = titulo;
            this.opcoaoA = opcoaoA;
            this.opcoaoB = opcoaoB;
            this.opcoaoC = opcoaoC;
            this.opcoaoD = opcoaoD;
            this.respostaCorreta = respostaCorreta;
            this.materia = materia;
        }

        public Questao(string titulo)
        {
            this.titulo = titulo;
        }

        public override void Atualizar(Questao entidadeAtualizada)
        {
            titulo = entidadeAtualizada.titulo;
            opcoaoA = entidadeAtualizada.opcoaoA;
            opcoaoB = entidadeAtualizada.opcoaoB;
            opcoaoC = entidadeAtualizada.opcoaoC;
            opcoaoD = entidadeAtualizada.opcoaoD;
            respostaCorreta = entidadeAtualizada.respostaCorreta;
            materia = entidadeAtualizada.materia;
        }

        public override string? ToString()
        {
            return $"{titulo}";
        }
    }
}


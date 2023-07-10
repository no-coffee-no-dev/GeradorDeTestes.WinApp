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

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("O campo 'titulo' é obrigatório");
            if (string.IsNullOrEmpty(opcoaoA) || string.IsNullOrEmpty(opcoaoB) || string.IsNullOrEmpty(opcoaoC) || string.IsNullOrEmpty(opcoaoD))
                erros.Add("Deve conter 4 opções de resposta");
            if (string.IsNullOrEmpty(respostaCorreta))
                erros.Add("Deve ter uma resposta marcada como correta");
            if (materia == null)
                erros.Add("Deve ter uma materia marcada");

            return erros.ToArray();
        }

        public override string? ToString()
        {
            return $"{titulo}";
        }
    }
}


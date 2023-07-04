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
        public List<Opcao> opcoes;
        public string respostaCorreta;
        public Materia materia;

     

        public override void Atualizar(Questao entidadeAtualizada)
        {
            titulo = entidadeAtualizada.titulo;
            opcoes = entidadeAtualizada.opcoes;
            respostaCorreta = entidadeAtualizada.respostaCorreta;
            materia = entidadeAtualizada.materia;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("O campo 'titulo' é obrigatório");
            if (opcoes.Count != 4)
                erros.Add("Deve conter 4 opções de resposta");
            if (string.IsNullOrEmpty(respostaCorreta))
                erros.Add("Deve ter uma resposta marcada como correta");
            if (materia == null)
                erros.Add("Deve ter uma materia marcada");

            return erros.ToArray();
        }

        public void ObterResposta()
        {
            foreach (Opcao opcao in opcoes)
            {
                if(opcao.estahCorreta == true)
                {
                    respostaCorreta = opcao.resposta;
                }
            }
        }



    }

    #region --------TEMPORÀRIO---------
    public class Materia 
        {
        public string nome;
        }
    #endregion
}

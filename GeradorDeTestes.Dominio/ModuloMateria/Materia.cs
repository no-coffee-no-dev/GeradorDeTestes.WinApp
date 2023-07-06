using GeradorDeTestes.Dominio.ModuloQuestao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>

    {

        public string nome;
        public Disiplina disiplina;
        public string serie;

        public Materia(string nome, Disiplina disiplina, string serie) {

            this.nome = nome;
            this.disiplina = disiplina;
            this.serie = serie;
        
        }
        public override void Atualizar(Materia entidadeAtualizada)
        {
            this.nome = entidadeAtualizada.nome;
            this.disiplina = entidadeAtualizada.disiplina;
            this.serie = entidadeAtualizada.serie;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();
            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");
            if (disiplina == null)
                erros.Add("Deve ter uma disiplina selecionada");
            if (string.IsNullOrEmpty(serie))
                erros.Add("Deve ter um serie selecionada");

            return erros.ToArray();
            
        }




        #region Remover depois
        public class Disiplina : EntidadeBase<Disiplina>
        {   
            string nome;
            public override void Atualizar(Disiplina entidadeAtualizada)
            {
            throw new NotImplementedException();
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
        }
        #endregion
    }
}

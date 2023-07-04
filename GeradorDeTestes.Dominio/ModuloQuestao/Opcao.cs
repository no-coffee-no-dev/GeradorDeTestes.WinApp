using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloQuestao
{
    public class Opcao : EntidadeBase<Opcao>
    {
        public string resposta;
        public bool estahCorreta;
        public override void Atualizar(Opcao entidadeAtualizada)
        {
            resposta = entidadeAtualizada.resposta;
            estahCorreta = entidadeAtualizada.estahCorreta;
        }

        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}

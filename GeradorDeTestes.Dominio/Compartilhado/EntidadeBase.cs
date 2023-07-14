using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.Compartilhado
{
    [Serializable]
    public abstract class EntidadeBase<TEntidade>
    {
        public int id;

        public abstract void Atualizar(TEntidade entidadeAtualizada);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloMateria
{
    public interface IRepositorioMeteria:IRepositorio<Materia>
    {
        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        void IRepositorio<Materia>.Atualizar(int id, Materia entidade)
        {
            throw new NotImplementedException();
        }

        Materia IRepositorio<Materia>.Busca(int id)
        {
            throw new NotImplementedException();
        }

        void IRepositorio<Materia>.Inserir(Materia novaEntidade)
        {
            throw new NotImplementedException();
        }


        List<Materia> IRepositorio<Materia>.RetornarTodos()
        {
            throw new NotImplementedException();
        }
    }
}

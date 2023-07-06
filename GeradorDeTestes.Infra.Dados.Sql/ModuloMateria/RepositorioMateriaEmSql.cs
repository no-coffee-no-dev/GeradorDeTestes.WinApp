using GeradorDeTestes.Dominio.ModuloMateria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloMateria
{
    public class RepositorioMateriaEmSql : RepositorioBaseEmSql<Materia, MapeadorMateria>, IRepositorioMateria
    {
        public override string SqlInserir => throw new NotImplementedException();

        public override string SqlBuscarTodos => throw new NotImplementedException();

        public override string SqlDeletar => throw new NotImplementedException();

        public override string SqlBuscaId => throw new NotImplementedException();

        public override string SqlEditar => throw new NotImplementedException();
    }
}

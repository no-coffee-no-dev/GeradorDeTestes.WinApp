using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDeTestes.Dominio.ModuloQuestao;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestao
{
    public class RepositorioQuestaoEmSql : RepositorioBaseEmSql<Questao, MapeadorQuestao>
    {
        public override string SqlInserir => throw new NotImplementedException();

        public override string SqlBuscarTodos => throw new NotImplementedException();

        public override string SqlDeletar => throw new NotImplementedException();

        public override string SqlBuscaId => throw new NotImplementedException();

        public override string SqlEditar => throw new NotImplementedException();
    }
}

using GeradorDeTestes.Dominio.ModuloDisciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloDisciplina
{
    public class RepositorioDisciplinaEmSql : RepositorioBaseEmSql<Disciplina, MapeadorDisciplina>, IRepositorioDisciplina
    {
        public override string SqlInserir => throw new NotImplementedException();

        public override string SqlBuscarTodos => @"SELECT [ID]
                                                      ,[NOME]
                                                  FROM [DBO].[TBDISCIPLINA]";

        public override string SqlDeletar => throw new NotImplementedException();

        public override string SqlBuscaId => throw new NotImplementedException();

        public override string SqlEditar => throw new NotImplementedException();
    }
}

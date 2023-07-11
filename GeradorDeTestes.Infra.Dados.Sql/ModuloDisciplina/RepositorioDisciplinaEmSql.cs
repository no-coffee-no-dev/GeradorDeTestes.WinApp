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
        public override string SqlInserir => @"INSERT INTO [DBO].[TBDISCIPLINA]
                                       ([NOME]) VALUES (@NOME);
                              SELECT SCOPE_IDENTITY();";

        public override string SqlBuscarTodos => @"SELECT [ID]
                                                      ,[NOME]
                                                  FROM [DBO].[TBDISCIPLINA]";

        public override string SqlDeletar => @"DELETE FROM [dbo].[TBDISCIPLINA]
                                                 WHERE [ID] = @ID;";

        public override string SqlBuscaId => @"SELECT [ID]
                                                      ,[NOME]
                                                  FROM [DBO].[TBDISCIPLINA] WHERE [TBDISCIPLINA].[ID] = @ID;";

        public override string SqlEditar => @"UPDATE [DBO].[TBDISCIPLINA]
                                                SET [NOME] = @NOME WHERE [ID] = @ID;";
    }
}

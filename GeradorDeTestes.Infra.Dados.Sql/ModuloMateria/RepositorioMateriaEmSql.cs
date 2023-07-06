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
        public override string SqlInserir => @"
                                INSERT INTO [DBO].[TBMATERIA]
                                           (
                                           ,[NOME]
                                           ,[SERIE]
                                           ,[ID_DISCIPLINA])
                                     VALUES
                                           (
                                           ,@NOME
                                           ,@SERIE
                                           ,@ID_DISCILINA)
                                    SELECT SCOPE_IDENTITY();";

        public override string SqlBuscarTodos => @"SELECT 
                                                   [ID]
                                                  ,[NOME]
                                                  ,[SERIE]
                                                  ,[id_disciplina]
                                              FROM 
                                                [DBO].[TBMateria];";

        public override string SqlDeletar => throw new NotImplementedException();

        public override string SqlBuscaId => throw new NotImplementedException();

        public override string SqlEditar => throw new NotImplementedException();
    }
}

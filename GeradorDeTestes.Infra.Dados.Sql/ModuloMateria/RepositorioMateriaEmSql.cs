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
                                                  ,[NOME] as NOME_MATERIA
                                                  ,[SERIE]
                                                  ,[ID_DISCIPLINA]
                                              FROM 
                                                [DBO].[TBMATERIA];";

        public override string SqlDeletar => @"DELETE FROM [TBMateria] WHERE [Id] = @Id ";

        public override string SqlBuscaId => @"SELECT 
                                                [ID]
                                               ,[NOME] as NOME_MATERIA
                                               ,[SERIE]
                                               ,[ID_DISCIPLINA]                                             
                                              FROM 
                                                [DBO].[TBMATERIA]
                                              WHERE [ID] = @ID;";

        public override string SqlEditar => @"UPDATE [TBMATERIA] SET

                                    [NOME] = @NOME
                                   ,[SERIE] = @SERIE
                                   ,[ID_DISCIPLINA] = @ID_DISCIPLINA

                                  WHERE

                                  [ID] = @ID";
    }
}

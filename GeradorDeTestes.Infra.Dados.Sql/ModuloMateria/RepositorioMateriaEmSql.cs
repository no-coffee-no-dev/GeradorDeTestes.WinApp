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
                                           [NOME]
                                           ,[SERIE]
                                           ,[ID_DISCIPLINA])
                                     VALUES
                                           (
                                            @NOME_MATERIA
                                           ,@SERIE
                                           ,@ID_DISCIPLINA);
                                    SELECT SCOPE_IDENTITY();";

        public override string SqlBuscarTodos => @"SELECT
                                                   M.[ID]
                                                  ,M.[nome] as NOME_MATERIA
                                                  ,M.[SERIE] 
                                                  ,M.[ID_DISCIPLINA]
                                                  ,D.[ID]
												  ,D.[NOME]
                                                 
                                              FROM 
                                                   TBMATERIA M
                                                
                                        INNER JOIN TBDISCIPLINA  D ON M.ID_DISCIPLINA = D.ID;";

        public override string SqlDeletar => @"DELETE FROM [TBMateria] WHERE [Id] = @Id ";

        public override string SqlBuscaId => @"SELECT 
                                             M.[ID]
                                                  ,M.[nome] as NOME_MATERIA
                                                  ,M.[SERIE] 
                                                  ,M.[ID_DISCIPLINA]
                                                  ,D.[ID]
												  ,D.[NOME]                                            
                                              FROM 
                                                    TBMATERIA M
                                              INNER JOIN TBDISCIPLINA  D ON M.ID_DISCIPLINA = D.ID
                                              WHERE M.[ID] = @ID;";

        public override string SqlEditar => @"UPDATE [TBMATERIA] SET

                                    [NOME]  = @NOME_MATERIA
                                   ,[SERIE] = @SERIE
                                   ,[ID_DISCIPLINA] = @ID_DISCIPLINA

                                  WHERE

                                  [ID] = @ID";
    }
}

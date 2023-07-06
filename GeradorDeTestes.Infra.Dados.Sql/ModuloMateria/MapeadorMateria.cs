using GeradorDeTestes.Dominio.ModuloMateria;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloMateria
{
    public class MapeadorMateria : MapeadorBase<Materia>
    {
        public override void ConfigurarParametros(SqlCommand comandoEditar, Materia novaEntidade)
        {
            throw new NotImplementedException();
        }

        public override Materia ConverterParaEntidade(SqlDataReader leitorEntidades)
        {
            throw new NotImplementedException();
        }
    }
}

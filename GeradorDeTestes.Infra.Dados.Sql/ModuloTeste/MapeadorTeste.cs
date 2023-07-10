using GeradorDeTestes.Dominio.ModuloTeste;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloTeste
{
    public class MapeadorTeste : MapeadorBase<Teste>
    {
        public override void ConfigurarParametros(SqlCommand comandoEditar, Teste novaEntidade)
        {
            throw new NotImplementedException();
        }

        public override Teste ConverterParaEntidade(SqlDataReader leitorEntidades)
        {
            throw new NotImplementedException();
        }
    }
}

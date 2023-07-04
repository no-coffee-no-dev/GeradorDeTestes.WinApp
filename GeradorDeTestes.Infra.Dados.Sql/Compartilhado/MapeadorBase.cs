using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Infra.Dados.Sql.Compartilhado
{
    public abstract class MapeadorBase<TEntidade>
    {
        public abstract TEntidade ConverterParaEntidade(SqlDataReader leitorEntidades);

        public abstract void ConfigurarParametros(SqlCommand comandoEditar, TEntidade novaEntidade);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeradorDeTestes.Dominio.ModuloQuestao;
using Microsoft.Data.SqlClient;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloQuestao
{
    public class MapeadorQuestao : MapeadorBase<Questao>
    {
        public override void ConfigurarParametros(SqlCommand comandoEditar, Questao novaEntidade)
        {
            throw new NotImplementedException();
        }

        public override Questao ConverterParaEntidade(SqlDataReader leitorEntidades)
        {
            throw new NotImplementedException();
        }
    }
}

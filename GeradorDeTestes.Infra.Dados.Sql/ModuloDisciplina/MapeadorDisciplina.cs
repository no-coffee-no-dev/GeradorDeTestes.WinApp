using GeradorDeTestes.Dominio.ModuloDisciplina;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Infra.Dados.Sql.ModuloDisciplina
{
    public class MapeadorDisciplina : MapeadorBase<Disciplina>
    {
        public override void ConfigurarParametros(SqlCommand comandoEditar, Disciplina novaEntidade)
        {
            throw new NotImplementedException();
        }

        public override Disciplina ConverterParaEntidade(SqlDataReader leitorEntidades)
        {
            throw new NotImplementedException();
        }
    }
}

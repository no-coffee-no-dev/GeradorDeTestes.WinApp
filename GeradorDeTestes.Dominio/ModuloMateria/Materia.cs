﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.Dominio.ModuloMateria
{
    public class Materia : EntidadeBase<Materia>
    {
        public string nome;

        public override void Atualizar(Materia entidadeAtualizada)
        {
            throw new NotImplementedException();
        }
        public override string[] Validar()
        {
            throw new NotImplementedException();
        }
    }
}

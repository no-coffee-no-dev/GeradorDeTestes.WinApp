﻿using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.Compartilhado
{
    public delegate Result InserirEntidadeDelegate<T>(T entidade);

}
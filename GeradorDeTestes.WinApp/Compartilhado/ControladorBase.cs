﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeradorDeTestes.WinApp.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }
        public abstract string ToolTipEditar { get; }
        public abstract string ToolTipExcluir { get; }


        public abstract bool BotaoInserirAtivado { get; }
        public abstract bool BotaoDeletarAtivado { get; }
        public abstract bool BotaoEditarAtivado { get; }
        public abstract bool BotaoVisualizarItensAtivado { get; }
        public abstract bool BotaoConfigurarDescontoAtivado { get; }



        public abstract void Inserir();
        public abstract void Editar();
        public abstract void Deletar();

        public abstract void CarregarEntidades();





    }
}

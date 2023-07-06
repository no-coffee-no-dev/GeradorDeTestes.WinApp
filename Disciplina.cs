using System;

namespace GeradorDeTestes.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public string Nome { get; set; }

            this.nome = nome;
        }

        public override void Atualizar(Disciplina entidadeAtualizada)
        {
            nome = entidadeAtualizada.nome;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo 'nome' é obrigatório");
            if (nome.Length < 3)
                erros.Add("O campo 'nome' deve ter no mínimo 3 letras");

            return erros.ToArray();
        }
        public override string ToString()
        {
            return $"{nome}";
        }
    }
}

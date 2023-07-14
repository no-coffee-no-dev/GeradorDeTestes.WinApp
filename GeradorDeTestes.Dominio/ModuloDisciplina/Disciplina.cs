using System;

namespace GeradorDeTestes.Dominio.ModuloDisciplina
{
    public class Disciplina : EntidadeBase<Disciplina>
    {
        public Disciplina(string nome)
        {
            this.nome = nome;
        }

        public string nome { get; set; }


        public override void Atualizar(Disciplina entidadeAtualizada)
        {
            nome = entidadeAtualizada.nome;
        }

        public override string ToString()
        {
            return $"{nome}";
        }
    }
}

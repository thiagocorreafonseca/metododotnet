using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacaoOO
{
    public class Estudante : Pessoa
    {
        public Estudante(string turma, string nome, string documento, DateTime dataNascimento): base(nome, documento, dataNascimento)
        {
            var random = new Random();
            Turma = turma;
            Notas = new List<int> { random.Next(10), random.Next(10), random.Next(10), random.Next(10), random.Next(10), random.Next(10) };
        }

        public string Turma { get; private set; }
        public List<int> Notas { get; private set; }

        public override void SeApresentar()
        {
            base.SeApresentar();

            var media = Notas.Average();
            Console.WriteLine($"Sou um estudante da turma {Turma}, Média de Nota: {media}");
        }
    }
}

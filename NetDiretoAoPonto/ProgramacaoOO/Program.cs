using System;
using System.Collections.Generic;

namespace ProgramacaoOO
{
    class Program
    {
        static void Main(string[] args)
        {
            var professor = new Professor(1000m, "Thiago", "1231231", new DateTime(1987, 5, 4));
            var estudante = new Estudante("A", "José", "23232", new DateTime(2000, 1, 4));

            var pessoas = new List<Pessoa> { professor, estudante };

            foreach (var pessoa in pessoas)
            {
                pessoa.SeApresentar();
            }

            Console.ReadKey();
        }
    }
}

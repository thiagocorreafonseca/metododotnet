using System;

namespace TiposDadosConversoesOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tipos de Dados

            int numeroInt = 10;
            int maiorNumeroInt = int.MaxValue;
            int menorNumeroInt = int.MinValue;

            long numeroLong = 1231231231231123123;
            long maiorNumeroLong = long.MaxValue;
            long menorNumeroLong = long.MinValue;

            decimal numeroDecimal = 10.52m;

            double numeroDouble = 12.3;
            double menorNumeroDouble = double.MinValue;
            double maiorNumeroDouble = double.MaxValue;

            bool verdadeiro = true;
            bool falso = false;

            var numero = 10;

            string nome = "Nome Bla Bla Bla";
            char letra = 'T';

            DateTime entradaEmpresa = new DateTime(2022, 1, 1);
            TimeSpan quantoTempoDeEmpresa = DateTime.Now - entradaEmpresa;
            #endregion

            #region Conversões
            int notaAluno = 10;

            //implicita
            double notaAlunoDouble = notaAluno;

            //explicita
            int numeroDoubleComoInt = (int)notaAlunoDouble;

            //utilizando Convert
            string notaString = "10";

            int notaConvert = Convert.ToInt32(notaString);

            //utilizando Parse
            int notaParse = int.Parse(notaString);

            if(int.TryParse(notaString, out int notaTryParse))
            {

            }else
            {
                Console.WriteLine("Número em formato inválido.");
            }
            #endregion

            #region Operadores Aritmeticos
            //Unários ++ -- + -
            int numeroOperador = 4;

            Console.WriteLine(numeroOperador++);
            Console.WriteLine(numeroOperador--);

            Console.WriteLine(++numeroOperador);
            Console.WriteLine(--numeroOperador);

            Console.WriteLine(numeroOperador);
            Console.WriteLine(-numeroOperador);
            Console.WriteLine(-(-numeroOperador));

            //Binários + - * /
            var soma = 4 + 5;
            var subtracao = 4 - 5;
            var multiplicacao = 4 * 5;
            var divisao = 20 / 3;
            var divisaoDouble = (double)20 / 3;

            var multiplos = (4 * 5) + 10;
            #endregion

            #region Operadores Comparação
            //> >= < <=
            Console.WriteLine(4 > 5);
            Console.WriteLine(5 > 5);
            Console.WriteLine(5 >= 6);

            Console.WriteLine(5 < 4);
            Console.WriteLine(5 <= 5);
            Console.WriteLine(5 < 6);
            #endregion

            #region Operadores de Igualdade
            // == !=
            Console.WriteLine(5 == 5);
            Console.WriteLine(5 == 4);

            Console.WriteLine(5 != 5);
            Console.WriteLine(4 != 5);
            #endregion

            #region Operadores Lógicos
            // AND(&&) OR(||)
            var minhaNota = 7;
            var ultimoAno = true;

            if (minhaNota >= 7 && ultimoAno)
            {
                Console.WriteLine("Aprovado e terminou o curso.");
            }

            minhaNota = 4;
            if(minhaNota >= 7 || ultimoAno)
            {
                Console.WriteLine("Aprovado");
            }

            Console.WriteLine(true || false);
            Console.WriteLine(false || true);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);

            Console.WriteLine(true && false);
            Console.WriteLine(false && true);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);
            #endregion
        }

    }
}

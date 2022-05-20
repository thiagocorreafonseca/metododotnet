using System;

namespace DEbugandoAplicacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Debugging
            var numerosString = Console.ReadLine();
            var numeros = numerosString.Split(' ');

            foreach (var numero in numeros)
            {
                var numeroInt = int.Parse(numero);
                var aoQuadrado = Math.Pow(numeroInt, 2);

                Console.WriteLine($"Número: {numeroInt}² - {aoQuadrado}");
            }
            #endregion
            Console.ReadKey();
        }
    }
}

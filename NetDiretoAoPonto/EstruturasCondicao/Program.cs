using System;

namespace EstruturasCondicao
{
    class Program
    {
        static void Main(string[] args)
        {

            //if else
            var notaDigitada = Console.ReadLine();
            var nota = int.Parse(notaDigitada);

            if(nota >= 70)
            {
                Console.WriteLine("Aprovado");
            }else if (nota >= 40)
            {
                Console.WriteLine("Em recuperação");
            }else
            {
                Console.WriteLine("Reprovado");
            }

            //switch case
            Console.WriteLine("Bem Vindo.");

            Console.WriteLine("Digite 1 - Contratação de Serviço");
            Console.WriteLine("Digite 2 - Reclamação de Serviço");
            Console.WriteLine("Digite 3 - Segunda via de Boleto");
            Console.WriteLine("Digite 4 - Sair");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Informações sobre serviço.");
                    break;

                case "2":
                    Console.WriteLine("Fale sobre sua reclamação.");
                    break;

                case "3":
                    Console.WriteLine("Segunda via do boleto enviada por e-mail.");
                    break;

                case "4":
                    Console.WriteLine("Tenha um bom dia.");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}

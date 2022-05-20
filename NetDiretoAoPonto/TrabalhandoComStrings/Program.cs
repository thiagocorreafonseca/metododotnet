using System;

namespace TrabalhandoComStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Principais Métodos
            var paragrafo = "    C# é uma linguagem moderna e versátil. " +
                "Com C# consigo desenvolver para web, desktop e mobile, jogos entre outros.    ";

            var tamanho = paragrafo.Length;

            var vazio = String.Empty;

            var paragrafoMinusculo = paragrafo.ToLower();
            var paragrafoMaiusculo = paragrafo.ToUpper();

            var frases = paragrafo.Split('.');

            var paragrafoTrim = paragrafo.Trim();
            var paragrafoTrimStart = paragrafo.TrimStart();
            var paragrafoTrimEnd = paragrafo.TrimEnd();

            var isNullOrWhiteSpace = string.IsNullOrWhiteSpace(paragrafo);

            var paragrafoCSharp = paragrafo.Replace("C#", "C-Sharp");
            #endregion

            #region Métodos Pesquisa
            var outroParagrafo = "C# é uma linguagem moderna e versátil. " +
                "Com C# consigo desenvolver para web, desktop e mobile, jogos entre outros.";

            var indexOf = outroParagrafo.IndexOf("C#");
            var lastIndexOf = outroParagrafo.LastIndexOf("C#");
            var startsWith = outroParagrafo.StartsWith("C#");

            var indexOfMobile = outroParagrafo.IndexOf("mobile");
            var substringMobile = outroParagrafo.Substring(indexOfMobile, 6);

            var contains = outroParagrafo.Contains("Jogos", StringComparison.OrdinalIgnoreCase);
            var containsExact = outroParagrafo.Contains("jogos");
            var containsTeste = outroParagrafo.Contains("Teste");
            #endregion
            Console.ReadKey();
        }
    }
}

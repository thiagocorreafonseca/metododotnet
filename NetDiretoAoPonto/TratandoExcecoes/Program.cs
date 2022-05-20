using System;

namespace TratandoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tratando Exceções
            var seteString = "sete";
            string valorNull = null;
            var longValue = long.MaxValue.ToString();

            try
            {
                //var formatException = int.Parse(seteString);
                //var argumentNullException = int.Parse(valorNull);
                var overflowException = int.Parse(longValue);
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"FormatException : {ex.Message}");           
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"Argument Null Exception : {ex.Message}");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"Overflow Exception : {ex.Message}");
            }
            finally
            {
                Console.WriteLine($"Try-Finally executado.");
            }
            #endregion

            Console.ReadKey();
        }
    }
}

using System;

namespace TrabalhandoComDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DateTime Métodos
            var today = DateTime.Today;
            var now = DateTime.Now;

            var threeDaysAgo = today.AddDays(-3);
            var sixMonthsLater = today.AddMonths(6);
            var twoYears = today.AddYears(2);

            var shortDate = now.ToShortDateString();
            var longDate = now.ToLongDateString();

            var shortTime = now.ToShortTimeString();
            var longTime = now.ToLongTimeString();

            var date = now.Date;
            var day = now.Day;
            var month = now.Month;
            var year = now.Year;
            var hour = now.Hour;
            var minute = now.Minute;
            var second = now.Second;

            var dayOfWeek = now.DayOfWeek;
            var dayOfYear = now.DayOfYear;
            #endregion

            #region DateTime Formatação
            var formats = new string[] { "d", "D", "f", "F", "g", "G", "m", "o", "r", "s", "t", "T", "u", "U", "Y" };

            Console.WriteLine("Formatos:");
            foreach (var format in formats)
            {
                Console.WriteLine("Data no formato {0}: {1}", format, now.ToString(format));
                Console.WriteLine($"Data no formato {format}: {now.ToString(format)}");
            }
            #endregion

            Console.WriteLine("Diferentes maneiras de formatar manualmente");
            Console.WriteLine($"Data no formato d: {now:d}");
            Console.WriteLine($"Data no formato MM-dd-yyyy: {now:MM-dd-yyyy}");

            var dateFormat = now.ToString("MM-dd-yyyy");
            var dateFormatBr = now.ToString("dd/yy/MMMM HH:mm:ss");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraysListasLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var numbersCopy = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersCopy[i] = numbers[i];
            }

            var numbersString = "0 1 2 3 4 5 6 7 8 9";
            var numbersSplit = numbersString.Split(' ');
            var numbersConvertedToString = Array.ConvertAll(numbersSplit, Convert.ToInt32);
            #endregion

            #region Listas
            //var list = new List<int>();
            //var listFromArray = new List<int>(numbers);
            var list = new List<int> { 0, 1, 2, 3, 4 };

            list.Add(5);
            list.AddRange(new List<int> { 6, 7 });
            list.AddRange(new int[] { 8, 9 });

            var countlist = list.Count;
            var contains14 = list.Contains(14);
            var contains2 = list.Contains(2);

            Console.WriteLine("Lista Reversa");
            list.Reverse();
            list.ForEach(l => Console.WriteLine(l));

            Console.WriteLine("Lista Ordenada");
            list.Sort();
            list.ForEach(l => Console.WriteLine(l));

            list.Remove(4);
            list.RemoveAll(l => l > 5);

            list.Clear();
            #endregion

            #region LINQ   
            var students = new List<Student>
            {
                new Student(1, "Marcos", "768657564", 100),
                new Student(2, "José", "768657564", 35),
                new Student(3, "Thiago", "768657564", 85),
                new Student(4, "Roberto", "768657564", 70),
                new Student(5, "Marcos", "768657564", 75)
            };

            var any = students.Any();
            var any100 = students.Any(s => s.Grade == 100);

            var single = students.Single(s => s.Id == 1);
            var singleOrDefault = students.SingleOrDefault(s => s.Grade == 0);

            var first = students.First(s => s.FullName == "Marcos");
            var firstOrDefault = students.FirstOrDefault(s => s.Grade == 0);

            var orderedBy = students.OrderBy(s => s.Grade);
            var orderedByDescending = students.OrderByDescending(s => s.Grade);

            var approvedStudents = students.Where(s => s.Grade >= 70);

            var grades = students.Select(s => s.Grade);
            var phoneNumbers = students.SelectMany(s => s.PhoneNumbers);

            var sum = students.Sum(s => s.Grade);
            var min = students.Min(s => s.Grade);
            var max = students.Max(s => s.Grade);
            var count = students.Count;
            #endregion
            Console.ReadKey();
        }

        public class Student
        {
            public Student(int id, string fullName, string document, int grade)
            {
                Id = id;
                FullName = fullName;
                Document = document;
                Grade = grade;

                PhoneNumbers = new List<string> { "1498769876", "1434563456", "1476547654" };
            }
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Document { get; set; }
            public int Grade { get; set; }

            public List<string> PhoneNumbers { get; set; }
        }
    }
}

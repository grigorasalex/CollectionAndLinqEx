namespace CollectionLinqEx
{
    using System;
    using System.Linq;

    public class BasicExercises
    {
        public static BasicExercises New => new BasicExercises();

        public void Exercise1()
        {
            var numbers = Enumerable.Range(1, 50).ToArray();

            // Selectati toate numerele ca si string de forma [x], unde x este numarul.
            // Numerele selectate trebuie sa fie divizibile cu 5 si sortate descrescator
            // Rezultatul trebuie sa fie de forma: [50], [45], [40]

            var filteredNumbers = numbers.Where(num => num % 5 == 0)
                .OrderByDescending(num => num)
                .Select(num => $"[{num}]")
                .ToList();

            foreach(string str in filteredNumbers)
            {
                Console.WriteLine(str);
            }

        }

        public void Exercise2()
        {
            var numbers = Enumerable.Range(1, 20).ToArray();

            // Selectati toate numerele din intervalul 5-15 si afisati pentru fiecare patratul sau.

            var cubedFilteredNumbers = numbers.Where(num => num >= 5 && num <= 15)
                .Select(num => num * num)
                .ToList();

            foreach(int number in cubedFilteredNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public void Exercise3()
        {
            var names = new[] {"Alex", "Andrei", "Marian", "Bogdan"};

            // Selectati prima litera a num
            //elui (aplicati aceasta selectie doar pentru acele nume care au litera a in interior, nu conteaza daca este mica sau mare)

            var fistLetterFromName = names.Where(name => name[1..^1].Contains("a"))
                .Select(name => name.First())
                .ToList();

            foreach (char str in fistLetterFromName)
            {
                Console.WriteLine(str);
            }
        }
    }
}

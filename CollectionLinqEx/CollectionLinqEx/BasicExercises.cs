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

            var result = numbers.Where(s => s%5 == 0).Select(s => "["+s+"]");

            // Selectati toate numerele ca si string de forma [x], unde x este numarul.
            // Numerele selectate trebuie sa fie divizibile cu 5 si sortate descrescator
            // Rezultatul trebuie sa fie de forma: [50], [45], [40]
        }

        public void Exercise2()
        {
            var numbers = Enumerable.Range(1, 20).ToArray();

            var result = numbers.Where(s => s>=5 && s<=15).Select(s => s*s);
           
            // Selectati toate numerele din intervalul 5-15 si afisati pentru fiecare patratul sau.
        }

        public void Exercise3()
        {
            var names = new[] {"Alex", "Andrei", "Marian", "Bogdan"};

            var result = names.Where( x => x.Substring(1, x.Length - 2).Contains('a') || x.Substring(1, x.Length -2).Contains('A')).Select(x => x.Substring(0, 1));
           
            // Selectati prima litera a numelui (aplicati aceasta selectie doar pentru acele nume care au litera a in interior, nu conteaza daca este mica sau mare)
        }
    }
}

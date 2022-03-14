using System;

namespace lab_1
{
    class Program
    {
        static void Main()
        {
            Fraction a = new (6, 2);
            Fraction b = new (2, 3);
            Fraction c = new (4, 8);
            Fraction d = new (3, 4);
            Fraction e = new (2, 1);
            Fraction f = new (1, 10);

            Fraction[] fractions = { a, b, c, d, e, f };
            Array.Sort(fractions);
            foreach (Fraction fraction in fractions)
            {
                Console.WriteLine(fraction.ToString());
            }
        }
    }
}

using System;

namespace Jędrzej_Czykier_laboratorium
{
    class Program
    {
        static void Main(string[] args)
        {
            zad1();
        }

        public static void zad1()
        {
            int number = int.Parse(Console.ReadLine());
            string word = Console.ReadLine();
            Console.WriteLine($"podana liczba to {number}, a podany wyraz to {word}");
        }
        public static void zad2()
        {
            Console.WriteLine("Podaj dwie liczby: ");
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            Console.WriteLine($"Suma liczb: {x + y}");
            Console.WriteLine($"Różnia liczba: {x - y}");
            Console.WriteLine($"Iloczyn liczb: {x * y}");
            Console.WriteLine($"Iloraz liczb: {x / y}");

        }
    }
}

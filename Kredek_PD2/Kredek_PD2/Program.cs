using System;
using System.Collections.Generic;

namespace Kredek_PD2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> haslo = new List<char>();
            List<char> zgadniete = new List<char>();
            Console.WriteLine("Podaj haslo");
            string hasloString = Console.ReadLine();
            foreach (char i in hasloString)
            {
                haslo.Add(i);
            }
            bool warunek = true;
            int lives = 10, x;
            while (warunek)
            {
                x = 0;
                Console.WriteLine("\nHaslo: ");
                foreach(char i in hasloString)
                {
                    if (zgadniete.Contains(i))
                    {
                        Console.Write(i + " ");
                        x++;
                        if(x == hasloString.Length)
                        {
                            Console.WriteLine("\nWygrales!");
                            warunek = false;
                        }
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                }
                if (warunek)
                {

                    Console.WriteLine("\nZgadnij literke");

                    try
                    {
                        char c = char.Parse(Console.ReadLine());
                        if (haslo.Contains(c) == false)
                        {
                            lives--;
                            Console.WriteLine("Hasło nie zawiera podanej literki");
                            Console.WriteLine("Pozostało " + lives + " żyć");
                            if (lives == 0)
                            {
                                Console.WriteLine("Przegrałeś!");
                                warunek = false;
                            }
                        }
                        else
                        {
                            if (zgadniete.Contains(c))
                            {
                                Console.WriteLine("Już zgadłeś tą literkę!");
                            }
                            else
                            {
                                zgadniete.Add(c);
                            }
                        }
                    }
                    catch (System.FormatException e)
                    {
                        Console.WriteLine("Można zgadywać po tylko jednej literce!");
                    }
                }

            }
        }
    }
}
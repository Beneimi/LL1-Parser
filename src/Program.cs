using System;
using System.Collections.Generic;

namespace LL1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nyelvtan megadása (m) / Példa nylvtan használata (p)");
            string inputBuffer = Console.ReadLine();

            var g = new Grammar(new char[] { 'a', 'b', 'c', 'd', 'e' }, new char[] { 'S', 'A', 'B', 'C', 'D' });
            g.AddRule('S', "ABC");
            g.AddRule('A', "a");
            g.AddRule('A', "Bbc");
            g.AddRule('A', "Ccd");
            g.AddRule('B', "bBb");
            g.AddRule('B', "cCc");
            g.AddRule('C', "dDd");
            g.AddRule('C', "Dd");
            g.AddRule('D', "e");

            while (true)
            {

                // use example
                if ( inputBuffer == "p")
                {
                    break;
                } // define own grammar
                else if (inputBuffer == "m")
                {
                    Console.WriteLine("Terminálisok (elválasztás nélküli karakterek) : ");
                    inputBuffer = Console.ReadLine();
                    char[] term = new char[inputBuffer.Length];

                    for (int i = 0; i < inputBuffer.Length; i++)
                    {
                        term[i] = inputBuffer[i];
                    }

                    Console.WriteLine("Nem terminálisok (elválasztás nélküli karakterek) : ");
                    inputBuffer = Console.ReadLine();
                    char[] nonterm = new char[inputBuffer.Length];

                    for (int i = 0; i < inputBuffer.Length; i++)
                    {
                        nonterm[i] = inputBuffer[i];
                    }

                    g = new Grammar(term, nonterm);

                    Console.WriteLine("Szabályok: Bal oldal aztán Enter, majd jobb oldal. (bal oldalra írjon 'kilépés'-t a befejezéshez) )");
                    char left;
                    while ( ( inputBuffer = Console.ReadLine() ) != "kilépés")
                    {
                        left = inputBuffer[0];
                        Console.Write("  --->  ");
                        g.AddRule(left, Console.ReadLine());
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Érvénytelen utasítás");
                    Console.WriteLine("Nyelvtan megadása (m) / Példa nylvtan használata (p)");

                }

            }

            while (true)
            {
                Console.WriteLine("Elemezni kívánt szó: ");

                if (g.Parse(Console.ReadLine()))
                {
                    Console.WriteLine("A szó levezethető");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("A szó nem vezethető le");
                    Console.WriteLine();
                }
            }
        }
    }
}

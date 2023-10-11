using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace RecursionPlayground
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int n = -1;
            while (n < 0) 
            {
                n = int.Parse(Console.ReadLine()); // Nacteme cislo n, pro ktere budeme pocitat jeho faktorial a n-ty prvek Fibonacciho posloupnosti.
                if (n < 0)
                {
                    Console.WriteLine("zadane cislo musi byt nezaporne, zadej znovu");  // fact ani fib nejsou pro zaporna cisla definovana...
                }
            }
            int factorial = Factorial(n); // Prvni zavolani pro vypocet faktorialu, ulozeni do promenne factorial.
            int fibonacci = Fibonacci(n); // Prvni zavolani pro vypocet Fibonacciho posloupnosti, ulozeni do promenne fibonacci.
            Console.WriteLine($"Pro cislo {n} je faktorial {factorial}. {n}. prvek Fibonacciho posloupnosti je {fibonacci}"); // Vypsani vysledku uzivateli.
            Console.ReadKey();
            
        }

        

        static int Factorial(int n)
        {
            int res; // result, reseni

            if (n > 1)
            {
                res = Factorial(n - 1) * n;
            }
            else
            {
                res = 1;
            }
            
            // TODO: Urci ukoncovaci podminku pro faktorial a zavolej Factorial zevnitr se spravnym parametrem / vypoctem.
            return res; // TODO: Uprav, aby Factorial vracel spravnou hodnotu. ne nulu, ale ten faktorial
        }

        static int Fibonacci(int n)
        {
            int ress;
            if (n > 1)
            {
                ress = Fibonacci(n - 2) + Fibonacci(n - 1);
            }
            else
            {
                ress = n;
            }
            // TODO: Urci ukoncovaci podminku pro Fibonacciho a zavolej Fibonacci zevnitr se spravnym parametrem / vypoctem.
            return ress; // TODO: Uprav, aby Fibonacci vracel spravnou hodnotu
            
        }
    }
}

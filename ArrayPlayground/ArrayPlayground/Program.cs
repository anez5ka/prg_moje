using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] num = { 10, 20, 30, 40, 50 };
            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            Console.WriteLine("Výpis for cyklem:");
            foreach (int n in num)
            {
                Console.WriteLine(n);
            }

            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = 0;
            foreach (int n in num)
            {
                sum += n;
            }

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average = sum / num.Length;
            Console.WriteLine($"Průměr: {average}");

            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            //Array.sort(num) -- seradi prvky podle velikosti
            int max = num[0];
            foreach (int n in num)
            {
                if (n > max)
                {
                    max = n;
                }
            }
            Console.WriteLine("Maximum: " + max);

            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = num[0];
            foreach (int n in num)
            {
                if(n < min)
                {
                    min = n;
                }
            }
            Console.WriteLine("Minimum: " + min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int index = Convert.ToInt32(Console.ReadLine());
            if (index < num.Length)
            {
                Console.WriteLine("cislo se zadanym indexem " + num[index]) ;
            }
            else
            {
                Console.WriteLine("cislo nenalezeno");
            }

            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.
            Random rnd = new Random();
            num = new int[100];
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = rnd.Next(0, 10);
                Console.WriteLine($"{(i+1)}. prvek je {num[i]}");
            }

            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];
            for (int i = 0; i < num.Length; i++)
            {
                counts[num[i]]++;
            }
            for (int i = 0;i < counts.Length; i++)
            {
                Console.WriteLine($"{i} se vyskytuje {counts[i]}-krát");
            }
            int test = 0;
            foreach (int n in counts)
            {
                test += n;
            }
            Console.WriteLine($"zkouska: 100 = {test}");

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.

            
            Console.ReadKey();
        }
    }
}

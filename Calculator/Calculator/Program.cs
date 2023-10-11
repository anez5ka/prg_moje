using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Pokud se budes chtit na neco zeptat a zrovna budu pomahat jinde, zkus se zeptat ChatGPT ;) - https://chat.openai.com/
             * 
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou result do konzole
             * 
             * Mozna rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */
            string what;
            char ch;
            int znam;
            int a;
            int b;
            int x = 1;
            int i = 2;
            int v = 0;
            int konec = 0;  //ukonceni, diky teto promenne se kalkulacka nevypne po kazdem vypoctu, ale az uzivatel chce
            double res = 0;

            while (konec == 0)
            {
                what = "a";
                while ((what != "s") && (what != "r") && (what != "n") && (what != "p") && (what != "m") && (what != "q"))
                {
                    Console.WriteLine("vyber: s (soucet), r (rozdil), n (soucin), p (podil), m (zmena soustavy), q (ukoncit program");
                    what = Convert.ToString(Console.ReadLine());
                }
                if (what == "q")
                {
                    konec = 1;
                }
                else
                {
                    Console.WriteLine("napis dve cisla");
                    if (what == "m")
                    {
                        Console.WriteLine("cislo; soustava");
                    }

                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());

                    // soucet
                    if (what == "s")
                    {
                        res = a + b;
                    }
                    //rozdil
                    if (what == "r")
                    {
                        res = a - b;
                    }
                    //nasobek
                    if (what == "n")
                    {
                        res = a * b;
                    }
                    //podil
                    if (what == "p")
                    {
                        Convert.ToDouble(a);
                        res = a / b;
                    }

                    //soustava
                    if (what == "m")
                    {
                        // a je prevadene cislo, b je soustava
                        while (b >= 10 && b <= 1)
                        {
                            Console.WriteLine("soustavu zvol mezi 2 a 9");
                            b = Convert.ToInt32(Console.ReadLine());
                        }
                        while (a > 0)
                        {
                            v = (a % b);
                            res = res + v * x;
                            x = x * 10;
                            a = a / b;
                            if (a == 1)
                            {
                                i--;
                            }
                        }
                    }
                }
                //ukonceni
                if (konec == 1)
                {
                    Console.WriteLine("stiskni libovolnou klavesu pro ukonceni programu");
                }
                else
                {
                Console.WriteLine("vysledek je " + res);
                }
            }

            Console.ReadKey();
        }
    }
}

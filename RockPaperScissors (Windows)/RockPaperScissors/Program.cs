using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jednoduchy program na procviceni podminek a cyklu.
             * 
             * Vytvor program, kde bude uzivatel hrat s pocitacem kamen-nuzky-papir.
             * 
             * Struktura:
             * 
             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy skore obou
             *
             * Opakuj tolikrat, kolik kol chces hrat:
             * {
             *      Dokud uzivatel nezada vstup spravne:
             *      {
             *          - nacitej vstup od uzivatele
             *      }
             *      
             *      - vygeneruj s pomoci rng.Next() nahodny vstup pocitace
             *      
             *      Pokud vyhral uzivatel:
             *      {
             *          - informuj uzivatele, ze vyhral kolo
             *          - zvys skore uzivateli o 1
             *      }
             *      Pokud vyhral pocitac:
             *      {
             *          - informuj uzivatele, ze prohral kolo
             *          - zvys skore pocitaci o 1
             *      }
             *      Pokud byla remiza:
             *      {
             *          - informuj uzivatele, ze doslo k remize
             *      }
             * }
             * 
             * - informuj uzivatele, jake mel skore on/a a pocitac a kdo vyhral.
             */

            // DEKLARACE,

            // P označuje hráče, C označuje počítač
            string p;
            int c;
            int pskore = 0;
            int cskore = 0;
            Random rnd = new Random();
            int VB = 0;  // vitezny bod, pocet bodu nutny k vyhre (hra nebude ukoncena po x kolech, ale az jeden ze souperu dosahne x bodu), zamezi se tak remize

            Console.WriteLine("--- KÁMEN, NŮŽKY, PAPÍR ---");
            Console.WriteLine("");
            Console.WriteLine("Zadej na kolik vítězných bodů se hraje");
            while (VB == 0)
            {
                VB = Convert.ToInt32(Console.ReadLine());
                if (VB <= 0)
                {
                    Console.WriteLine("hodnota musí být větší než 0, zadej znovu");
                }
            }
            while ((VB > cskore) && (VB > pskore))
            {
                p = "x";
                //* 1 = kamen, 2 = nuzky, 3 = papir

                Console.WriteLine("");
                Console.WriteLine("Zadej k (kámen), n (nůžky) nebo p (papír)");
                p = Console.ReadLine();

                if ((p == "k") || (p == "n") || (p == "p"))
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("");
                    c = rnd.Next(1, 4);
                    if (c == 1)
                    {
                        Console.WriteLine("počítač zvolil kámen");
                        Console.WriteLine("");
                        if (p == "k")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("remíza");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else if (p == "n")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("kámen drtí nůžky, bod pro počítač");
                            Console.ForegroundColor = ConsoleColor.White;

                            cskore++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("papír balí kámen, bod pro tebe");
                            Console.ForegroundColor = ConsoleColor.White;
                            pskore++;
                        }
                    }
                    if (c == 2)
                    {
                        Console.WriteLine("počítač zvolil nůžky");
                        Console.WriteLine("");

                        if (p == "k")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("kámen drtí nůžky, bod pro hráče");
                            Console.ForegroundColor = ConsoleColor.White;

                            pskore++;
                        }
                        else if (p == "n")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("remíza");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("nůžky stříhají papír, bod pro počítač");
                            Console.ForegroundColor = ConsoleColor.White;
                            cskore++;
                        }
                    }
                    if (c == 3)
                    {
                        Console.WriteLine("počítač zvolil papír");
                        Console.WriteLine("");
                        if (p == "k")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("papír balí kámen, bod pro počítač");
                            Console.ForegroundColor = ConsoleColor.White;
                            cskore++;
                        }
                        else if (p == "n")
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("nůžky stříhají papír, bod pro hráče");
                            Console.ForegroundColor = ConsoleColor.White;
                            pskore++;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("remíza");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    }
                    Console.WriteLine("");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("---------------------");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine("Nesprávně zadaná hodnota.");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            if (VB == pskore)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"VYHRÁL JSI. Získal jsi {pskore} bodů, počítač získal jen {cskore}.");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"PROHRÁL JSI. Počítač získal {cskore} bodů, ty jsi získal jen {pskore}.");
            }
            Console.ReadKey();  //Aby se nam to hnedka neukoncilo
        }
    }
}

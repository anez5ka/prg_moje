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

            //* P označuje hráče, C označuje počítač
            string p;
            int c;
            int pskore = 0;
            int cskore = 0; 
            Random rnd = new Random();
            //* VB - vitezny bod, pocet bodu nutny k vyhre (hra nebude ukoncena po x kolech, ale az jeden ze souperu dosahne x bodu), zamezi se tak remize
            int VB = 0;
            Console.WriteLine("zadej na kolik vítězných bodů se hraje");
            while (VB == 0) 
            {
                VB = Convert.ToInt32(Console.ReadLine());
                if (VB <= 0)
                {
                    Console.WriteLine("hodnota musí být větší než 0, zadej znovu");
                }
            }
            //*tahle cast se bude opakovat dokud nekdo neziska plny pocet bodu
            while ((VB > cskore) && (VB > pskore))
            { 
            
                p = "x";
                c = rnd.Next(1,4);
                //* 1 = kamen, 2 = nuzky, 3 = papir

                int ano = 0;
                while (ano == 0)
                {
                    Console.WriteLine("zadej k (kamen), n (nuzky) nebo p (papir)");
                    p = Console.ReadLine(); 
                    
                    if ((p == "k") || (p == "n") || (p == "p"))
                    {
                      ano = 1;
                    }
                }
                ano = 0;

                if (c == 1)
                {
                    Console.WriteLine("počítač zvolil kámen");
                    if (p == "k")
                    {
                        Console.WriteLine("remíza");
                    }
                    else if (p == "n") 
                    {
                        Console.WriteLine("kámen drtí nůžky, bod pro počítač");
                        cskore++;
                    }
                    else
                    {
                        Console.WriteLine("papír balí kámen, bod pro tebe");
                        pskore++;
                    }
                    
                    }
                if (c == 2)                 
                {
                    Console.WriteLine("počítač zvolil nůžky");
                    if (p == "k")
                    {
                        Console.WriteLine("kámen drtí nůžky, bod pro hráče");
                        pskore++;
                    }
                    else if (p == "n")
                    {
                        Console.WriteLine("remíza");                            
                    }
                    else
                    {
                        Console.WriteLine("nůžky stříhají papír, bod pro počítač");
                        cskore++;
                    }
                }
            }
            




        



            Console.ReadKey(); //Aby se nam to hnedka neukoncilo
        }
    }
}

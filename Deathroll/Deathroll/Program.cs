using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Internal;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace Deathroll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jednoduchy program na procviceni podminek a cyklu (lze udelat i rekurzi).
             * 
             * Vytvor program, kde bude uzivatel hrat s pocitacem deathroll.
             * Pravidla deathrollu: Prvni hrac navrhne cislo (puvodne ve wowku pocet goldu, o ktere se hraci vsadi) a "rollne" navrhnute cislo, jinak receno je to stejne,
             * jako kdyby si hodil kostkou s tolika stenami, jako je navrhnute cislo. Prvnimu hraci "padne" nejake cislo a druhy hrac si "rollne" padnute cislo.
             * Prohrava ten hrac, kteremu padne 1 jako prvnimu.
             * Ukazka hry: Hraci se shodnou na cisle 1000. Prvni hrac rollne 0-1000, padne mu 920. Druhy hrac rolluje 0-920, padne mu 235 atd. atd. az jednomu z hracu padne 1
             * a ten prohrava.
             * 
             * Struktura:
             * 
             * - nadefinuj promenne, ktere budes potrebovat po celou dobu hry, tedy aktualne rollovane cislo a stav "goldu" uzivatele i pocitace (oba zacinaji treba s 1000 goldu)
             * 
             * - uzivatel zada prvotni sazku, ktera musi byt maximalne tolik, kolik ma goldu
             * 
             * Opakuj dokud nepadne jednomu z hracu 1:
             * {
             *      Pokud je sude kolo:
             *      {
             *          - uzivatel zada hodnotu, kterou rolluje
             *          - kontroluj, ze uzivatel zadal spravnou hodnotu
             *          - uloz rollnute cislo
             *          - vypis uzivateli, co rollnul
             *      }
             *      Pokud je liche kolo:
             *      {
             *          - pocitac rollne nahodne cislo mezi 0 a aktualne rollovanym cislem
             *          - vypis uzivateli, co rollnul pocitac
             *      }
             * }
             * 
             * 
             * - posledni hrajici hrac prohral, protoze mu padla 1 a sazku bere druhy hrac
             * - vypis uzivateli kdo vyhral a stav goldu uzivatele i pocitace
             * 
             * ROZSIRENI:
             * - umozni uzivateli opakovat deathroll dokud ma nejake goldy
             */


            // DEKLARACE

            int pgold = 1000; // player's gold
            int cgold = 1000; // computers's gold
            int bestscore = 0; // nejvyssi dosazeny majetek hrace
            int proll;
            int croll;
            Random rnd = new Random();
            int bet;
            int maxbet;
            int konec = 0; //umoznuje hraci ukoncit hru (ukonci se, kdyz konec == 1)


            //UVOD

            Console.WriteLine($"DEATHROLL. Tvoje zlato:{pgold}. Zlato počítače:{cgold}. Tvůj nejvyšší dosažený majetek: {bestscore}.");
            if (pgold < cgold)
            {
                maxbet = pgold;
            }
            else
            {
                maxbet = cgold;
            }
            Console.WriteLine($"Zvol sázku, nejvyšší možná sázka: {maxbet}.");
            bet = Convert.ToInt32(Console.ReadLine());
            while ((bet > maxbet) || (bet < 2))
            {
                if (bet > maxbet)
                {
                    Console.WriteLine($"kretene, prekrocil jsi nejvyssi moznou sazku, zkus to znovu. Tentokrat nepresahni {maxbet}.");
                }
                if (bet < 2)
                {
                    Console.WriteLine("nejmenší možná sázka, jsou 2 zlata, zkus to znovu");
                }
            }

            //HAZENI

            



        }
    }
}

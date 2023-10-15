// See https://aka.ms/new-console-template for more information
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
int bet;
int maxbet;
int konec = 0;
int vitez;

//UVOD
Console.WriteLine("       ----- DEATHROLL -----");

while (konec == 0)
{
    if (bestscore < pgold)
    {
        bestscore = pgold;
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("");
    Console.WriteLine($"Tvoje zlato: {pgold}. Zlato počítače: {cgold}.");
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine($"Tvůj nejvyšší dosažený majetek: {bestscore}.");

    if (pgold < cgold)
    {
        maxbet = pgold;
    }
    else
    {
        maxbet = cgold;
    }

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("");
    Console.WriteLine($"Zvol sázku, nejvyšší možná sázka: {maxbet}.");
    bet = Convert.ToInt32(Console.ReadLine());
    while ((bet > maxbet) || (bet < 2))
    {
        if (bet > maxbet)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");
            Console.WriteLine($"Nejvyšší možná sázka: {maxbet}!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            bet = Convert.ToInt32(Console.ReadLine());

        }
        if (bet < 2)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");
            Console.WriteLine("Nejmenší možná sázka, jsou 2, zkus to znovu");
            Console.ForegroundColor = ConsoleColor.Yellow;
            bet = Convert.ToInt32(Console.ReadLine());

        }
    }

    //HAZENI

    Console.WriteLine(" ");
    vitez = Droll(bet);
    Console.WriteLine(" ");

    if (vitez == 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"PROHRÁL JSI, přicházíš o {bet} zlata.");
        pgold = pgold - bet;
        cgold = cgold + bet;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"VYHRÁL JSI, získáváš {bet} zlata.");
        pgold = pgold + bet;
        cgold = cgold - bet;

    }

    //POVERTY CHECK

    if (cgold == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("");
        Console.WriteLine("Počítač už nemá žadné zlato.");
        Console.WriteLine("Získavá proto 1000 pro další hru.");

        cgold += 1000;
    }
    if (pgold == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("");
        Console.WriteLine("GAME OVER, nemáš žádné zlato.");
        Console.WriteLine("Získáváš 1000 pro novou hru.");

        pgold += 1000;

    }
    Console.WriteLine(" ");


    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("-----------------------------------");

    //DROLL METHOD

    static int Droll(int n)
    {
        int proll = 0;
        int croll = 0;
        Random rnd = new Random();
        while ((croll != 1) && (proll != 1))
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            proll = rnd.Next(1, (n + 1));
            Console.WriteLine($"Player:    {proll} (1; {n})");
            n = proll;
            if (proll == 1)
            {
                return 1;
            }
            croll = rnd.Next(1, (n + 1));
            Console.WriteLine($"Computer: {croll} (1; {n})");
            n = croll;
            if (croll == 1)
            {
                return 0;
            }
        }
        return 2;
    }





}





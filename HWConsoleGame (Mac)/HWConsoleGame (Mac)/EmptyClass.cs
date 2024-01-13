using System;
using System.Timers;

namespace HWConsoleGame__Mac_
{
	public class EmptyClass
	{
        /*

int a, b, c, d;

string A, B, C, D, AA, BB, CC, DD;

public Character(int a, int b, int c, int d, string A, string B, string C, string D, string AA, string BB, string CC, string DD)
{
    this.a = a;
    this.b = b;
    this.c = c;
    this.d = d;
    this.A = A;
    this.B = B;
    this.C = C;
    this.D = D;
    this.AA = AA;
    this.BB = BB;
    this.CC = CC;
    this.DD = DD;
}
public void Ask()
{
    if (a == 0)
    {
        Write.Long($"a) {A}");
    }
    else if (b == 0)
    {
        Write.Long($"b) {B}");
    }
    else if (c == 0)
    {
        Write.Long($"c) {C}");
    }
    else if (d == 0)
    {
        Write.Long($"d) {D}");
    }
}
public void Answer(int answer)
{
    while (0 == 0)
    {
        if (a == answer)
        {
            Write.Long($"a) {A}");
            a++;
        }
        else if (b == answer)
        {
            Write.Long($"b) {B}");
            b++;
        }
        else if (c == answer)
        {
            Write.Long($"c) {C}");
            c++;
        }
        else if (d == answer)
        {
            Write.Long($"d) {D}");
            d++;
        }
        else
        {
            Write.Long("spatna klavesa");
        }
    }

}
static string ReadOneKey()
{
    string OneKey = Convert.ToString(Console.ReadLine()).Substring(0, 1);
    return OneKey;
}








public static void Start()
{
    int[] array = MakeArray(8);
    Write.Long("zkousej psat A a B");
    int lenght = array.Length;
    while (Game(array) == false)
    {
        Write.Long("je mi lito, zkus znova");
    }
    Write.Long("gratulace");
}
public static int[] MakeArray(int number)
{
    int[] array = new int[number];
    Random rnd = new Random();
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
    return array;
}
public static string ReadOneKey()
{
    string OneKey = Convert.ToString(Console.ReadLine()).Substring(0, 1);
    return OneKey;
}
public static bool Game(int[] array)
{
    int lenght = array.Length;
    string letter;
    for (int i = 0; i < lenght; i++)
    {
        Write.Colour("black");
        letter = ReadOneKey();
        if ((array[i] == 0) && (letter != "a"))
        {
            return false;
        }
        if ((array[i] == 1) && (letter != "b"))
        {
            return false;
        }
    }
    return true;
}






























public EmptyClass()
{

     private static System.Timers.Timer timer;
public static int streak = 0;
public static int win = 0;
internal static void Start()
{
    timer = new System.Timers.Timer(2000);
    timer.Elapsed += Event;
    timer.AutoReset = false;
    timer.Enabled = false;

    while (streak < 10)
    {
        timer.Enabled = true;
        while (win == 0)
        {

        }
    }
    timer.Stop();
}
public static void Event(object source, ElapsedEventArgs e)
{
    win++;
    streak++;
}








int streak = 0;
int delay;
int answer;
int win = 0;
DateTime startTime;
Random random = new Random();
Write.Long("As the error apears on the screen, press any key as fast as possible!");
    Write.Long("To fix your code, you have to press the key ten times in a row, at the right time - not too late…");
    Write.Blank();
    Write.Long("Press any keayboard to start", "gray");
    Write.Border("gray", 80);

   while (streak< 10)
     {




    delay = random.Next(2, 11);
        Thread.Sleep(delay * 1000);
        Write.Blank();
        Write.Long("ERROR!!!");
        Write.Blank();
        startTime = DateTime.Now;
        Console.ReadKey();


        if (DateTime.Now - startTime < TimeSpan.FromSeconds(0.5))
        {
            streak++;
            answer = random.Next(0, 4);
            if (streak == 10)
            {
                Write.Blank();
                Write.Long("Well done, you did it.", "green");
                Write.Border("white", 80);
            }
            switch (answer)
            {
                case 0:
                    Write.Long("You got this.", "green");
                    break;
                case 1:
                    Write.Long("Great job, one step closer!", "green");
                    break;
                case 2:
                    Write.Long("Keep it up!", "green");
                    break;
                case 3:
                    Write.Long("You're doing amazing job!", "green");
                    break;
            }
        }

        else
        {
            Write.Long("You pressed too late. Try again!", "red");
            streak = 0;
        }

    }
} */
    }
}


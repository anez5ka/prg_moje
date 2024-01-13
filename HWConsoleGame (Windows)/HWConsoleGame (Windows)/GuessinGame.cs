using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWConsoleGame__Windows_
{
    internal class GuessingGame
    {
        public static ConsoleKeyInfo key;
        public static void Start()
        {
            int[] array = MakeArray(8);

            Write.Long("Try pressing the left and right arrows, until you get the right order");

            while (Game(array) == false)
            {
                Write.Long("Try again","red");
                Write.Blank();
            }
            Write.Blank();
            Write.Long("Congratulation! You got your variables fixed up.","yellow");
            Write.Border("gray", 80);

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
        public static bool Game(int[] array)
        {
            int lenght = array.Length;

            for (int i = 0; i < lenght; i++)
            {
                key = Console.ReadKey();
                if ((array[i] == 0) && (key.Key == ConsoleKey.LeftArrow))
                {
                    Write.Short("\u2713");
                }
                else if ((array[i] == 1) && (key.Key == ConsoleKey.RightArrow))
                {
                    Write.Short("\u2713");
                }
                else
                {
                    Write.Long("❌");
                    return false;
                }
            }
            return true;
        }
    }
}

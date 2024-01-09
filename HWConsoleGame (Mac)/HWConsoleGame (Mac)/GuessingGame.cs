using System;
using System.Diagnostics.Metrics;

namespace HWConsoleGame__Mac_
{
    internal class GuessingGame
    {
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
    }
}





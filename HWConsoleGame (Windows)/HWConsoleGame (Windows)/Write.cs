using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWConsoleGame__Windows_
{
    internal class Write
    {
        public class Write
    {
        public static void Long(string text, string colour)
        {
            Colour(colour);
            Short(text, colour);
            Console.WriteLine("");
        }
        public static void Long(string text)
        {
            Long(text,"white");
        }
        public static void Short(string text, string colour)
        {
            Colour(colour);
            int max = text.Length;
            for (int i = 0; i < max; i++)
            {
                Thread.Sleep(30);
                Console.Write(text.Substring(i, 1));
            }
        }
        public static void Short(string text)
        {
            Short(text, "white");
        }
        public static void Green(string text)
        {
            Colour("green");
            Console.Write("// ");
            Long(text, "green");
        }
        public static void Border(string colour, int max)
        {
            Colour(colour);
            for (int i = 0; i < max; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("");
        }
        public static void Blank()
        {
            Console.WriteLine("");
        }
        public static void Colour(string colour)
        {
            if (colour == "red")
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }
            if (colour == "gray")
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }
            if (colour == "white")
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (colour == "green")
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
            }
            if (colour == "black")
            {
                Console.ForegroundColor = ConsoleColor.Black;
            }
            if (colour == "pink")
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
            if (colour == "yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }
    }
    }
}

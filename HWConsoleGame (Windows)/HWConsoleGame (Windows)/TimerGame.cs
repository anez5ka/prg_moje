using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace HWConsoleGame__Windows_
{
    internal class TimerGame
    {
        private static System.Timers.Timer timer;
        public static int streak = 0;
        public static int win = 0;
        public static DateTime startTime, endTime;
        public static int time;

        public static void Start()
        {
            Write.Long("As the error apears on the screen, press any key as fast as possible!");
            Write.Long("To fix your code, you have to press the key ten times in a row, at the right time - not too soon or too late");
            Write.Blank();
            Write.Long("Press any key to start", "gray");
            Write.Border("gray", 80);
            Console.ReadKey();

            while(streak < 10)
            {
                Random rnd = new Random();
                time = rnd.Next(1, 7);
                timer = new System.Timers.Timer(time * 1000);
                timer.Elapsed += Event;
                timer.AutoReset = false;
                startTime = DateTime.Now;
                timer.Enabled = true;
                Console.ReadKey();
                endTime = DateTime.Now;
                timer.Stop();

                if (endTime < startTime + TimeSpan.FromSeconds(time))
                {
                    streak = 0;
                    Write.Long("You pressed too soon. Try again!", "red");
                }
                else if (endTime - startTime - TimeSpan.FromSeconds(time) < TimeSpan.FromSeconds(0.8))
                {
                    streak++; 
                    Write.Long("Keep it up!", "green");
                }
                else
                {
                    streak = 0;
                    Write.Long("You pressed too late. Try again!", "red");
                }
            }
            Write.Blank();
            Write.Long("You fixed all those errors. CONGRATULATIONS.", "yellow");
            Write.Border("gray", 80);
        }
        public static void Event(object source, ElapsedEventArgs e)
        {
            Write.Blank();
            Write.Long("ERROR!!!");
            Write.Blank();
        }
    }
}

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
        internal static void Start () 
        {
            timer = new System.Timers.Timer (2000);
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
            timer.Stop ();
        }
        public static void Event(object source, ElapsedEventArgs e)
        {
            win++;
            streak++;
        }
        /*
         * public static void Event(object source, ElapsedEventArgs e)
        {
            Game();
        }
        public static void Game()
        {
            
        }
        */
    }
}

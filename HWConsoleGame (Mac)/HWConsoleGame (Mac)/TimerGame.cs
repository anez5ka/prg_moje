using System;

namespace HWConsoleGame__Mac_
{
    internal class TimerGame
    {
        public static void Start()
        {
            int streak = 0;
            int delay;
            int answer;
            int win = 0;
            DateTime startTime; 
            Random random = new Random();
            Write.Long("As the error apears on the screen, press any key as fast as possible!");
            Write.Long("To fix your code, you have to press the key ten times in a row, at the right time - not too late…");
            /*
             * Write.Blank();
            Write.Long("Press any keayboard to start", "gray");
            Write.Border("gray", 80);
            */
            while (streak < 10)
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
        }
    }
}






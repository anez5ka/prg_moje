using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HWConsoleGame__Mac_;

namespace HWConsoleGame__Windows_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Intro();
            TimerGame.Start();
            Intro2();
            GuessingGame.Start();
            Intro3();
            LabyrinthGame.Start();
            Intro4();

            static void Intro()
            {
                Write.Long("—————————————————\n|               |\n|    CODE();    |\n|               |\n—————————————————\n       |  | \n      ———---");
                Write.Blank();
                Write.Green("Welcome to the game");
                Write.Green("Now, let the fun begin");
                Write.Green("From now on, you are a programmer, and your goal in this simulation is to finish a code you are currently working on. Good luck, fella.");
                Write.Blank();
                Write.Long("—————————————————\n|               |\n|    ERROR!!    |\n|               |\n—————————————————\n       |  | \n      ———---");
                Write.Blank();
                Write.Green("Luckily, your work is almost finished, it’s dark and deep night outside. You wrote your code in one breath, well done, and after hours of work, you finally press the play button, but here comes difficult part.");
                Write.Green("Oh no, the screen shines, but the code is not working. Error. And, unfortunately, it's only up to you, to fix it.");

                Write.Blank();
                Write.Border("gray", 80);
                Write.Blank();
                Write.Green("TODO:");
                Write.Border("yellow", 20);
                Write.Long("GetRidOfTheError();", "yellow");
                Write.Border("yellow", 20);
            }
            static void Intro2()
            {
                Write.Blank();
                Write.Long("—————————————————\n|               |\n|     a ≠ b     |\n|               |\n—————————————————\n       |  | \n      ———---");
                Write.Blank();
                Write.Green("Something is still not working. You've got your variables mixed up.");
                Write.Green("You could try the famous czech method <<pokus omyl>> and try to randomly mix them up again, until you get it right.");
                Write.Blank();
                Write.Green("TODO:");
                Write.Border("yellow", 25);
                Write.Long("GetTheVariablesRight();", "yellow");
                Write.Border("yellow", 25);
            }
            static void Intro3()
            {
                Write.Blank();
                Write.Long("—————————————————\n|               |\n|    SERVER     |\n|       ☹︎       |\n—————————————————\n       |  | \n      ———---");
                Write.Blank();
                Write.Green("Your code is ready, but the servers are not responding.");
                Write.Green("You have to find the server room.");
                Write.Blank();
                Write.Green("TODO:");
                Write.Border("yellow", 25);
                Write.Long("FindTheServerRoom();", "yellow");
                Write.Border("yellow", 25);

            }
            static void Intro4()
            {
                Write.Green(" Great job. You did it. Your Code id done. Here is a kitten as a reward: ");
                Write.Long(" ╱|、\n(˚ˎ 。7  \n |、˜〵          \n じしˍ,)ノ");
            }

            Console.ReadKey();

        }
    }
}



using HWConsoleGame__Mac_;

Intro();
TimerGame.Start();

GuessingGame.Start();

LabyrinthGame newLabyrinth = new LabyrinthGame (0, 2);
newLabyrinth.Start();

static string ReadOneKey()
{
    string OneKey = Convert.ToString(Console.ReadLine()).Substring(0, 1);
    return OneKey;
}
static void Intro()
{
    Write.Green("Welcome to the game");
    Write.Green("Now, let the fun begin");
    Write.Green("From now on, you are a programmer, and your goal in this simulation is to finish a code you are currently working on. Good luck, fella.");
    Write.Green("Luckily, your work is almost finished, it’s dark and deep night outside. You wrote your code in one breath, well done, and after hours of work, you finally press the play button, but here comes difficult part.");
    Write.Green("Oh no, the screen shines, but the code is not working. Error. And, unfortunately, it's only up to you, to fix it.");
    Write.Blank();
    Write.Border("gray", 100);
    Write.Blank();
    Write.Green("TODO:");
    Write.Border("yellow", 20);
    Write.Long("GetRidOfTheError();", "yellow");
    Write.Border("yellow", 20);
}


Console.ReadKey();



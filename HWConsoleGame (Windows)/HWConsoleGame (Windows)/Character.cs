using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWConsoleGame__Windows_
{
    public class Character
    {
        public static int a, b, c, d, e, f, k = 0;
        public static ConsoleKeyInfo key;

        public static void Ask()
        {
            int cycle = 0;
            Write.Long("You've found the server room manager.", "yellow");
            if (f == 0)
            {
                f++;
                Write.Green("Old man, the server room manager, sits tired in his office. You realize as soon, as you see him, that he is not willing to help you.");
                Write.Green("Yet, you ask him, if he could.");
                Write.Green("He looks at you, and lifts eybrows. <<And what for?>> he frowns.");
            }
            else
            {
                Write.Green("He looks at you, and lifts eybrows. He is not happy to see you again. <<Do you have anything else, for me?>> he frowns.");

            }

            while (cycle == 0)
            {
                Write.Long("Choose your reaction:", "gray");
                if (a == 0)
                {
                    Write.Long("(a) <<Do you want something to eat? Maybe you're just hungry.>>", "yellow");
                }
                if (a == 2)
                {
                    Write.Long("(a) <<I have a nice piece of bread for you.>>", "yellow");
                }
                if (b == 0)
                {
                    Write.Long("(b) <<I will give you my soul, if you wish so.>>", "yellow");
                }
                if (c == 0)
                {
                    Write.Long("(c) <<Maybe get over it, and do your job. Help me.", "yellow");
                }
                if (d == 0)
                {
                    Write.Long("(d) <<If you won't help me, the You-know-who will take over the world.", "yellow");
                }
                if (e == 0)
                {
                    Write.Long("(e) Exit Conversation.", "yellow");
                }

                Write.Blank();
                key = Console.ReadKey();
                Write.Blank();


                if ((key.Key == ConsoleKey.A) && (a == 0))
                {
                    a++;
                    Write.Green("He frowns even more. <<Of course, that I am hungry, there is nothing to eat anyway.");
                }
                else if ((key.Key == ConsoleKey.A) && (a == 2))
                {
                    a++;
                    k++;
                    Write.Green("His eyes lits up. <<Mrgh, I haven't ate in so long. Here, have a key to the server room.>>");
                }
                else if (key.Key == ConsoleKey.B && b == 0)
                {
                    b++;
                    Write.Green("As soon, as the words leave your lips, you realize, you already don't have a soul. He looks at you, but says nothing. He knows that too.");
                }
                else if (key.Key == ConsoleKey.C && c == 0)
                {
                    c++;
                    Write.Green("He stands up. You feel hope, for a moment, then he lifts his fist and you get knocked out for few seconds. He doesn't like your attitude.");
                }
                else if (key.Key == ConsoleKey.D && d == 0)
                {
                    Write.Green("He frowns in confusion, apparently, he doesnt know, who You-know-who is.");
                    d++;
                }
                else if (key.Key == ConsoleKey.E && e == 0)
                {
                    cycle++;
                }
                else
                {
                    Write.Long("not a valid key, try again", "red");
                }
            }
        }
        public static void Refrigerator()
        {
            Write.Long("You've found an cook-room.", "yellow");
            Write.Green("There's nothing in there, except fot a table, two chairs and an old refrigerator.");
            if (a == 0)
            {
                Write.Green("In the refrigerator, there is just a piece of really old bread.");
            }
            else if (a == 1)
            {
                a++;
                Write.Green("In the refrigerator, there is just a piece of really old bread, but what's not good enough for you, could be good enough for the hungry server room manager.");
                Write.Long("You've got a piece of really old bread.", "yellow");
            }
        }
        public static void ServerRoom()
        {
            Write.Long("You've found the server room, its locked.");
            if (k == 0)
            {
                Write.Long("The key will probably have the server room manager. Try asking him for help.", "yellow");
            }
            else if (k == 1)
            {
                Write.Long("Fortunately, you have the key.", "yellow");
                Write.Border("gray", 80);
            }
        }

    }
}

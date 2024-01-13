using System;
namespace HWConsoleGame__Mac_
{
    internal class LabyrinthGame
    {
        public static ConsoleKeyInfo move;
        public static int x = 0;
        public static int y = 2;
        public static int win = 0;
        public static int[,] map = { { 0, 1, 6, 1, 0 }, { 0, 1, 0, 1, 7 }, { 2, 1, 1, 1, 0 }, { 0, 3, 0, 1, 5 }, { 0, 0, 0, 4, 0 } };
        public static int width = (map.GetLength(0) - 1);
        public static int height = (map.GetLength(1) - 1);
        public static int stop = 0;
        /*
         { ., 1, 6, 1, . },
         { ., 1, ., 1, 7 },
         { 2, 1, 1, 1, . },
         { ., 3, ., 1, 5 },
         { ., ., ., 4, . }
        */
        public static void Start()
        {
            Write.Long("The hallways are kind of a labyrinth. Move around with arrows.");

            while (win == 0)
            {
                switch (map[x, y])
                {
                    case 1:
                        break;
                    case 2:
                        Write.Green("Secret worm-hole teleported you to the entrance.");
                        Write.Long("You are back at the entrance", "yellow");
                        x = 0;
                        y = 2;
                        break;
                    case 3:
                        Character.Ask();
                        break;
                    case 4:
                        Character.Refrigerator();
                        break;
                    case 5:
                        Write.Long("Ups, a dead-end.", "yellow");
                        break;
                    case 6:
                        Write.Long("You are at the entrance", "yellow");
                        break;
                    case 7:
                        Character.ServerRoom();
                        if (Character.k == 1)
                        {
                            return;
                        }
                        break;
                }
                Write.Blank();
                CheckAround();
                Write.Blank();
                MoveAround();
                if (map[x, y] != 1)
                {
                    Write.Blank();
                }
            }
        }
        static void MoveAround()
        {
            while (stop == 0)
            {
                move = Console.ReadKey();
                if (move.Key == ConsoleKey.UpArrow)
                {
                    if (x < width)
                    {
                        if (map[x + 1, y] > 0)
                        {
                            x++;
                            stop++;
                            Write.Long(" ^^^ ", "gray");
                        }
                    }
                }
                if (move.Key == ConsoleKey.LeftArrow)
                {
                    if (y > 0)
                    {
                        if (map[x, y - 1] > 0)
                        {
                            y--;
                            stop++;
                            Write.Long(" <<< ", "gray");
                        }
                    }
                }
                if (move.Key == ConsoleKey.RightArrow)
                {
                    if (y < height)
                    {
                        if (map[x, y + 1] > 0)
                        {
                            y++;
                            stop++;
                            Write.Long(" >>> ", "gray");
                        }
                    }
                }
                if (move.Key == ConsoleKey.DownArrow)
                {
                    if (x > 0)
                    {
                        if (map[x - 1, y] > 0)
                        {
                            x--;
                            stop++;
                            Write.Long(" ⌄⌄⌄ ", "gray");
                        }
                    }
                }
                if (stop == 0)
                {
                    Write.Long("not a valid key, try again", "red");
                }
            }
            stop--;
        }
        static void CheckAround()
        {
            Write.Short("you can go:", "gray");
            if (x < width)
            {
                if (map[x + 1, y] > 0)
                {
                    Write.Short(" forward(^)");
                }
            }
            if (y > 0)
            {
                if (map[x, y - 1] > 0)
                {
                    Write.Short(" left(<)");
                }
            }
            if (y < height)
            {
                if (map[x, y + 1] > 0)
                {
                    Write.Short(" right(>)");
                }
            }
            if (x > 0)
            {
                if (map[x - 1, y] > 0)
                {
                    Write.Short(" backward(⌄)");
                }
            }
        }
    }
}


using System;
namespace HWConsoleGame__Mac_
{
    internal class LabyrinthGame
    {
        public int x, y;
        public int win = 0;
        public int[,] map = { { 0, 1, 6, 1, 0},
            {0, 1, 0, 1, 0 },
            {2, 1, 1, 1, 0 },
            { 0, 3, 0, 1, 5 },
            { 0, 0, 0, 4, 0 } };

        public LabyrinthGame(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Start()
        {
            Write.Long("vítej, mas tu bludiste bla bla, pohybuj se pomoci awsd");
            string move;
            int width = (map.GetLength(0) - 1);
            int height = (map.GetLength(1) - 1);
            int stop = 0;
            while (win == 0)
            {
                switch (map[x, y])
                {
                    case 1:
                        break;
                    case 2: // portal
                        Write.Long("portal te posunul zpet na zacatek");
                        x = 0;
                        y = 2;
                        break;
                    case 3: // hladovy hlidac
                        break;
                    case 4: // lednice
                        break;
                    case 5: // slepa
                        break;
                    case 6: // zacatek
                        Write.Long("Jsi na zacatku");
                        break;
                }
                CheckAround(x, y, map);
                while (stop == 0)
                {
                    move = ReadOneKey();
                    if (move == "w")
                    {
                        if (x < width)
                        {
                            if (map[x + 1, y] > 0)
                            {
                                x++;
                                stop++;
                            }
                        }
                    }
                    if (move == "a")
                    {
                        if (y > 0)
                        {
                            if (map[x, y - 1] > 0)
                            {
                                y--;
                                stop++;
                            }
                        }
                    }
                    if (move == "d")
                    {
                        if (y < height)
                        {
                            if (map[x, y + 1] > 0)
                            {
                                y++;
                                stop++;
                            }
                        }
                    }
                    if (move == "s")
                    {
                        if (x > 0)
                        {
                            if (map[x - 1, y] > 0)
                            {
                                x--;
                                stop++;
                            }
                        }
                    }
                    Write.Long(("" + x + y));
                    if (stop == 0)
                    {
                        Write.Long("neplatna klavesa, zkus znovu");
                    }
                }
                stop--;
                move = "";
            }

        }
        static void CheckAround(int x, int y, int[,] map)
        {
            Write.Long("jsi na " + x + y);
            Write.Short("muzes odbocit...");
            int width = (map.GetLength(0) - 1);
            int height = (map.GetLength(1) - 1);
            if (x < width)
            {
                if (map[x + 1, y] > 0)
                {
                    Write.Short("dopredu");
                }
            }
            if (y > 0)
            {
                if (map[x, y - 1] > 0)
                {
                    Write.Short("doleva");
                }
            }
            if (y < height)
            {
                if (map[x, y + 1] > 0)
                {
                    Write.Short("doprava");
                }
            }
            if (x > 0)
            {
                if (map[x - 1, y] > 0)
                {
                    Write.Short("dozadu");
                }
            }
        }
        static string ReadOneKey()
        {
            string OneKey = Convert.ToString(Console.ReadLine()).Substring(0, 1);
            return OneKey;
        }
    }
}


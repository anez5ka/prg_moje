using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DECLARATION
            int[,] ArrayA = new int[1, 1]; //ArrayA is default matrix
            int[,] ArrayB = new int[1, 1]; //ArrayB is for operations that require 2 metrixes
            int widthArray, heightArray;
            int ArrayRandom, ArrayRandomSize = 0;
            int Operation;

            //SHORTCUT FOR TEST RUN
            //makes 5x10 matrix and tries out all possible operations
            /*
            widthArray = 5;
            heightArray = 10;
            ArrayRandom = 0;
            if (ArrayRandom == 1)
            {
                ArrayRandomSize = 100;
            }
            ArrayA = ResizeAndFillArray(widthArray, heightArray, ArrayRandom, ArrayRandomSize);
            WriteOut(ArrayA);
            for (int i = 0; i < 3; i++)
            {
                CaseZero();
                WriteOut(ArrayA);
            }
            for (int i = 0; i < 2; i++)
            {
                CaseOne();
                WriteOut(ArrayA);
            }
            for (int i = 0; i < 1; i++)
            {
                CaseTwo();
                WriteOut(ArrayB);
                WriteOut(ArrayA);
            }
            for (int i = 0; i < 1; i++)
            {
                CaseThree();
                WriteOut(ArrayB);
                WriteOut(ArrayA);
            }
            for (int i = 0; i < 3; i++)
            {
                CaseFour();
                WriteOut(ArrayA);
            }
            for (int i = 0; i < 1; i++)
            {
                CaseFive();
                WriteOut(ArrayA);
            }
            for (int i = 0; i < 1; i++)
            {
                CaseSix();
                WriteOut(ArrayB);
                WriteOut(ArrayA);
            }
            for (int i = 0; i < 1; i++)
            {
                CaseSeven();
                WriteOut(ArrayB);
                WriteOut(ArrayA);
            }
            for (int i = 0; i < 1; i++)
            {
                CaseEight();
                WriteOut(ArrayA);
            }
            */


            //MAIN
            ArrayAsk();
            ArrayA = ResizeAndFillArray(widthArray, heightArray, ArrayRandom, ArrayRandomSize);
            WriteOut(ArrayA);
            while (1 == 1) //makes infinite loop
            {
                Console.WriteLine("Kterou operaci chcete provádět?");
                Console.WriteLine("prohození dvou prvků (0), otáčení pořadí prvků na diagonálách (1), přičíst (2) nebo odečíst další matici (3), vynásobení matice, sloupce či řádku číslem (4), transpozice (5), porovnat s další maticí a vybrat maximum (6) nebo minumum (7), úplně předefinovat současnou (8)");
                Operation = Convert.ToInt32(Console.ReadLine());
                part();
                switch (Operation)
                {
                    case 0: // switch two elements
                        CaseZero();
                        break;
                    case 1: // switching order of numbers on diagonals
                        CaseOne();
                        break;
                    case 2: // add another metrix
                        CaseTwo();
                        WriteOut(ArrayB);
                        break;
                    case 3: // subb another metrix
                        CaseThree();
                        WriteOut(ArrayB);
                        break;
                    case 4: // multiply by num
                        CaseFour();
                        break;
                    case 5: // transposition
                        break;
                    case 6:
                        CaseSix();
                        WriteOut(ArrayB);
                        break;
                    case 7:
                        CaseSeven();
                        WriteOut(ArrayB);
                        break;
                    default: //redefines
                        CaseEight();
                        break;
                }
                WriteOut(ArrayA);
            }

            //ASKS FOR ARRAY PARAMETRICS
            void ArrayAsk()
            {
                Console.WriteLine("Zvolte velikost matice");
                Console.WriteLine("Zvolte počet sloupců (délku jednoho řádku)");
                widthArray = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Zvolte počet řádků (délku jednoho sloupce)");
                heightArray = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Chcete naplnit matici vzestupnými (0) nebo náhodnými (1) čísly?");
                ArrayRandom = Convert.ToInt32(Console.ReadLine());
                if (ArrayRandom == 1)
                {
                    Console.WriteLine("Jaké nejvyšší číslo se v matici může vyskytovat");
                    ArrayRandomSize = (Convert.ToInt32(Console.ReadLine()) + 1);
                }
            }

            //RESIZES ARRAY AND FILLS WITH NUMBERS
            int[,] ResizeAndFillArray(int width, int height, int random, int max)
            {
                int[,] Array = new int[width, height];
                Random rnd = new Random();
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        if (random == 1)
                        {
                            Array[i, j] = rnd.Next(0, max);
                        }
                        else
                        {
                            Array[i, j] = (width * j + i + 1);
                        }
                    }
                }
                return Array;
            }

            //WRITES OUT THE ARRAY
            void WriteOut(int[,] Array)
            {
                part();
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    for (int i = 0; i < Array.GetLength(0); i++)
                    {
                        Console.Write(Array[i, j] + " ");
                        if ((Array[i, j] / 10) < 1)
                        {
                            Console.Write(" ");
                        }
                        /*
                        if ((Array[i, j] / 100) < 1)
                        {
                            Console.Write(" ");
                        }
                        */
                    }
                    Console.WriteLine();
                }
                part();
            }

            //0 SWITCHES TWO NUMBERS/COLUMNS/ROWS ON GIVEN COORDINATES
            void CaseZero()
            {
                int num;
                int xA, yA, xB, yB = 0;
                int OperationOne = 0;
                Console.WriteLine("Chcete prohodit dvě čísla (0), sloupce (1), nebo řádky(2)?");
                OperationOne = Convert.ToInt32(Console.ReadLine());
                switch (OperationOne)
                {
                    case 0:
                        Console.WriteLine("Zadejte souřadnice prvního čísla.");
                        Console.WriteLine("Sloupec:");
                        xA = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Console.WriteLine("Řádek:");
                        yA = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Console.WriteLine("Zadejte souřadnice druhého čísla.");
                        Console.WriteLine("Sloupec:");
                        xB = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Console.WriteLine("Řádek:");
                        yB = (Convert.ToInt32(Console.ReadLine()) - 1);
                        num = ArrayA[xA, yA];
                        ArrayA[xA, yA] = ArrayA[xB, yB];
                        ArrayA[xB, yB] = num;
                        break;
                    case 1:
                        Console.WriteLine("Zadejte číslo prvního sloupce.");
                        xA = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Console.WriteLine("Zadejte číslo druhého sloupce.");
                        xB = (Convert.ToInt32(Console.ReadLine()) - 1);
                        for (int i = 0; i < ArrayA.GetLength(1); i++)
                        {
                            num = ArrayA[xA, i];
                            ArrayA[xA, i] = ArrayA[xB, i];
                            ArrayA[xB, i] = num;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Zadejte číslo prvního řádku.");
                        yA = (Convert.ToInt32(Console.ReadLine()) - 1);
                        Console.WriteLine("Zadejte číslo druhého řádku.");
                        yB = (Convert.ToInt32(Console.ReadLine()) - 1);
                        for (int j = 0; j < ArrayA.GetLength(0); j++)
                        {
                            num = ArrayA[j, yA];
                            ArrayA[j, yA] = ArrayA[j, yB];
                            ArrayA[j, yB] = num;
                        }
                        break;
                    default:
                        break;
                }
            }

            //1 SWITCHES THE NUMBERS ORDER ON DIAGONALL
            void CaseOne()
            {
                int main, size;
                if (ArrayA.GetLength(0) < ArrayA.GetLength(1))
                {
                    size = (ArrayA.GetLength(0) - 1);
                }
                else
                {
                    size = (ArrayA.GetLength(1) - 1);
                }
                Console.WriteLine($"size = {size}");
                int[] Diagonall = new int[size + 1];
                Console.WriteLine("Chcete prohodit hlavní (0) nebo vedlejší (1) diagonálu?");
                main = (Convert.ToInt32(Console.ReadLine()));
                if (main == 0)
                {
                    for (int i = 0; i <= size; i++)
                    {
                        Diagonall[size - i] = ArrayA[i, i];
                    }
                    for (int i = 0; i <= size; i++)
                    {
                        ArrayA[i, i] = Diagonall[i];
                    }
                }
                else
                {
                    for (int i = 0; i <= size; i++)
                    {
                        Diagonall[size - i] = ArrayA[i, size - i];
                    }
                    for (int i = 0; i <= size; i++)
                    {
                        ArrayA[i, size - i] = Diagonall[i];
                    }
                }
            }

            //2 ADDS ANOTHER METRIX
            void CaseTwo()
            {
                int x, y;
                Console.WriteLine("Jakou matici chceš přičíst?");
                ArrayAsk();
                ArrayB = ResizeAndFillArray(widthArray, heightArray, ArrayRandom, ArrayRandomSize);
                if (ArrayA.GetLength(0) < ArrayB.GetLength(0))
                {
                    x = ArrayA.GetLength(0);
                }
                else
                {
                    x = ArrayB.GetLength(0);
                }
                if (ArrayA.GetLength(1) < ArrayB.GetLength(1))
                {
                    y = ArrayA.GetLength(1);
                }
                else
                {
                    y = ArrayB.GetLength(1);
                }
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        ArrayA[i, j] = ArrayA[i, j] + ArrayB[i, j];
                    }
                }
                Console.WriteLine("Druhá matice:");
                WriteOut(ArrayB);
                Console.WriteLine("Výsledná matice:");
            }

            //3 SUBS ANOTHER METRIX
            void CaseThree()
            {
                int x, y;
                Console.WriteLine("Jakou matici chceš přičíst?");
                ArrayAsk();
                ArrayB = ResizeAndFillArray(widthArray, heightArray, ArrayRandom, ArrayRandomSize);
                if (ArrayA.GetLength(0) < ArrayB.GetLength(0))
                {
                    x = ArrayA.GetLength(0);
                }
                else
                {
                    x = ArrayB.GetLength(0);
                }
                if (ArrayA.GetLength(1) < ArrayB.GetLength(1))
                {
                    y = ArrayA.GetLength(1);
                }
                else
                {
                    y = ArrayB.GetLength(1);
                }
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        ArrayA[i, j] = ArrayA[i, j] - ArrayB[i, j];
                    }
                }
            }

            //4 MULTIPLIES ELEMENT OR THE WHOLE ARRAY BY A NUMBER
            void CaseFour()
            {
                int OperationFour, NumCaseFour, NumOfElementFour = 0;
                Console.WriteLine("Chceš vynásobit celou matici (0) sloupec (1) nebo řadu (2)?");
                OperationFour = Convert.ToInt32(Console.ReadLine());
                if (OperationFour != 0)
                {
                    Console.WriteLine("Kolikátý sloupec / řadu chceš vynásobit?");
                    NumOfElementFour = (Convert.ToInt32(Console.ReadLine()) - 1); ;
                }
                Console.WriteLine("Zadej číslo kterým chceš násobit");
                NumCaseFour = Convert.ToInt32(Console.ReadLine());
                if (OperationFour == 0)
                {
                    for (int i = 0; i < ArrayA.GetLength(0); i++)
                    {
                        for (int j = 0; j < ArrayA.GetLength(1); j++)
                        {
                            ArrayA[i, j] = (ArrayA[i, j] * NumCaseFour);
                        }
                    }
                }
                else if (OperationFour == 1)
                {
                    for (int j = 0; j < ArrayA.GetLength(1); j++)
                    {
                        ArrayA[NumOfElementFour, j] = (ArrayA[NumOfElementFour, j] * NumCaseFour);
                    }
                }
                else
                {
                    for (int i = 0; i < ArrayA.GetLength(0); i++)
                    {
                        ArrayA[i, NumOfElementFour] = (ArrayA[i, NumOfElementFour] * NumCaseFour);
                    }
                }
            }

            //5 TRANSPOSITION
            void CaseFive()
            {
                ArrayB = ResizeAndFillArray(ArrayA.GetLength(1), ArrayA.GetLength(0), 0, 0);
                for (int i = 0; i < ArrayA.GetLength(0); i++)
                {
                    for (int j = 0; j < ArrayA.GetLength(1); j++)
                    {
                        ArrayB[j, i] = ArrayA[i, j];
                    }
                }
                ArrayA = ArrayB;
            }

            //6 COMPARES TO ANOTHER MATRIX, CHOOSES MAXIMUM
            void CaseSix()
            {
                int x, y;
                Console.WriteLine("S jakou matici chceš porovnat?");
                ArrayAsk();
                ArrayB = ResizeAndFillArray(widthArray, heightArray, ArrayRandom, ArrayRandomSize);
                if (ArrayA.GetLength(0) < ArrayB.GetLength(0))
                {
                    x = ArrayA.GetLength(0);
                }
                else
                {
                    x = ArrayB.GetLength(0);
                }
                if (ArrayA.GetLength(1) < ArrayB.GetLength(1))
                {
                    y = ArrayA.GetLength(1);
                }
                else
                {
                    y = ArrayB.GetLength(1);
                }
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        if (ArrayB[i, j] > ArrayA[i, j])
                        {
                            ArrayA[i, j] = ArrayB[i, j];
                        }
                    }
                }
            }

            //7 COMPARES TO ANOTHER MATRIX, CHOOSES MAXIMUM
            void CaseSeven()
            {
                int x, y;
                Console.WriteLine("S jakou matici chceš porovnat?");
                ArrayAsk();
                ArrayB = ResizeAndFillArray(widthArray, heightArray, ArrayRandom, ArrayRandomSize);
                if (ArrayA.GetLength(0) < ArrayB.GetLength(0))
                {
                    x = ArrayA.GetLength(0);
                }
                else
                {
                    x = ArrayB.GetLength(0);
                }
                if (ArrayA.GetLength(1) < ArrayB.GetLength(1))
                {
                    y = ArrayA.GetLength(1);
                }
                else
                {
                    y = ArrayB.GetLength(1);
                }
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        if (ArrayB[i, j] < ArrayA[i, j])
                        {
                            ArrayA[i, j] = ArrayB[i, j];
                        }
                    }
                }
            }

            //8 REDEFINE THE METRIX
            void CaseEight()
            {
                ArrayAsk();
                ArrayA = ResizeAndFillArray(widthArray, heightArray, ArrayRandom, ArrayRandomSize);
            }

            //GRAPHIC ELEMENT THAT SEPARATES PARTS OF CONSOLE TEXT
            void part()
            {
                Console.WriteLine("  ------------------");
            }
        }
    }
}

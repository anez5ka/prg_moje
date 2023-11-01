using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            int[,] board = new int[5, 5];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i,j] = (i*5+j+1);
                    if (board[i,j] < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(board[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 2;
            for (int j = 0; j < board.GetLength(1); j++)
            {
                Console.Write(board[nRow, j] + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 2;
            for (int i = 0; i < board.GetLength(1); i++)
            {
                Console.Write(board[i, nColumn] + " ");
            }

            Console.WriteLine();

            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            int xFirst, yFirst, xSecond, ySecond;
            xFirst = 0;
            yFirst = 0;
            xSecond = 4;
            ySecond = 4;

            int first = board[xFirst, yFirst];
            board[xFirst, yFirst] = board[xSecond, ySecond];
            board[xSecond, ySecond] = first;
           
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }

            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 1;

            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            int nColSwap = 0;
            int mColSwap = 1;

            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.
            int[] MainDiagonall = new int[board.GetLength(0)];
            Console.WriteLine("Diagonala:");
            for (int i = 0;i < board.GetLength(0); i++)
            {
                MainDiagonall[i] = board[i, i];
            }


            for (int i = 0; i < MainDiagonall.Length; i++)
            {
                Console.Write(MainDiagonall[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                board[i, i] = MainDiagonall[4 - i];
            }

            // vypis
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] < 10)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.

            //pokud je jedna matice mensii? musi pocitat s tim
            //VYBER VETSI CISLO, PRUMĚR, MENSI CISLO
            // POUZIVAT BREAK CASE

            Console.ReadKey();
        }
    }
}

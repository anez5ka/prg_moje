using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphsPlayground
{
    internal class Node
    {
        int[] neighbour;
        int name;
        public Node(int name, int[] neighbour) 
        { 
            neighbour=Sort(this.neighbour);
            name = this.name;
            
        }
        public int[] Add(int[] neighbour, int[] add)
        {
            int[] addedArray = new int[neighbour.Length+add.Length];
            for (int i = 0; i < neighbour.Length + add.Length; i++)
            {
               if (i < neighbour.Length)
                {
                    addedArray[i] = neighbour[i];
                }
               else
                {
                    addedArray[i] = add[i - neighbour.Length];
                }
            }
            return Sort(addedArray);
        }
        public int[] Sort(int[] neighbour)
        {
            int[] sortedArray = (int[])neighbour.Clone();
            int number;
            int index;
            for (int i = 1; i < sortedArray.Length; i++)
            {
                number = sortedArray[i];
                index = i;
                for (int j = i; j >= 0; j--)
                {
                    if (number < sortedArray[j])
                    {
                        index = j;
                    }
                }
                for (int j = i; j > index; j--)
                {
                    sortedArray[j] = sortedArray[j - 1];
                }
                sortedArray[index] = number;
            }
            return sortedArray;
        }
    }
}

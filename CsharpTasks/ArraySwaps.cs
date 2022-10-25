using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTasks
{
    class ArraySwaps
    {
       
        public static int[] reversedArray(int[] array)

        {
            int n = array.Length;
            int[] emptyArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                emptyArray[i] = array[n - i - 1];
            }
            return emptyArray;


        }

    }
}

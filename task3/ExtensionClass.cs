using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    static class ExtensionClass
    {
        public static int[] SortUp(this int[] array)
        {
            int temp;
            for (int i = 1; i < array.Length; i++)
                for (int j = 0; j < array.Length - i; j++)
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }

            return array;
        }
    }
}

using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 6, 3, 9, 13, 16, 3, 2, 7, 11, 20 };
            array = array.SortUp();
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}

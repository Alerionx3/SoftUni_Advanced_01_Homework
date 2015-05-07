using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int p = i+1; p < array.Length-1; p++)
                {
                        if (array[i] > array[p])
                        {
                            int tmp = array[i];
                            array[i] = array[p];
                            array[p] = tmp;
                        }
                }
            }
            foreach (int a in array)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }
    }
}

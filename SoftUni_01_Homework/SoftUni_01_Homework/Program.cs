using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_01_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            int[] array=new int [input.Length];
            for (int i=0;i<input.Length;i++)
            {
                array[i] = int.Parse(input[i]);
            }

            // Array.Sort(array); easier way

            for (int i = 0; i < array.Length; i++) // Bubble method
			{
			    for (int p = 0; p < array.Length-1; p++)
                {
                    if (array[p]>array[p+1])
                    {
                        int tmp=array[p];
                        array[p]=array[p+1];
                        array[p+1]=tmp;
                    }
                }
            }

            foreach (int a in array)
            {
                Console.Write(a + " ");
            }
        }
    }
}

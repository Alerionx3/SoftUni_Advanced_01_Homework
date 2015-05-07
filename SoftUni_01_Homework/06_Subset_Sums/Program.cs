using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Subset_Sums
{
    internal class Program
    {
        private static bool solution = false;

        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            List<int> list = new List<int>();
            Check(0, list,n,array);
            if (!solution)
            {
                Console.WriteLine("No matching subsets.");
            }
        }

        static void Check(int index, List<int> list,int n, int [] array)
        {
            if (list.Sum() == n && list.Count > 0) 
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", list), n);
                solution = true; 
            }
            for (int i = index; i < array.Length; i++)
            {
                list.Add(array[i]);
                Check(i + 1, list,n,array);
                list.RemoveAt(list.Count - 1); 
            }
        }
    }
}
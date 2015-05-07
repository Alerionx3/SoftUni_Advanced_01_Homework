using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Sorted_Subset_Sums
{
    internal class Program
    {
        private static List<List<int>> subsets = new List<List<int>>();
        private static bool solution = false;

        private static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i]);
            }
            Array.Sort(array);
            List<int> subset = new List<int>();
            MakeSubset(0, subset, N, array);
            var sorted = subsets.OrderBy(x => x.Count);
            foreach (var item in sorted)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", item), N);
            }
            if (!solution) 
                Console.WriteLine("No matching subsets.");
        }

        private static void MakeSubset(int index, List<int> subset,int N,int[] array)
        {
            if (subset.Sum() == N && subset.Count > 0)
            {
                subsets.Add(new List<int>(subset));
                solution = true;
            }
            for (int i = index; i < array.Length; i++)
            {
                subset.Add(array[i]);
                MakeSubset(i + 1, subset, N, array);
                subset.RemoveAt(subset.Count - 1);
            }
        }
    }
}
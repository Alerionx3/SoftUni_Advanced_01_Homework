using System;
using System.Collections.Generic;

namespace _09_Stuck_Numbers
{
    class Program
    {
        static List<string> listGet = new List<string>(); 
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int [] inputInts=new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                inputInts[i] = int.Parse(input[i]);
            }
            FindCombinations(n, inputInts);
        }

        static void FindCombinations(int n, int[] inputInts)
        {
            bool noSolution = true;
            int counterEndAll = 0;
            for (int i = 0; i < inputInts.Length; i++) // Get all combinations
            {
                for (int j = 1; j < inputInts.Length; j++)
                {
                    if (i == j || inputInts[i] == inputInts[j])
                    {
                        continue;
                    }
                        listGet.Add(inputInts[i].ToString() + "|" + inputInts[j].ToString());
                        counterEndAll++;
                }
            }
            Array.Reverse(inputInts);
            for (int i = 0; i < inputInts.Length; i++)// Get all reversed combinations
            {
                for (int j = 1; j < inputInts.Length; j++)
                {
                    if (i == j || inputInts[i]==inputInts[j])
                    {
                        continue;
                    }
                    listGet.Add(inputInts[i].ToString() + "|" + inputInts[j].ToString());
                }

            }
            for (int i = 0; i < counterEndAll; i++) //check
            {
                for (int j = counterEndAll; j < listGet.Count; j++)
                {
                    if (listGet[i].Replace("|", "") == listGet[j].Replace("|", "") && (listGet[i]!=listGet[j]))
                    {
                       Console.WriteLine(listGet[i]+"=="+listGet[j]);
                        noSolution = false;
                    }
                }   
            }

            if (noSolution)
            {
                Console.WriteLine("No");
            }
        }
    }
}

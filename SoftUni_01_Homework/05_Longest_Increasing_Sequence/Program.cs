using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Longest_Increasing_Sequence
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            List<string> longest=new List<string>();
            string tmp = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (i != 0)
                {
                    if (int.Parse(input[i]) > int.Parse(input[i - 1]))
                    {
                        Console.Write(input[i] + " ");
                        tmp += input[i] + " ";
                    }
                    else
                    {
                        longest.Add(tmp);
                        tmp = " ";
                        Console.WriteLine();
                        Console.Write(input[i] + " ");
                        tmp += input[i]+" ";
                    }
                }
                else
                {
                    Console.Write(input[i] + " ");
                    tmp += input[i] + " ";

                }
            }
            Console.WriteLine();
            string output = "";
            for (int i = 1; i < longest.Count; i++)
            {
                if (longest[i].Length > longest[i - 1].Length)
                {
                    output = longest[i];
                }
            }
            //string output=longest.OrderByDescending(x => x.Length).First();
            Console.WriteLine("Longest: " + output);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Sequences_of_Equal_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                if (i != 0)
                {
                    if (input[i]==input[i-1])
                    {
                        Console.Write(input[i]+" ");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.Write(input[i]+" ");
                    }
                }
                else
                {
                    Console.Write(input[i] + " ");
                }
            }

            Console.WriteLine();

        }
    }
}

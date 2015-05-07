using System;
using System.Collections.Generic;

namespace _08_Lego_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list=new List<string>();
            for (int i = 0; i < n*2; i++)
            {
                string[] tmp = (Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries));
                string tmp2 = "";
                if (i >= n)
                {
                    for (int j = tmp.Length-1; j >= 0; j--)
                    {
                        tmp2+=tmp[j];
                    }
                }
                else
                {
                    for (int j = 0; j < tmp.Length; j++)
                    {
                        tmp2 += tmp[j];
                    }
                }
                list.Add(tmp2);
            }
            Check(list,n);
        }

        static void Check(List<string> list,int n )
        {
            bool fit = true;
            int compare=list[0].Length + list[list.Count/2].Length;
            int counter = 0;
            string[] output = new string[list.Count/2];
            for (int i = 0; i < list.Count/2; i++)
            {
                if (list[i].Length + list[list.Count / 2 + counter].Length != compare)
                {
                    fit = false;
                    break;
                }
                output[i] += list[i] + list[list.Count/2 + counter];
                counter++;
            }
            if (fit)
            {
                for (int i = 0; i < output.Length; i++)
                {
                    Console.Write("[");
                    for (int j = 0; j < output[i].Length; j++)
                    {
                        if (j == output[i].Length - 1)
                        {
                            Console.Write(output[i][j]);
                        }
                        else
                        {
                            Console.Write(output[i][j] + ", ");

                        }
                    }
                    Console.WriteLine("]");
                }
            }
            else
            {
                int outCounter = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    outCounter += list[i].Length;
                }
                Console.WriteLine("The total number of cells is: "+outCounter);
            }
        }
    }
}

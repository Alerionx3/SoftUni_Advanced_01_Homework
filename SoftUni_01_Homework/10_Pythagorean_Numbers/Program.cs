using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Pythagorean_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int [] inputNumbers=new int[n];
            List<string> tmp=new List<string>();
            bool foundSolution = false;
            for (int i = 0; i < n; i++)
            {
                inputNumbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < inputNumbers.Length; i++)
            {
                for (int j = 0; j < inputNumbers.Length; j++)
                {
                    string check = j.ToString()+"&"+i.ToString();
                    if (!tmp.Contains(check))
                    {
                        for (int k = 0; k < inputNumbers.Length; k++)
                        {
                            if (Math.Pow(inputNumbers[i], 2) + Math.Pow(inputNumbers[j], 2) == Math.Pow(inputNumbers[k], 2))
                            {
                                Console.WriteLine("{0}*{0} + {1}*{1} = {2}*{2}", inputNumbers[i], inputNumbers[j], inputNumbers[k]);
                                tmp.Add(i + "&" + j);
                                foundSolution = true;
                            }
                        }

                    }
                }
            }
            if (!foundSolution)
            {
                Console.WriteLine("No");
            }
        }
    }
}

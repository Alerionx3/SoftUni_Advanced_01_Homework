using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Categorize_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<double> floating = new List<double>();
            List<int> round = new List<int>();

            int roundCounter=0;
            int floatCounter=0;

            for (int i = 0; i < input.Length; i++)
            {
                double tmp = double.Parse(input[i]);

                if (tmp%1==0)
                {
                    round.Add(Convert.ToInt32(Math.Round(tmp)));
                    roundCounter++;
                }
                else
                {
                    floating.Add(double.Parse(input[i]));
                    floatCounter++;
                }
            }
            

            Console.Write("[ ");
            foreach (double a in floating)
            {
                if (a != 0) Console.Write(a + ", ");
            }
            Console.Write("]-> min: {0}, max: {1}, sum: {2}, avg: {3}",floating.Min(),floating.Max(),floating.Sum(),Math.Round(floating.Average(),2));
            Console.WriteLine();

            Console.Write("[ ");
            foreach (int a in round)
            {
                if (a!=0)
                Console.Write(a + ", ");
            }
            Console.Write("]-> min: {0}, max: {1}, sum: {2}, avg: {3}", round.Min(), round.Max(), round.Sum(), Math.Round(round.Average(),2));

        }

    }
}

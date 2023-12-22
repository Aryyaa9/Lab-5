using System;
using System.IO;
using System.Linq;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string path = "../../../numsTask3.txt";

            using (StreamReader reader = new StreamReader(path))
            {
                string str = reader.ReadToEnd();

                int[] nums = str.Split(' ').Select(int.Parse).ToArray();

                int min = nums.Min();

                double sum = 0; 
                double i = 0;
                foreach (var el in nums)
                {
                    if (el == min)
                    {
                        break;
                    }
                    else
                    {
                        sum += el;
                        i++;
                    }
                }

                Console.WriteLine("Average:" + (sum / i));
            }
        }
    }
}
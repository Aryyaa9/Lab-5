using System;
using System.IO;
using System.Linq;

namespace ConsoleApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            string path = "../../../numsTask2.txt";
            using (StreamReader reader = new StreamReader(path))
            {

                string str = reader.ReadToEnd();

                double[] nums = str.Split(';').Select(double.Parse).ToArray();


                using (StreamWriter writer = new StreamWriter(path))
                {
                    Array.Sort(nums);

                    string str2 = String.Join(";", nums);

                    writer.Write(str2);
                }
            }
        }
    }
}
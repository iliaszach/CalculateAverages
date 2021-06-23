using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAverages
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[] { 5,10 };
            Console.WriteLine(GetAverage(marks));
        }
        
        public static int GetAverage1(int[] marks)
        {
            return marks.Sum() / marks.Length;
        }
        public static int GetAverage(int[] marks)
        {
            var average = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                average += marks[i];
            }
            average = average / marks.Length;
            return average;
        }
    }
}

using System.Data.SqlClient;
using System;

namespace CSExercises
{
    public class Ex40
    {
        public static void Main(string[] args)
        {
            int Num;
            double SqRoot;
            Console.WriteLine("This programme is to show the square root of integers between 1-25");
            Console.WriteLine("Number\t\tSQT");
            for (Num = 1; Num <= 25; Num++)
            {
                SqRoot = SQT(Num);
                Console.WriteLine("{0}\t\t{1:0.000}", Num, SqRoot);
            }
        }

        public static double SQT(int y)
        {
            double Sqrt;
            Sqrt = Math.Sqrt(y);
            return Sqrt;
        }
    }
}
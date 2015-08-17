using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double i;
            Console.WriteLine("NO    INVERSE    SQUARE ROOT     SQUARE\n");
            Console.WriteLine("------------------------------------------------\n");
            for(i=1;i<=10;i++)
            {
                Console.WriteLine("{0:0.0}\t{1:0.000}\t{2:0.000}\t{3:0.000}", i, 1 / i, Math.Sqrt(i), i * i);
            }
        }
    }
}

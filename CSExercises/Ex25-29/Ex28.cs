using System;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            int Mum,Prime=0;
            int i;
            Console.WriteLine("Please input an integer.");
            Mum=Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=Math.Sqrt(Mum);i++)
            {
                if (Mum % i == 0)
                    Prime = 0;
                else
                    Prime = 1;
            }
            if (Prime == 0)
                Console.WriteLine("It is not a prime.");
            else
                Console.WriteLine("It is a prime.");

        }
    }
}

using System;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            int Num, i,sum=0;
            Console.WriteLine("Please input an integer.");
            Num=Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=Num/2;i++)
            {
                if (Num % i == 0)
                    sum = i + sum;
            }
            if (sum == Num)
                Console.WriteLine("This is a Perfect Number.");
            else
                Console.WriteLine("This is not a Perfect Number.");
        }
    }
}

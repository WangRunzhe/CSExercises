using System;

namespace CSExercises
{
    public class Ex39
    {
        public static long Factorial(long n)
        {
            long Result;
            if (n != 1)
                Result = n * Factorial(n - 1);
            else
                Result = 1;
            return Result;
        }
        public static void Main()
        {
            long Num,TheFactorial;
            Console.WriteLine("Please input a value of an integer.");
            Num=Convert.ToInt64(Console.ReadLine());
            TheFactorial = Factorial(Num);
            Console.WriteLine("The Factorial of {0} is {1}.", Num, TheFactorial);
        }
    }
}

using System;

namespace CSExercises
{
    public class Ex31
    {
        static bool JudgePerfectNum(int num)
        {
            int sum=0;
            for(int i=1;i<=num/2;i++)
            {
                if (num % i == 0)
                    sum = sum + i;
            }
            if (sum == num)
                return true;
            else
                return false;
        }
   
        public static void Main(string[] args)
        {
            int i,MAX=1000;
            bool Perfect;
            Console.WriteLine("This progamm is to show the Perfect Number from 1 to {0}:", MAX);
            Console.WriteLine("1");
            for(i=2;i<=1000;i++)
            {
                Perfect = JudgePerfectNum(i);
                if (Perfect == true)
                    Console.WriteLine("{0}", i);
            }
        }
    }
}

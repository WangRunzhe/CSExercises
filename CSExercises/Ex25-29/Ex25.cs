using System;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            int Num,Factorial;
            int i;
            Console.WriteLine("Please input the value of an integer");
            Num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorials(increment counter) are :  ");
            for(i=1;i<=Num/2;i++)
            {
                if(Num%i==0)
                {
                    Factorial = i;
                    Console.WriteLine("{0}  ", Factorial);
                }
            }
            Console.WriteLine("{0}", Num);
            Console.WriteLine("Factorials(decrement counter) are :  ");
            Console.WriteLine("{0}", Num);
            for (i = Num/2; i >=1; i--)
            {
                if (Num % i == 0)
                {
                    Factorial = i;
                    Console.WriteLine("{0}  ", Factorial);
                }
            }
        }
    }
}

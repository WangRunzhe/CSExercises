using System;

namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            int A, B,AB,LCM,HCF,Reminder;
            int A0, B0;
            Console.WriteLine("This program is to calculate the LCM and HCF of two integers.");
            Console.WriteLine("Please input the value of A");
            A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the value of B");
            B = Convert.ToInt32(Console.ReadLine());
            AB=A*B;
            A0 = A;
            B0 = B;
            Reminder= A % B;
            while (Reminder != 0) 
            {
                A = B;
                B = Reminder;
                Reminder = A % B;
            }
            HCF = B;
            LCM = AB / HCF;
            Console.WriteLine("The HCF of {0} and {1} is {2} and the LCM is {3}.", A0, B0, HCF, LCM);
        }
    }
}

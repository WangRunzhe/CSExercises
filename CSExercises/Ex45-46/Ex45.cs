using System;

namespace CSExercises
{
    public class Ex45
    {
        public static void Main(string[] args)
        {
            int Num5cent,Num100cent,Num50cent,Num20cent,Num10cent;
            int i;
            double Pay;
            string c100 = "100c", c50 = "50c", c20 = "20c",c10="10c", c5 = "5c";
            Console.WriteLine("Please enter the payment(don't more than 3.50)");
            Pay = Convert.ToDouble(Console.ReadLine());
            Num5cent = Convert.ToInt32(Pay / 0.05);
            Num100cent = Num5cent / 20;
            Num50cent = (Num5cent - Num100cent*20) / 10;
            Num20cent = (Num5cent - Num100cent * 20 - Num50cent * 10) / 4;
            Num10cent = (Num5cent - Num100cent * 20 - Num50cent * 10 - Num20cent * 4) / 2;
            Num5cent = (Num5cent - Num100cent * 20 - Num50cent * 10 - Num20cent * 4 - Num10cent * 2);
            for (i = 0; i < Num100cent; i++)
                Console.WriteLine(c100);
            for (i = 0; i < Num50cent; i++)
                Console.WriteLine(c50);
            for (i = 0; i < Num20cent; i++)
                Console.WriteLine(c20);
            for (i = 0; i < Num10cent; i++)
                Console.WriteLine(c10);
            for (i = 0; i < Num5cent; i++)
                Console.WriteLine(c5);
        }
    }
}

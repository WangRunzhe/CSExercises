using System;

namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            double MinCharge = 2.40, NextPerKM=0.4,LastPerKM=0.5,Distance,Fare=0;
            Console.WriteLine("Please input the distance.");
            Distance = Convert.ToDouble(Console.ReadLine());
            Distance = Math.Round(Distance, 2);
            Distance = (Math.Ceiling(Distance * 10)) / 10; //To avoid when the when distance%0.1=0 it will take a mistake that the distance will add 0.1.
            /*if ((Math.Round(Distance, 2)) % 0.1 == 0)
                Distance = Math.Round(Distance, 1);
            else
                Distance = Math.Round(Distance + 0.05, 1);*/
            if (Distance <= 0.5)
                Fare = MinCharge;
            else if (Distance > 0.5 && Distance <= 9)
            {
                Fare = MinCharge + (Distance - 0.5) * NextPerKM;
            }
            else if (Distance > 9)
                Fare = MinCharge + 8.5 * NextPerKM + (Distance - 9) * LastPerKM;
            Console.WriteLine("The fare is {0:0.00}.",Fare);
        }
    }
}
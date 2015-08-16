using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            double Fixed = 2.40, Distance, Fare, PerKilo = 0.4;
            Console.WriteLine("Please input the value of distance.");
            Distance = Convert.ToDouble(Console.ReadLine());
            Fare = Fixed + Distance * PerKilo;
            Fare = (Math.Ceiling(Fare * 10)) / 10;
            Console.WriteLine("The total fare is {0:0.00}", Fare);

            /*if(Fare%0.1==0)
            {
                Console.WriteLine("The total fare is {0:0.00}", Fare);
            }
            else
            {
                Fare = Math.Round(Fare + 0.05, 1);
                Console.WriteLine("The total fare is {0:0.00}", Fare);*/
        
        }

    }
}


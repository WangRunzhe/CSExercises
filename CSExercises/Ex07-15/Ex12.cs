﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            double Fixed = 2.40, Distance, Fare, PerKilo = 0.4;
            Console.WriteLine("Please input the value of distance.");
            Distance = Convert.ToDouble(Console.ReadLine());
            Fare = Fixed + Distance * PerKilo;
            Fare = Math.Round(Fare, 1);
            Console.WriteLine("The total fare is {0:0.00}", Fare);
            
        }
    }
}

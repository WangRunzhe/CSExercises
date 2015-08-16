using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            double Salary, HousingAllowance, TransportAllowance,income;
            Console.WriteLine("Please input the salary.");
            Salary = Convert.ToDouble(Console.ReadLine());
            HousingAllowance = Salary * 0.1;
            TransportAllowance = Salary * 0.03;
            income = Salary + HousingAllowance + TransportAllowance;
            Console.WriteLine("The income is ${0:0.00}", income);
        }
    }
}

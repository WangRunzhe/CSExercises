using System;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            int Armstrong,Hundred,Ten,One;
            bool flag=true;
            while(flag)
            {
                Console.WriteLine("Please input a 3-digit integer.");
                Armstrong = Convert.ToInt32(Console.ReadLine());
                if (Armstrong >= 100 && Armstrong <= 999)
                {
                    Hundred = Armstrong / 100;
                    Ten = (Armstrong - Hundred * 100) / 10;
                    One = (Armstrong - Hundred * 100 - Ten * 10);
                    if ((Math.Pow(Hundred, 3) + Math.Pow(Ten, 3) + Math.Pow(One, 3)) == Armstrong)
                    {
                        Console.WriteLine("{0} is a Armstrong number.", Armstrong);
                        flag = false;
                    }
                    else
                    {
                        Console.WriteLine("{0} is not a Armstrong number.", Armstrong);
                        flag = true;
                    }
                }
               
            }
        }
    }
}
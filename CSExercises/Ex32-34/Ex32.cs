using System;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            int Month;
            int i;
            double[,] Sales=new double[12,2];//sales=Sales[x,0],rank=Sales[x.1];
            double comp, MaxMonth=0, MinMonth=0 ,Sum=0,Average;
            for (Month = 0; Month <= 11; Month++)
            {
                Console.WriteLine("Please input the sales for Month {0}.", Month+1);
                Sales[Month,0]=Convert.ToDouble(Console.ReadLine());
                Sales[Month, 1] = Month;
            }
            comp = Sales[0, 0];
            for(i=1;i<12;i++)
            {
                if (comp > Sales[i, 0])
                {
                    comp = Sales[i, 0];
                    MaxMonth = Sales[i, 1];
                }
            }
            comp = Sales[0, 0];
            for (i = 1; i < 12; i++)
            {
                if (comp < Sales[i, 0])
                {
                    comp = Sales[i, 0];
                    MinMonth = Sales[i, 1];
                }
            }
            for(i=0;i<12;i++)
            {
                Sum = Sum + Sales[i, 0];
            }
            Average = Sum / 12;
            Console.WriteLine("Maximum Sales: {0}\nMinimum Sales: {1}\nAverage Sales: {2}", MaxMonth,MinMonth,Average);

           

        }
    }
}

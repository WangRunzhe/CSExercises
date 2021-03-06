using System;

namespace CSExercises
{
    public class Ex30
    {
        /*public static bool JudgePrime(int Num)
        {
            int i, Reminder;
            for (i = 2; i <= Math.Sqrt(Num); i++)
            {
                Reminder = Num % i;
                if (Reminder == 0)
                    return true;
            }
            return false;
        }*/
        public static void Main(string[] args)
        {
            const int MAX = 1000000;
            int[,] Prime = new int[MAX+1,2];
            int i,j,step,TestNum;
            for(TestNum=0;TestNum<=MAX;TestNum++)
            {
                Prime[TestNum , 0] = TestNum;
                Prime[TestNum , 1] = 1;
            }
            for(i=2;i<=Math.Sqrt(MAX);i++)
            {
                if (Prime[i, 1] == 1)
                {
                    for (j = Prime[i, 0],step=j; i+j <=MAX; j = j+step)//set step    
                        Prime[i+j, 1] = 0;
                }               
            }
            Console.WriteLine("This programme is to show the Prime from 1 to {0}:", MAX);
            for(i=5;i<=MAX;i++)
            {
                if (Prime[i, 1] == 1)
                    Console.Write("{0}\t\t", Prime[i, 0]);
                if(i%500==0)
                    Console.Write("\n");
            }
        }
    }
}

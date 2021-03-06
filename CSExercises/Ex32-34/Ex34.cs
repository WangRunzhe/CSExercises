using System;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] Score = new int[12, 4]{{56,84,68,29},{94,73,31,89},{41,63,36,90},{99,9,18,17},{62,3,65,75},{40,96,53,23},{81,15,27,30}
            ,{21,70,100,22},{88,50,13,12},{48,54,52,78},{64,71,67,25},{16,93,46,72}};
            int SumStudent = 0, SumSubject = 0, SumClass = 0;
            int i, j;
            double Dev = 0, SumDev = 0, Average = 0; 
            Console.WriteLine("The total marks of each student :");
            for(i=0;i<12;i++)
            {
                SumStudent = Score[i, 0] + Score[i, 1] + Score[i, 2] + Score[i, 3];
                Console.WriteLine("Student {0}:\t{1}", i + 1, SumStudent);
            }
            Console.WriteLine("The average of each subject :");
            for (j = 0; j < 4; j++)
            {
                SumSubject = 0;
                for (i = 0; i < 12; i++)
                {
                    SumSubject = SumSubject + Score[i, j];                    
                }
                Average = SumSubject / 12;
                Console.WriteLine("Average of subject {0}:\t{1:0.00}", j + 1, Average);
            }
            Console.WriteLine("The standard deviation of each subject :");
            for (j = 0; j < 4; j++)
            {
                SumSubject = 0;
                SumDev = 0;
                for (i = 0; i < 12; i++)
                {
                    SumSubject = SumSubject + Score[i, j];                    
                }
                Average = SumSubject / 12;
                for (i = 0; i < 12;i++ )
                    SumDev=SumDev+Math.Pow(Score[i,j]-Average,2);
                Dev = SumDev / 12;
                    Console.WriteLine("Standard deviation of subject {0}:\t{1:0.00}", j + 1, Dev);
            }
            Console.WriteLine("The average of whole class subjects is :");
            for (i = 0; i < 12; i++)
                for (j = 0; j < 4; j++)
                    SumClass = SumClass + Score[i, j];
            Average = SumClass / 12 / 4;
            Console.WriteLine("{0:0.00}", Average);
        }
    }
}

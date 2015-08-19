using System;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] Name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] Mark = new int[5] { 63, 29, 75, 82, 55 };
            int i, j,TempNum;
            string TempString;
            Console.WriteLine("The name table:");
            for(i=0;i<5;i++)
            {
                Console.Write("{0}\t\t", Name[i]);
            }
            Console.WriteLine("The mark table:");
            for (i = 0; i < 5; i++)
                Console.Write("{0}\t\t", Mark[i]);
            for(i=0;i<5;i++)
            {
                for(j=i;j<5;j++)
                    if(Mark[i]<Mark[j])
                    {
                        TempNum = Mark[i];
                        Mark[i] = Mark[j];
                        Mark[j] = TempNum;
                    }
            }
            for(i=0;i<5;i++)
            {
                for(j=i;j<5;j++)
                    if(Name[i].CompareTo(Name[j])==1)
                    {
                        TempString = Name[i];
                        Name[i] = Name[j];
                        Name[j] = TempString;
                    }
            }
            Console.WriteLine("The new name table :");
            for (i = 0; i < 5; i++)
                Console.Write("{0}\t\t",Name[i]);
            Console.WriteLine("The new mark table :");
            for (i = 0; i < 5; i++)
                Console.Write("{0}\t\t", Mark[i]);
        }
    }
}

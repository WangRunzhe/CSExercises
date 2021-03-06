using System;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[,] Array = new int[10,2];
            int[,] Record=new int[50,2];
            string[,] Stars = new string[10,2];
            int i,Num=0,Count1=0,Count2=0;
            Random RanArray = new Random();
            for(i=0;i<50;i++)
            {
               Record[i, 0] = RanArray.Next(0, 10);
               Record[i, 1] = RanArray.Next(-5, 6);
            }
            for(Num=0;Num<10;Num++)
            {
                for(i=0;i<50;i++)
                {
                    if(Record[i,0]==Num)
                        Count1++;
                }
                for (i = 0; i < 50; i++)
                {
                    if (Record[i, 1] == Num)
                        Count2++;
                }
                Array[Num, 0] = Count1;
                Array[Num, 1] = Count2;
                Count1 = 0;
                Count2 = 0;
            }
            for(Num=0;Num<10;Num++)
            {
                for (i = 0; i < Array[Num, 0]; i++)
                {
                    Stars[Num, 0] = Stars[Num, 0] + "*";
                }
                for (i = 0; i < Array[Num, 1]; i++)
                {
                    Stars[Num, 1] = Stars[Num, 1] + "*";
                }
            }
            Console.WriteLine("Range 0 to 9\t\t\t\t\tRange -5 to 5");
            Console.WriteLine("Number\t\tCount\t\t\t\tNumber\t\tCount");
            for(Num=0;Num<10;Num++)
                Console.WriteLine("{0}\t\t{1}\t\t\t\t{2}\t\t{3}", Num, Array[Num,0],Num,Array[Num,1]);
            Console.WriteLine("Number\t\tStars\t\t\t\tNumber\t\tCount");
            for (Num = 0; Num < 10; Num++)
                Console.WriteLine("{0}\t\t{1}\t\t\t\t{2}\t\t{3}", Num, Stars[Num,0],Num,Stars[Num,1]);
        }
    }
}

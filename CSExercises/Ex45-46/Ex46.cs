using System;

namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[] Array = new int[10];
            int[] Record=new int[50];
            string[] Stars = new string[10];
            int i,Num=0,Count=0;
            Random RanArray = new Random();
            for(i=0;i<50;i++)
            {
               Record[i]= RanArray.Next(0,10);
            }
            for(Num=0;Num<10;Num++)
            {
                for(i=0;i<50;i++)
                {
                    if(Record[i]==Num)
                        Count++;
                }
                Array[Num]=Count;
                Count=0;
            }
            for(Num=0;Num<10;Num++)
            {
                for (i = 0; i < Array[Num]; i++)
                    Stars[Num] = Stars[Num] + "*";
            }
            Console.WriteLine("Number\t\tCount");
            for(Num=0;Num<10;Num++)
                Console.WriteLine("{0}\t\t{1}", Num, Array[Num]);
            Console.WriteLine("Number\t\tStars");
            for (Num = 0; Num < 10; Num++)
                Console.WriteLine("{0}\t\t{1}", Num, Stars[Num]);
        }
    }
}

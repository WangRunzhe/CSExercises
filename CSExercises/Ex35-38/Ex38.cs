using System;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            //string[] Name = new string[5] { "John", "Venkat", "Mary", "Victor", "Betty" };
            string[,] Name = new string[5,2] { {"John","0"}, {"Venkat","1"}, {"Mary","2"}, {"Victor","3"}, {"Betty","4"} };
            int[,] Mark = new int[5,2] { {63,0}, {29,1},{75,2}, {82,3}, {55,4} };
            int i, j,TempNum;
            string TempString;
            Console.WriteLine("Name\t\tMark");
            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}\t\t{1}", Name[i,0],Mark[i,0]);
            }
            Console.WriteLine("\nUsing descending order of the Mark.");
            for(i=0;i<5;i++)
            {
                for(j=i;j<5;j++)
                    if(Mark[i,0]<Mark[j,0])
                    {
                        TempNum = Mark[i,0];
                        Mark[i,0] = Mark[j,0];
                        Mark[j,0] = TempNum;
                    }
            }
            Console.WriteLine("\nName\t\tMark");
            for (i = 0; i < 5;i++ )
            {
                for(j=0;j<5;j++)
                {
                    if (Mark[i, 1] == Convert.ToInt32(Name[j, 1]))
                        Console.Write("{0}\t\t", Name[j, 0]);
                }
                Console.WriteLine("{0}", Mark[i, 0]);
            }
            Console.WriteLine("\nStudent names alphabetically");
            Console.WriteLine("\nName\t\tMark");
            for (i = 0; i < 5; i++)
            {
                for (j = i; j < 5; j++)
                    if (Name[i,0].CompareTo(Name[j,0]) == 1)
                    {
                        TempString = Name[i,0];
                        Name[i,0] = Name[j,0];
                        Name[j,0] = TempString;
                    }
            }
            for (i = 0; i < 5;i++ )
            {
                for(j=0;j<5;j++)
                {
                    if (Mark[i, 1] == Convert.ToInt32(Name[j, 1]))
                        Console.Write("{0}\t\t", Name[j, 0]);
                }
                Console.WriteLine("{0}", Mark[i, 0]);
            }
           
        }
    }
}

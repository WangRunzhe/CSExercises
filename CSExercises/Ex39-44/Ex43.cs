using System;

namespace CSExercises
{
    public class Ex43
    {
        public static string Hex(int Num)
        {
            int Count=0,Result=-1,Reminder=0,SaveNum;
            int i;
            char M10;
            string HexReal="";
            SaveNum = Num;//save the value of Num
            while(Result!=0)//Get the number of digit place of Num.
            {
                Result = Num / 16;
                Num = Result;
                Count++;
            }
            int [] HexNum = new int[Count];
            Num=SaveNum;//Get the value of the initial Num
            for(i=0;i<Count;i++)
            {
                Reminder = Num % 16;
                Num = Num / 16;
                HexNum[Count - 1 - i] = Reminder;
            }
            for (i = 0; i < Count;i++ )
            {
                if (HexNum[i] >= 0 && HexNum[i] <= 9)
                {   
                    HexReal=HexReal+HexNum[i];
                    //Console.Write(HexReal);
                }
                else if(HexNum[i]==10)
                {
                    M10='A';
                    HexReal = HexReal + M10;
                   // Console.Write(HexReal);
                }
                else if(HexNum[i]==11)
                {
                    M10 = 'B';
                    HexReal = HexReal + M10;
                    //Console.Write(HexReal);
                }
                else if(HexNum[i]==12)
                {
                    M10 = 'C';
                    HexReal = HexReal + M10;
                    //Console.Write(HexReal);
                }
                else if(HexNum[i]==13)
                {
                    M10 = 'D';
                    HexReal = HexReal + M10;
                    //Console.Write(HexReal);
                }
                else if(HexNum[i]==14)
                {
                    M10 = 'E';
                    HexReal = HexReal + M10;
                   // Console.Write(HexReal);
                }
                else
                {
                    M10 = 'F';
                    HexReal = HexReal + M10;
                   // Console.Write(HexReal);
                }
            }
                return HexReal;
        }
        public static void Main()
        {
            int i,MAX=100;
            Console.WriteLine("This programme is to show the Hex of 1 to {0}", MAX);
            Console.WriteLine("Decimal\t\tHex");
            for(i=1;i<=MAX;i++)
            {
                Console.WriteLine("{0}\t\t{1}", i, Hex(i));
            }

        }
    }

}

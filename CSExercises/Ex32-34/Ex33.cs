using System;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] Array = new int[20]{86,35,41,49,89,51,11,71,50,75,25,58,40,14,44,3,63,81,93,79};
            int i, j,temp;
            Console.WriteLine("The start order is:");
            for (i = 0; i < 20; i++)
                Console.Write("{0}\t", Array[i]);
            for (i = 0; i < 20; i++)
            {
                 for (j = i + 1; j < 20; j++)
                 {
                     if (Array[i] < Array[j])
                     {
                         temp = Array[i];
                         Array[i] = Array[j];
                         Array[j] = temp;
                     }
                 }
                    /* for (i = 0; i < 20; i++)
                         Console.Write("{0}\t", Array[i]);*/
             }
            Console.WriteLine("The descending order is:");
            for (i = 0; i < 20; i++)
                Console.Write("{0}\t", Array[i]);
        }
    }
}

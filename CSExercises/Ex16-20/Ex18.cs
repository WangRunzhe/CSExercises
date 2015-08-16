using System;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            double Mark;
            string Grade;
            Console.WriteLine("Please input the score.");
            Mark = Convert.ToDouble(Console.ReadLine());
            if(Mark>=80&&Mark<=100)
            {   
                Grade="A";
                Console.WriteLine("The grade is {0}.",Grade);
            }
            else if(Mark>=60&&Mark<=79)
            {    
                Grade="B";
                Console.WriteLine("The grade is {0}.",Grade);
            }
            else if(Mark>=40&&Mark<=59)
            {  
                Grade="C";
                Console.WriteLine("The grade is {0}.",Grade);
            }
            else if(Mark>=0&&Mark<=40)
            { 
                Grade="D";
                Console.WriteLine("The grade is {0}.",Grade);
            }
            else
            {
                Grade="** Error **";
                Console.WriteLine(Grade);
            }
            
           }
        }
    }

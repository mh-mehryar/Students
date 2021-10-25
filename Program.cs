using System;
using System.Collections.Generic;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            //Number of Students :
            System.Console.WriteLine("Please Enter Students Number :");
            int studentNum = Convert.ToInt32(Console.ReadLine());

            //Student's Names :
            List<string> studentList = new List<string>();
            List<int> stScore = new List<int>();
            
            int count = 0;
            for (var i = 0; i < studentNum; i++)
            {
                System.Console.WriteLine("Enter Student's Name Number " + (i+1) + " :");
                studentList.Add(Console.ReadLine());

                
                // System.Console.WriteLine("Please Enter Scores in 3 Lesson :");
                
                for (var j = 0; j < 3; j++)
                {
                    count = count + j ;
                    System.Console.WriteLine("Please Enter 3 Scores => Lesson " + (j+1) + " :");
                    stScore.Add(Convert.ToInt32(Console.ReadLine()));
                    
                }
                   
            }

            System.Console.WriteLine("*****************");
            System.Console.WriteLine("The Results are :");
            System.Console.WriteLine("*****************");

            string arr = string.Join(",", studentList.ToArray());
            System.Console.WriteLine(arr);
               
            string arr1 = string.Join(",", stScore.ToArray());
            System.Console.WriteLine(arr1);
        
            int sum = 0;
            
            foreach (var item in stScore)
            {   
                
                sum = sum + item;
            }
            int average = sum / count ;
            System.Console.WriteLine("*****************");
            System.Console.WriteLine("The avaerage is : " + average);
            
        
            int max = int.MinValue;
            foreach (var score in stScore)
                {
                     if (score > max)
                         {
                            max = score;
                            }
                }
                System.Console.WriteLine("*****************");
            System.Console.WriteLine("The Max Score is : " + max);

                 int min = int.MaxValue;
                 foreach (var score in stScore)
                    {
                     if (score < min)
                         {
                            min = score;
                         }
                    }
                
                System.Console.WriteLine("*****************");
            System.Console.WriteLine("The Min Score is : " + min);
        }
    }
}

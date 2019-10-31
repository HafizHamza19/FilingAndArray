using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {
       
        static void Main(string[] args)
        { 
            int a;
            Console.WriteLine("Enter The Number of Students:");
            a = Int32.Parse(Console.ReadLine());
            int[] student = new int[a];
            int[] question=new int[20];
            int[] marks = new int[a];
            Console.WriteLine("********* MCQ Exam Start ************");
            string[] input=new string[20];
            for (int i = 0; i < a; i++)
            {
              
                student[i] = 327422 + i;
                Console.WriteLine("Roll No Student:  "+student[i]);
                input[i] = Console.ReadLine();
               
                
                char[] ans;
                ans = input[i].ToCharArray();
                for (int j = 0; j < 4; j++)
                {
                    
                    if (ans[j] == 'a' || ans[j] == 'A')
                    {
                        if (j == 0)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 1)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 2)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 3)
                        {
                            question[j] = question[j] + 1;
                        }
                        marks[i] =marks[i]+ 4;
                    }
                    else if (ans[j] == 'B' || ans[j] == 'b' || ans[j] == 'C' || ans[j] == 'c' || ans[j] == 'D' || ans[j] == 'd' || ans[j] == 'E' || ans[j] == 'e')
                    {
                        marks[i] = marks[i] - 1;
                    }
                    else
                    {
                        marks[i] = marks[i] + 0;
                    }
                }
                for (int j = 4; j < 8; j++)
                {
                    if (ans[j] == 'B' || ans[j] == 'b')
                    {
                        if (j == 4)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 5)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 6)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 7)
                        {
                            question[j] = question[j] + 1;
                        }
                        marks[i] = marks[i] + 4;
                    }
                    else if (ans[j] == 'A' || ans[j] == 'a' || ans[j] == 'C' || ans[j] == 'c' || ans[j] == 'D' || ans[j] == 'd' || ans[j] == 'E' || ans[j] == 'e')
                    {
                        marks[i] = marks[i] - 1;
                    }
                    else
                    {
                        marks[i] = marks[i] +0;
                    }

                }
                for (int j = 8; j < 12; j++)
                {
                    if (ans[j] == 'C' || ans[j] == 'c')
                    {
                        if (j == 8)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 9)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 10)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 11)
                        {
                            question[j] = question[j] + 1;
                        }
                        marks[i] = marks[i] + 4;
                    }
                    else if (ans[j] == 'A' || ans[j] == 'a' || ans[j] == 'D' || ans[j] == 'd' || ans[j] == 'B' || ans[j] == 'b' || ans[j] == 'E' || ans[j] == 'e')
                    {
                        marks[i] = marks[i] - 1;
                    }
                    else
                    {
                        marks[i] =marks[i]+ 0;
                    }

                }
                for (int j = 12; j < 16; j++)
                {
                    if (ans[j] == 'D' || ans[j] == 'd')
                    {
                        if (j == 12)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 13)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 14)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 15)
                        {
                            question[j] = question[j] + 1;
                        }
                        marks[i] = marks[i] + 4;
                    }
                    else if (ans[j] == 'A' || ans[j] == 'a' || ans[j] == 'C' || ans[j] == 'c' || ans[j] == 'B' || ans[j] == 'b' || ans[j] == 'E' || ans[j] == 'e')
                    {
                        marks[i] = marks[i] - 1;
                    }
                    else
                    {
                        marks[i] = marks[i] + 0;
                    }

                }
                for (int j = 16; j < 20; j++)
                {
                    if (ans[j] == 'E' || ans[j] == 'e')
                    {
                        if (j == 16)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 17)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 18)
                        {
                            question[j] = question[j] + 1;
                        }
                        else if (j == 19)
                        {
                            question[j] = question[j] + 1;
                        }
                        marks[i] = marks[i] + 4;
                    }
                    else if (ans[j] == 'A' || ans[j] == 'a' || ans[j] == 'C' || ans[j] == 'c' || ans[j] == 'D' || ans[j] == 'd' || ans[j] == 'B' || ans[j] == 'b')
                    {
                        marks[i] = marks[i] - 1;
                    }
                    else
                    {
                        marks[i] = marks[i] + 0;
                    }

                }

            }
            for (int j = 0; j < a; j++)
            {
                
                File.WriteAllText(@"D:\exmple.txt", "\n" + input[j]+Environment.NewLine);
                File.WriteAllLines("scores.txt",
    input[j].Select(tb => (double.Parse(input[j]).ToString())));
                using (var writer = new StreamWriter(@"D:\example.txt"))
                {
                  
                    writer.WriteLine(Environment.NewLine);
                    writer.WriteLine("Roll NO :" + student[j]);
                    writer.WriteLine(input[j]);
                }
             
        
            }
            Console.WriteLine("********* MCQ Student Exam Report ************");
          
       
            
            Console.WriteLine("\n  Roll No                 Marks \n");
            for (int i = 0; i < a; i++)
            {
                student[i] = 327422+i;
                Console.WriteLine(1+i+")  " + student[i] + "                 "+marks[i]);
               
            }
            Console.WriteLine("\nThe Total Number Of Eximintation Marked  :"+a);
            Console.WriteLine("Number Of Correct Responses Of Each Question");
            Console.WriteLine("\nQuestion:  1   2   3   4   5   6   7   8   9  10");
            Console.WriteLine("#Correct:  " + question[0] + "   " + question[1] + "   " + question[2] + "   " + question[3] + "   " + question[4] + "   " + question[5] + "   " + question[6] + "   " + question[7] + "   " + question[8] + "   " + question[9]);
            Console.WriteLine("\nQuestion: 11  12  13  14  15  16  17  18  19  20");
            Console.WriteLine("#Correct:  " + question[10] + "   " + question[11] + "   " + question[12] + "   " + question[13] + "   " + question[14] + "   " + question[15] + "   " + question[16] + "   " + question[17] + "   " + question[18] + "   " + question[19]);
            Console.ReadLine();
        }
    }
}

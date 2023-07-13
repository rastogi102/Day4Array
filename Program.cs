using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main(string[] args)
            //----------------Single dimensional Array----------------
        {
            //int[] marks = new int[5];
            //Console.WriteLine("Enter marks");
            //for(int i=0; i<marks.Length; i++)
            //{
            //    Console.WriteLine("Enter marks in Subject \t"+(i+1));
            //    marks[i]=int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("*Marks List*");
            //for(int i=0;i<marks.Length;i++)
            //{
            //    Console.WriteLine($"Subject {i+1} \t Marks: {marks[i]}");


            //}


            //Console.ReadKey();


            // -------------------foreach example---------------------------------
            //Console.WriteLine("Enter Number of Students");
            //int nos=int.Parse(Console.ReadLine());
            //string[] students = new string[nos];
            //for(int i=0;i<nos;i++)
            //{
            //    Console.WriteLine($"Enter Student{i+1} \'s name");
            //    students[i] = Console.ReadLine();
            //}
            //Console.WriteLine("List of Students");
            //foreach(string student in students)
            //{
            //    Console.WriteLine(student);
            //}
            //Console.ReadKey();


            //-----------Rect Array or two dimensional array-----------------
            //string[,] myRectArray = new string[4, 3];
            //for(int i = 0; i<myRectArray.GetLength(0); i++)
            //{
            //    for(int j = 0; j < myRectArray.GetLength(1); j++)
            //    {
            //        myRectArray[i,j] = "[" + i +"," + j +"]";
            //    }
            //}
            //Console.WriteLine("Stored Values are:");
            //for(int i = 0; i<myRectArray.GetLength(0); i++)
            //{
            //    for( int j = 0; j < myRectArray.GetLength(1); j++)
            //    {
            //        Console.Write(myRectArray[i,j]+" \t ");
            //    }
            //    Console.WriteLine("\n");
            //}
            //Console.ReadKey();

            //int[,] marks = new int[4, 3];
            //for(int i=0; i<4; i++)
            //{
            //    Console.WriteLine($"Enter Student {i+1}\'s Roll Number");
            //    marks[i,0] = int.Parse( Console.ReadLine() );
            //    for(int j=1; j<3; j++)
            //    {
            //        Console.WriteLine($"Enter marks of Student\'s {i+1}in Sem{j}");
            //        marks[i,j] = int.Parse( Console.ReadLine()) ;

            //    }
            //}
            //Console.WriteLine("Marks List as Follows");
            //Console.WriteLine("RollNo\tSemOne\tSemTwo");
            //for(int i=0; i<4;i++)
            //{
            //    for(int j=0; j<3;j++)
            //    {
            //        Console.Write(marks[i,j]+"\t");
            //    }
            //    Console.WriteLine("\n");
            //}
            //Console.ReadKey();

            //-----------------Practice Problem-----------------------------------

            // Create a rectangular array to store marks
            int[,] studMarks = new int[4, 5];

            // Input marks for each student and semester
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter details for Student " + (i + 1));

                Console.Write("Enter Roll No: ");
                int rollNo = int.Parse(Console.ReadLine());

                for (int j = 0; j < 4; j++)
                {
                    int marks;
                    bool isValidInput;

                    do
                    {
                        Console.Write("Enter marks for Semester " + (j + 1) + ": ");
                        isValidInput = int.TryParse(Console.ReadLine(), out marks);

                        if (!isValidInput)
                        {
                            Console.WriteLine("Invalid input! Please enter a valid integer value.");
                        }

                    } while (!isValidInput);

                    studMarks[i, j] = marks;
                }

                studMarks[i, 4] = rollNo; // Store roll number in the last column
            }

            Console.WriteLine();
            Console.WriteLine("RollNo\tSem1\tSem2\tSem3\tSem4\tTotal");
            Console.WriteLine("----------------------------------------------");

            // Calculate and print the details
            for (int i = 0; i < 4; i++)
            {
                int totalMarks = 0;

                Console.Write(studMarks[i, 4] + "\t"); // Print roll number from the last column

                for (int j = 0; j < 4; j++)
                {
                    Console.Write(studMarks[i, j] + "\t");
                    totalMarks += studMarks[i, j];
                }

                Console.WriteLine(totalMarks);
            }

            Console.ReadLine();

        }

    }
}

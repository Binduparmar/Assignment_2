using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class1
    {
        static void Main(string[] args)
        {
                //11
                int i;
                Console.Write("Enter a Number : ");
                i = Convert.ToInt32(Console.ReadLine());

                if (i % 2 == 0)
                    Console.Write("Entered Number is an Even Number");
                else
                    Console.Write("Entered Number is an Odd Number");

                //12
                int num;

                Console.Write("Input an integer : ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num >= 0)
                    Console.WriteLine("{0} is a Positive Number.\n", num);
                else
                    Console.WriteLine("{0} is a Negative Number. \n", num);

                //13
                int year;

                Console.Write("Input an Year : ");
                year = Convert.ToInt32(Console.ReadLine());

                if ((year % 400) == 0)
                    Console.WriteLine("{0} is a leap year.\n", year);
                else if ((year % 100) == 0)
                    Console.WriteLine("{0} is not a leap year.\n", year);
                else if ((year % 4) == 0)
                    Console.WriteLine("{0} is a leap year.\n", year);
                else
                    Console.WriteLine("{0} is not a leap year.\n", year);

                //14
                int age;

                Console.Write("Input the age of the candidate : ");
                age = Convert.ToInt32(Console.ReadLine());

                if (age < 18)
                {
                    Console.Write("Sorry, You are not eligible to caste your vote.\n");
                    Console.Write("You would be able to caste your vote after {0} year.\n\n", 18 - age);
                }
                else
                    Console.Write("Congratulation! You are eligible for casting your vote.\n\n");

                //15
                int m, n;

                Console.Write("Input the  value of m :");
                m = Convert.ToInt32(Console.ReadLine());

                if (m != 0)
                    if (m > 0)
                        n = 1;
                    else
                        n = -1;
                else
                    n = 0;

                Console.Write("The value of m = {0} \n", m);
                Console.Write("The value of n = {0} \n\n", n);

                //16
                int PerHeight;

                Console.Write("Input the height of the person (in centimetres) : ");
                PerHeight = Convert.ToInt32(Console.ReadLine());

                if (PerHeight < 150.0)
                    Console.Write("The person is Dwarf. \n\n");
                else if ((PerHeight >= 150.0) && (PerHeight <= 165.0))
                    Console.Write("The person is  average heighted. \n\n");
                else if ((PerHeight >= 165.0) && (PerHeight <= 195.0))
                    Console.Write("The person is taller. \n\n");
                else
                    Console.Write("Abnormal height.\n\n");

                //17
                int num1, num2, num3;

                Console.Write("Input the 1st number : ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the 2nd number : ");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the 3rd number : ");
                num3 = Convert.ToInt32(Console.ReadLine());

                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.Write("The 1st Number is the greatest among three. \n\n");
                    }
                    else
                    {
                        Console.Write("The 3rd Number is the greatest among three. \n\n");
                    }
                }
                else if (num2 > num3)
                    Console.Write("The 2nd Number is the greatest among three \n\n");
                else
                    Console.Write("The 3rd Number is the greatest among three \n\n");

                //18
                int p, c, m;

                Console.Write("Input the marks obtained in Physics :");
                p = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the marks obtained in Chemistry :");
                c = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the marks obtained in Mathematics :");
                m = Convert.ToInt32(Console.ReadLine());
                Console.Write("Total marks of Maths, Physics and Chemistry : {0}\n", m + p + c);
                Console.Write("Total marks of Maths and  Physics : {0}\n", m + p);

                if (m >= 65)
                    if (p >= 55)
                        if (c >= 50)
                            if ((m + p + c) >= 180 || (m + p) >= 140)
                                Console.Write("The  candidate is eligible for admission.\n");
                            else
                                Console.Write("The candidate is not eligible.\n\n");
                        else
                            Console.Write("The candidate is not eligible.\n\n");
                    else
                        Console.Write("The candidate is not eligible.\n\n");
                else
                    Console.Write("The candidate is not eligible.\n\n");

                //19
                int rl;
                double phy, che, ca, total;
                double per;
                string nm, div;

                Console.Write("Input the Roll No of the Student : ");
                rl = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the Name of the Student : ");
                nm = Console.ReadLine();

                Console.Write("Input  the marks of Physics : ");
                phy = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input  the marks of  Chemistry : ");
                che = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input  the marks of Computer Application : ");
                ca = Convert.ToInt32(Console.ReadLine());

                total = phy + che + ca;
                per = total / 3.0;
                if (per >= 60)
                    div = "First";
                else
                if (per < 60 && per >= 48)
                    div = "Second";
                else
                    if (per < 48 && per >= 36)
                    div = "Pass";
                else
                    div = "Fail";

                Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl, nm);
                Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n", phy, che, ca);
                Console.Write("Total Marks = {0}\nPercentage = {1}%\nDivision = {2}\n", total, per, div);

                //20
                int tmp;

                Console.Write("Input days temperature : ");
                tmp = Convert.ToInt32(Console.ReadLine());

                if (tmp < 0)
                    Console.Write("Freezing weather.\n");
                else if (tmp < 10)
                    Console.Write("Very cold weather.\n");
                else if (tmp < 20)
                    Console.Write("Cold weather.\n");
                else if (tmp < 30)
                    Console.Write("Normal in temp.\n");
                else if (tmp < 40)
                    Console.Write("Its Hot.\n");
                else
                    Console.Write("Its very hot.\n");
    }
        }
    }            
}

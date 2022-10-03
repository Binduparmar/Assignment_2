using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class2
    {
        static void Main(string[] args)
        {
            //21
            int side_a, side_b, side_c;

            Console.Write("Input side 1 of triangle: ");
            side_a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            side_b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 3 of triangle: ");
            side_c = Convert.ToInt32(Console.ReadLine());

            if (side_a == side_b && side_b == side_c)
            {
                Console.Write("This is an equilateral triangle.\n");
            }
            else if (side_a == side_b || side_a == side_c || side_b == side_c)
            {
                Console.Write("This is an isosceles triangle.\n");
            }
            else
            {
                Console.Write("This is a scalene triangle.\n");
            }

            //22
            int ang_a, ang_b, ang_c, sum;

            Console.Write("Input angle1 of triangle: ");
            ang_a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input angle 2 of triangle: ");
            ang_b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input angle 3 of triangle: ");
            ang_c = Convert.ToInt32(Console.ReadLine());

            // Calculate the sum of all angles of triangle 
            sum = ang_a + ang_b + ang_c;

            // Check whether sum=180 then its a valid triangle otherwise not 
            if (sum == 180)
            {
                Console.Write("The triangle is valid.\n");
            }
            else
            {
                Console.Write("The triangle is not valid.\n");
            }

            //23
            char ch;

            Console.Write("Input an Alphabet (A-Z or a-z) : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());

            int i = ch;
            if (i >= 48 && i <= 57)
            {
                Console.Write("You entered a number, Please enter an alpahbet.");
            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'i':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'o':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'u':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    case 'e':
                        Console.WriteLine("The Alphabet is vowel");
                        break;
                    default:
                        Console.WriteLine("The Alphabet is not a vowel");
                        break;
                }
            }
            //24
            int cprice, sprice, plamt;

            Console.Write("Input Cost Price: ");
            cprice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Selling Price: ");
            sprice = Convert.ToInt32(Console.ReadLine());

            if (sprice > cprice)
            {
                plamt = sprice - cprice;
                Console.Write("\nYou can booked your profit amount : {0}\n", plamt);
            }
            else if (cprice > sprice)
            {
                plamt = cprice - sprice;
                Console.Write("\nYou got a loss of amount : {0}\n", plamt);
            }
            else
            {
                Console.Write("\nYou are running in no profit no loss condition.\n");
            }
            //25
            int custid, conu;
            double chg, surchg = 0, gramt, netamt;
            string connm;

            Console.Write("Input Customer ID : ");
            custid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the name of the customer : ");
            connm = Console.ReadLine();
            Console.Write("Input the unit consumed by the customer : ");
            conu = Convert.ToInt32(Console.ReadLine());

            if (conu < 200)
                chg = 1.20;
            else if (conu >= 200 && conu < 400)
                chg = 1.50;
            else if (conu >= 400 && conu < 600)
                chg = 1.80;
            else
                chg = 2.00;

            gramt = conu * chg;

            if (gramt > 300)
                surchg = gramt * 15 / 100.0;
            netamt = gramt + surchg;
            if (netamt < 100)
                netamt = 100;

            Console.Write("\nElectricity Bill\n");
            Console.Write("Customer IDNO                       : {0}\n", custid);
            Console.Write("Customer Name                       : {0}\n", connm);
            Console.Write("unit Consumed                       : {0}\n", conu);
            Console.Write("Amount Charges @Rs. {0}  per unit : {1}\n", chg, gramt);
            Console.Write("Surchage Amount                     : {0}\n", surchg);
            Console.Write("Net Amount Paid By the Customer     : {0}\n", netamt);

            //26
            string notes;
            char grd;

            Console.Write("Input the grade : ");
            grd = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (grd)
            {
                case 'E':
                    notes = " Excellent";
                    break;
                case 'V':
                    notes = " Very Good";
                    break;
                case 'G':
                    notes = " Good ";
                    break;
                case 'A':
                    notes = " Average";
                    break;
                case 'F':
                    notes = " Fails";
                    break;
                default:
                    notes = "Invalid Grade Found.";
                    break;
            }
            Console.Write("You have chosen  : {0}\n", notes);

            //27
            int day_no;

            Console.Write("Input Day Number : ");
            day_no = Convert.ToInt32(Console.ReadLine());

            switch (day_no)
            {
                case 1:
                    Console.Write("Monday \n");
                    break;
                case 2:
                    Console.Write("Tuesday \n");
                    break;
                case 3:
                    Console.Write("Wednesday \n");
                    break;
                case 4:
                    Console.Write("Thursday \n");
                    break;
                case 5:
                    Console.Write("Friday \n");
                    break;
                case 6:
                    Console.Write("Saturday \n");
                    break;
                case 7:
                    Console.Write("Sunday  \n");
                    break;
                default:
                    Console.Write("Invalid day number. \nPlease try again ....\n");
                    break;
            }

            //28
            int digit;

            Console.Write("Input Digit(0-9) : ");
            digit = Convert.ToInt32(Console.ReadLine());

            switch (digit)
            {
                case 0:
                    Console.Write("Zero\n");
                    break;
                case 1:
                    Console.Write("one\n");
                    break;
                case 2:
                    Console.Write("Two\n");
                    break;
                case 3:
                    Console.Write("Three\n");
                    break;
                case 4:
                    Console.Write("Four\n");
                    break;
                case 5:
                    Console.Write("Five\n");
                    break;
                case 6:
                    Console.Write("Six\n");
                    break;
                case 7:
                    Console.Write("Seven\n");
                    break;
                case 8:
                    Console.Write("Eight\n");
                    break;
                case 9:
                    Console.Write("Nine\n");
                    break;
                default:
                    Console.Write("invalid digit. \nPlease try again ....\n");
                    break;
            }

            //29
            int month_no;

            Console.Write("Input Month No : ");
            month_no = Convert.ToInt32(Console.ReadLine());

            switch (month_no)
            {
                case 1:
                    Console.Write("January\n");
                    break;
                case 2:
                    Console.Write("February\n");
                    break;
                case 3:
                    Console.Write("March\n");
                    break;
                case 4:
                    Console.Write("April\n");
                    break;
                case 5:
                    Console.Write("May\n");
                    break;
                case 6:
                    Console.Write("June\n");
                    break;
                case 7:
                    Console.Write("July\n");
                    break;
                case 8:
                    Console.Write("August\n");
                    break;
                case 9:
                    Console.Write("September\n");
                    break;
                case 10:
                    Console.Write("October\n");
                    break;
                case 11:
                    Console.Write("November\n");
                    break;
                case 12:
                    Console.Write("December\n");
                    break;
                default:
                    Console.Write("invalid Month number. \nPlease try again ....\n");
                    break;
            }

            //30

            int month_no;

            Console.Write("Input Month No : ");
            month_no = Convert.ToInt32(Console.ReadLine());

            switch (month_no)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.Write("Month  have 31 days. \n");
                    break;
                case 2:
                    Console.Write("The 2nd month is a February and have 28 days. \n");
                    Console.Write("in leap year The February month  Have 29 days.\n");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.Write("Month have 30 days. \n");
                    break;
                default:
                    Console.Write("invalid Month number.\nPlease try again ....\n");
                    break;
            }
    
        }
    }
}

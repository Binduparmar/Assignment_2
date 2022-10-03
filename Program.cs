using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //1
            Console.Write("Enter First Letter : ");
            String l1 = Console.ReadLine();
            Console.Write("Enter Second Letter : ");
            String l2 = Console.ReadLine();
            Console.Write("Enter Third Letter : ");
            String l3 = Console.ReadLine();

            Console.WriteLine(l3 + " " + l2 + " " + l1);

            //2
            Console.Write("Input a number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the desired width : ");
            int width = Convert.ToInt32(Console.ReadLine());

            int height = width;
            for (int row = 0; row < height; row++)
            {
                for (int column = 0; column < width; column++)
                {
                    Console.Write(num);
                }

                Console.WriteLine();
                width--;
            }
              //3
                int x, y;
            char operation;

            Console.Write("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input operation: ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            if (operation == '+')
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);
            else if (operation == '-')
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);
            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);
            else if (operation == '/')
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);
            else
                Console.WriteLine("Wrong Character");

            //4
            double r, per_cir, PI = 3.14;
            Console.Write("Enter Radius Of a Circle : ");
            r = Convert.ToDouble(Console.ReadLine());

            per_cir = 2 * PI * r;
            Console.WriteLine("Perimeter of Circle is : {0}", per_cir);

            //5
            double distance, time, speed;
            Console.Write("Enter Distance [in Kilometer(s)] : ");
            distance = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Time [in hour(s)] : ");
            time = Convert.ToDouble(Console.ReadLine());

            speed = distance / time;
            Console.WriteLine("Speed is : {0}KM/h", speed);

            //6
            float r;
            float PI = 3.1415926535f;

            Console.Write("Radius : ");
            r = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine(4 * PI * (r * r));

            Console.WriteLine(4f / 3f * PI * (r * r * r));

            //7
            char symbol;

            Console.Write("Input a Symbol : ");
            symbol = Convert.ToChar(Console.ReadLine());

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                    (symbol == 'o') || (symbol == 'u'))
                Console.WriteLine("It's a lowercase vowel.");
            else if ((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("It's a digit.");
            else
                Console.Write("It's another symbol.");

            //8
            int n1, n2;
            bool bothEven;
            Console.Write("Input First number : ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Second number : ");
            n2 = Convert.ToInt32(Console.ReadLine());

            bothEven = ((n1 % 2 == 0) && (n2 % 2 == 0)) ? true : false;

            Console.WriteLine(bothEven ? "there're numbers Even" : "there's a number odd");

            //9
            string answer;
            string result;

            Console.Write("Input a Number : ");
            answer = Console.ReadLine();

            int num = Convert.ToInt32(answer);
            result = "";
            while (num > 1)
            {
                // for binary conversation base is 2
                int remainder = num % 2;
                result = Convert.ToString(remainder) + result;

                // for binary conversation base is 2
                num /= 2;
            }
            result = Convert.ToString(num) + result;
            Console.WriteLine("Binary : {0}", result);

                //10
                int int1, int2;

                Console.Write("Input 1st number: ");
                int1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input 2nd number: ");
                int2 = Convert.ToInt32(Console.ReadLine());

                if (int1 == int2)
                    Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
                else
                    Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);


        }
    }
}

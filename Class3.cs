using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class3
    {
        static void Main(string[] args)
        {
            //31
            int num1, num2, ch;

            Console.Write("Enter the first Integer :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second Integer :");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("\nHere are the options :\n");
            Console.Write("1 - Addition.\n2 - Substraction.\n3 - Multiplication.\n4 - Division.\n5 - Exit.\n");
            Console.Write("\nInput your choice : ");
            ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.Write("The Addition of  {0} and {1} is: {2}\n", num1, num2, num1 + num2);
                    break;

                case 2:
                    Console.Write("The Substraction of {0}  and {1} is: {2}\n", num1, num2, num1 - num2);
                    break;

                case 3:
                    Console.Write("The Multiplication of {0}  and {1} is: {2}\n", num1, num2, num1 * num2);
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.Write("The second integer is zero. Devide by zero.\n");
                    }
                    else
                    {
                        Console.Write("The Division of {0}  and {1} is : {2}\n", num1, num2, num1 / num2);
                    }
                    break;

                case 5:
                    break;

                default:
                    Console.Write("Input correct option\n");
                    break;
            }

            //32
            int[] arr = new int[10];
            int i;

            Console.Write("Input 10 elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are : ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\n");

            //33
            int i, n;
            int[] a = new int[100];

            Console.Write("Input the number of elements to store in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} number of elements in the array : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nThe values store into the array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", a[i]);
            }

            Console.Write("\n\nThe values store into the array in reverse are : \n");
            for (i = n - 1; i >= 0; i--)
            {
                Console.Write("{0} ", a[i]);
            }
            Console.Write("\n\n");

            //34
            int[] a = new int[100];
            int i, n, sum = 0;

            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                sum += a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);

            //35
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int i, n;

            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            /* Copy elements of first array into second array. */
            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }

            /* Prints the elements of first array */
            Console.Write("\nThe elements stored in the first array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }

            /* Prints the elements copied into the second array. */
            Console.Write("\n\nThe elements copied into the second array are : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr2[i]);
            }
            Console.Write("\n\n");

            //36
            int[] arr = new int[100];
            int i, j, num, count = 0;

            //Reads size of the array
            Console.WriteLine("Enter size of the array : ");
            num = Convert.ToInt32(Console.ReadLine());

            //Reads elements in array
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Find all duplicate elements in array
            for (i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    // If duplicate element found then increment count by 1
                    if (arr[i] == arr[j])
                    {
                        count++;
                        break;
                    }
                }
            }

            Console.WriteLine("\n Total number of duplicate elements found in array:" + count);
            Console.ReadLine();

            //37
            int n, ctr = 0;
            int[] arr1 = new int[100];
            int i, j, k;

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            /* Checking duplicate elements in the array */
            Console.Write("\nThe unique elements found in the array are : \n");
            for (i = 0; i < n; i++)
            {
                ctr = 0;

                /* Check duplicate before the current position and
                   increase counter by 1 if found. */
                for (j = 0; j < i - 1; j++)
                {
                    /* Increment the counter when the seaarch value is duplicate. */
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                    }
                }

                /* Check duplicate after the current position and
                   increase counter by 1 if found. */
                for (k = i + 1; k < n; k++)
                {
                    /* Increment the counter when the seaarch value is duplicate. */
                    if (arr1[i] == arr1[k])
                    {
                        ctr++;
                    }
                    /* Duplicate numbers next to each other */
                    if (arr1[i] == arr1[i + 1])
                    {
                        i++;
                    }
                }

                /* Print the value of the current position of the array as unique value
                   when counter remain contains its initial value. */
                if (ctr == 0)
                {
                    Console.Write("{0} ", arr1[i]);
                }
            }
            Console.Write("\n\n");

            //38
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[200];
            int s1, s2, s3;
            int i, j, k;

            Console.Write("Input the number of elements to be stored in the first array : ");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array : \n", s1);
            for (i = 0; i < s1; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input the number of elements to be stored in the second array : ");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", s2);
            for (i = 0; i < s2; i++)
            {
                Console.Write("element - {0} : ", i);
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            /* size of merged array is size of first array and  size of second array */
            s3 = s1 + s2;

            /* ----------------- insert in the third array ------------------------------------ */
            for (i = 0; i < s1; i++)
            {
                arr3[i] = arr1[i];
            }
            for (j = 0; j < s2; j++)
            {
                arr3[i] = arr2[j];
                i++;
            }

            /* ----------------- sort the array in ascending order --------------------------- */
            for (i = 0; i < s3; i++)
            {
                for (k = 0; k < s3 - 1; k++)
                {

                    if (arr3[k] >= arr3[k + 1])
                    {
                        j = arr3[k + 1];
                        arr3[k + 1] = arr3[k];
                        arr3[k] = j;
                    }
                }
            }

            /* --------------- Prints the merged array ------------------------------------ */
            Console.Write("\nThe merged array in ascending order is : \n");
            for (i = 0; i < s3; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");

            //39
            int[] arr1 = new int[100];
            int[] fr1 = new int[100];
            int n, i, j, ctr;

            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                fr1[i] = -1;
            }

            for (i = 0; i < n; i++)
            {
                ctr = 1;
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] == arr1[j])
                    {
                        ctr++;
                        fr1[j] = 0;
                    }
                }

                if (fr1[i] != 0)
                {
                    fr1[i] = ctr;
                }
            }

            Console.Write("\nThe frequency of all elements of the array : \n");
            for (i = 0; i < n; i++)
            {
                if (fr1[i] != 0)
                {
                    Console.Write("{0} occurs {1} times\n", arr1[i], fr1[i]);
                }
            }

            //40
            int[] arr1 = new int[100];
            int i, mx, mn, n;

            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            mx = arr1[0];
            mn = arr1[0];

            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }

                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }
            Console.Write("Maximum element is : {0}\n", mx);
            Console.Write("Minimum element is : {0}\n\n", mn);

        }
    }
}

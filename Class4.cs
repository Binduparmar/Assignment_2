using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class4
    {
        static void Main(string[] args)
        {
            //41
            int[] arr1 = new int[10];
            int[] arr2 = new int[10];
            int[] arr3 = new int[10];
            int i, j = 0, k = 0, n;

            Console.Write("Input the number of elements to be stored in the array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }

            Console.Write("\nThe Even elements are : \n");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }

            Console.Write("\nThe Odd elements are : \n");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", arr3[i]);
            }
            Console.Write("\n\n");

            //42
            int[] arr1 = new int[10];
            int n, i, j, tmp;

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[j] < arr1[i])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }

            Console.Write("\nElements of array in sorted ascending order : \n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");

            //43
            int[] arr1 = new int[10];

            int n, i, j, tmp;

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                for (j = i + 1; j < n; j++)
                {
                    if (arr1[i] < arr1[j])
                    {
                        tmp = arr1[i];
                        arr1[i] = arr1[j];
                        arr1[j] = tmp;
                    }
                }
            }

            Console.Write("\nElements of the array in sorted descending order:\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0}  ", arr1[i]);
            }
            Console.Write("\n\n");

            //44
            int[] arr1 = new int[10];
            int i, n, p = 0, inval;

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            /* Stored values into the array */
            Console.Write("Input {0} elements in the array in ascending order : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input the value to be inserted : ");
            inval = Convert.ToInt32(Console.ReadLine());

            Console.Write("The exist array list is : \n ");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", arr1[i]);

            /* Determine the position where the new value will be insert. */
            for (i = 0; i < n; i++)
                if (inval < arr1[i])
                {
                    p = i;
                    break;
                }

            /* move all data at right side of the array */
            for (i = n; i >= p; i--)
                arr1[i] = arr1[i - 1];

            /* insert value at the proper position */
            arr1[p] = inval;

            Console.Write("\n\nAfter Insert the list is : \n ");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", arr1[i]);
            Console.Write("\n");

            //45
            int[] arr1 = new int[10];
            int i, n, p, x;

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            /* Stored values into the array */
            Console.Write("Input {0} elements in the array in ascending order : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Input the value to be inserted : ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Position, where the value to be inserted : ");
            p = Convert.ToInt32(Console.ReadLine());

            Console.Write("The current list of the array : \n");
            for (i = 0; i < n; i++)
                Console.Write("{0} ", arr1[i]);

            /* Move all data at right side of the array */
            for (i = n; i >= p; i--)
                arr1[i] = arr1[i - 1];

            /* insert value at given position */
            arr1[p - 1] = x;

            Console.Write("\n\nAfter Insert the element the new list is : \n");
            for (i = 0; i <= n; i++)
                Console.Write("{0} ", arr1[i]);
            Console.Write("\n\n");

            //46
            int i, pos, n;
            int[] arr1 = new int[50];

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            /* Stored values into the array */
            Console.Write("Input {0} elements in the array in ascending order : \n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nInput the position where to delete : ");
            pos = Convert.ToInt32(Console.ReadLine());

            /* ------- locate the position of i in the array ------- */
            i = 0;
            while (i != pos - 1)
                i++;

            /* 
             * the position of i in the array will be replaced by the 
             * value of its right 
            */
            while (i < n)
            {
                arr1[i] = arr1[i + 1];
                i++;
            }
            n--;
            Console.Write("\nThe new list is : ");
            for (i = 0; i < n; i++)
            {
                Console.Write("  {0}", arr1[i]);
            }
            Console.Write("\n\n");

            //47
            int n, i, j = 0, lrg, lrg2nd;
            int[] arr1 = new int[50];

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            /* Stored values into the array */
            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            /* find location of the largest element in the array */
            lrg = 0;
            for (i = 0; i < n; i++)
            {
                if (lrg < arr1[i])
                {
                    lrg = arr1[i];
                    j = i;
                }
            }

            /* ignore the largest element and find the 2nd largest element in the array */
            lrg2nd = 0;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  /* ignoring the largest element */
                    i--;
                }
                else
                {
                    if (lrg2nd < arr1[i])
                    {
                        lrg2nd = arr1[i];
                    }
                }
            }

            Console.Write("\nThe Second largest element in the array is : {0} \n", lrg2nd);

            //48
            int n, i, j = 0, sml, sml2nd;
            int[] arr1 = new int[50];

            Console.Write("Input the size of array : ");
            n = Convert.ToInt32(Console.ReadLine());

            /* Stored values into the array */
            Console.Write("Input {0} elements in the array (value must be <9999):\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            /* find location of the smallest element in the array */
            sml = 0;
            for (i = 0; i < n; i++)
            {
                if (sml > arr1[i])
                {
                    sml = arr1[i];
                    j = i;
                }
            }

            /* ignore the smallest element and find the 2nd smallest element in the array */
            sml2nd = 99999;
            for (i = 0; i < n; i++)
            {
                if (i == j)
                {
                    i++;  /* ignoring the smallest element */
                    i--;
                }
                else
                {
                    if (sml2nd > arr1[i])
                    {
                        sml2nd = arr1[i];
                    }
                }
            }

            Console.Write("\nThe Second smallest element in the array is : {0} \n", sml2nd);

            //49
            int i, j;
            int[,] arr1 = new int[3, 3];

            /* Stored values into the array */
            Console.Write("Input elements in the matrix : \n");

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe Matrix is : \n");
            for (i = 0; i < 3; i++)
            {
                Console.Write("\n");
                for (j = 0; j < 3; j++)
                    Console.Write("{0}   ", arr1[i, j]);
            }
            Console.Write("\n\n");

            //50
            int i, j, n;
            int[,] arr1 = new int[50, 50];
            int[,] brr1 = new int[50, 50];
            int[,] crr1 = new int[50, 50];

            Console.Write("Input the size of the square matrix (less than 5) : ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n < 5 && n != 0)
            {
                //Stored values into the array 
                Console.Write("Input elements in the first matrix :\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("element - [{0},{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("Input elements in the second matrix :\n");
                for (i = 0; i < n; i++)
                {
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("element - [{0},{1}] : ", i, j);
                        brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("\nThe First matrix is :\n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                        Console.Write("{0}\t", arr1[i, j]);
                }

                Console.Write("\nThe Second matrix is :\n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                        Console.Write("{0}\t", brr1[i, j]);
                }

                // calculate the sum of the matrix
                for (i = 0; i < n; i++)
                    for (j = 0; j < n; j++)
                        crr1[i, j] = arr1[i,j] + brr1[i, j];

                Console.Write("\nThe Addition of two matrix is : \n");
                for (i = 0; i < n; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                        Console.Write("{0}\t", crr1[i, j]);
                }
                Console.Write("\n\n");
            }
            else
            {
                if (n == 0)
                    Console.WriteLine("\nSize of the array can't be 0 ! \nIt must be grater than 0 or less than 5.");
                else
                    Console.WriteLine("\nSize of the array is too large ! \nIt must be less than 5.");
            }

        }
    }
}

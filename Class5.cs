using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Class5
    {
        static void Main(string[] args)
        {
            //51
                int i, j, n;
                int[,] mat_1 = new int[6, 6];
                int[,] mat_2 = new int[6, 6];

                Console.Write("Enter the size of matrix (less than 5) : ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 5 && n != 0)
                {
                    // initialize matrixs of array by user
                    Console.Write("\nMatrix : 1\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("Enter Element [{0}, {1}] : ", i, j);
                            mat_1[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    Console.Write("\nMatrix : 2\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("Enter Element [{0}, {1}] : ", i, j);
                            mat_2[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    // display matrixs 
                    Console.Write("\nMatrix : 1\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0} ", mat_1[i, j]);
                        }
                        Console.WriteLine();
                    }

                    Console.Write("\nMatrix : 2\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0} ", mat_2[i, j]);
                        }
                        Console.WriteLine();
                    }

                    // Calculate Subtraction Matrix and print it 
                    Console.Write("\nSubtracted Matrix :\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0} ", (mat_1[i, j] - mat_2[i, j]));
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    if (n == 0)
                        Console.WriteLine("\nSize of the array can't be 0 ! \nIt must be grater than 0 or less than 5.");
                    else
                        Console.WriteLine("\nSize of the array is too large ! \nIt must be less than 5.");
                }

                //52
                int i, j, n;
                int[,] mat_1 = new int[6, 6];
                int[,] mat_2 = new int[6, 6];

                Console.Write("Enter the size of matrix (less than 5) : ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 5 && n != 0)
                {
                    // initialize matrixs of array by user
                    Console.Write("\nMatrix : 1\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("Enter Element [{0}, {1}] : ", i, j);
                            mat_1[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    Console.Write("\nMatrix : 2\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("Enter Element [{0}, {1}] : ", i, j);
                            mat_2[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    // display matrixs 
                    Console.Write("\nMatrix : 1\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0} ", mat_1[i, j]);
                        }
                        Console.WriteLine();
                    }

                    Console.Write("\nMatrix : 2\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0} ", mat_2[i, j]);
                        }
                        Console.WriteLine();
                    }

                    // Calculate Multiplication Matrix and print it 
                    Console.Write("\nMultiplication Matrix :\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0} ", (mat_1[i, j] * mat_2[i, j]));
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    if (n == 0)
                        Console.WriteLine("\nSize of the array can't be 0 ! \nIt must be grater than 0 or less than 5.");
                    else
                        Console.WriteLine("\nSize of the array is too large ! \nIt must be less than 5.");
                }

                //53
                int i, j, n, sum = 0;

                Console.Write("Enter the size of matrix (less than 5) : ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 5 && n != 0)
                {
                    // declare array of given size
                    int[,] mat_1 = new int[n, n];

                    // initialize matrixs of array by user
                    Console.Write("\nMatrix : 1\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("Enter Element [{0}, {1}] : ", i, j);
                            mat_1[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    // display matrixs 
                    Console.Write("\nMatrix : 1\n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("{0} ", mat_1[i, j]);
                        }
                        Console.WriteLine();
                    }

                    // Calculate sum of left Diagonal of Matrix and print it
                    for (i = 0; i < n; i++)
                    {
                        sum += mat_1[i, (n - 1) - i];
                    }

                    Console.WriteLine("Sum of Left Diagonal of a Matrix is : {0}", sum);
                }
                else
                {
                    if (n == 0)
                        Console.WriteLine("\nSize of the array can't be 0 ! \nIt must be grater than 0 or less than 5.");
                    else
                        Console.WriteLine("\nSize of the array is too large ! \nIt must be less than 5.");
                }

                //54
                int i, j, n;
                int[,] arr1 = new int[10, 10];
                int[] rsum = new int[10];
                int[] csum = new int[10];

                Console.Write("Input the size of the square matrix (less than 5) : ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n < 5 && n != 0)
                {
                    Console.Write("Input elements in the matrix : \n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                        {
                            Console.Write("element - [{0}],[{1}] : ", i, j);
                            arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    Console.Write("The matrix is : \n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                            Console.Write("{0}  ", arr1[i, j]);
                        Console.Write("\n");
                    }

                    /* Sum of rows */
                    for (i = 0; i < n; i++)
                    {
                        rsum[i] = 0;
                        for (j = 0; j < n; j++)
                            rsum[i] = rsum[i] + arr1[i, j];
                    }

                    /* Sum of Column */
                    for (i = 0; i < n; i++)
                    {
                        csum[i] = 0;
                        for (j = 0; j < n; j++)
                            csum[i] = csum[i] + arr1[j, i];
                    }

                    Console.Write("The sum of row and column of the matrix : \n");
                    for (i = 0; i < n; i++)
                    {
                        for (j = 0; j < n; j++)
                            Console.Write("{0}    ", arr1[i, j]);
                        Console.Write("{0}    ", rsum[i]);
                        Console.Write("\n");
                    }

                    Console.Write("\n");
                    for (j = 0; j < n; j++)
                    {
                        Console.Write("{0}   ", csum[j]);
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

                //55
                int[,] arr1 = new int[50, 50];
                int[,] brr1 = new int[50, 50];
                int i, j, r1, c1, r2, c2, flag = 1;

                Console.Write("Input the number of rows in the 1st matrix : ");
                r1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the number of columns in the 1st matrix : ");
                c1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Input the number of rows in the 2nd matrix : ");
                r2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the number of columns in the 2nd matrix : ");
                c2 = Convert.ToInt32(Console.ReadLine());

                /* initialize two metrices from user input */
                Console.Write("Input elements in the first matrix : \n");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.Write("Input elements in the second matrix :\n");
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                    {
                        Console.Write("element - [{0}],[{1}] : ", i, j);
                        brr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                /* display the two metrices */
                Console.Write("The first matrix is :\n");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                        Console.Write("{0}  ", arr1[i, j]);
                    Console.Write("\n");
                }
                Console.Write("The second matrix is :\n");
                for (i = 0; i < r2; i++)
                {
                    for (j = 0; j < c2; j++)
                        Console.Write("{0}  ", brr1[i, j]);
                    Console.Write("\n");
                }

                /* Comparing two matrices for equality */
                if (r1 != r2 && c1 != c2)
                {
                    Console.Write("The Matrices Cannot be compared : \n");
                }
                else
                {
                    Console.Write("The Matrices can be compared : \n");
                    for (i = 0; i < r1; i++)
                    {
                        for (j = 0; j < c2; j++)
                        {
                            if (arr1[i, j] != brr1[i, j])
                            {
                                flag = 0;
                                break;
                            }
                        }
                    }
                    if (flag == 1)
                        Console.Write("Two matrices are equal.\n\n");
                    else
                        Console.Write("But, two matrices are not equal.\n\n");
                }
        }
    }
}

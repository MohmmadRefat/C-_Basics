using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Assignemnt
    {



        static void PassByValueEX(int x)
        {
            x += 10;
        }

        static void PassByReferenceEX(ref int x)
        {
            x += 10;
        }

        static int SumOfDigits(int x)
        {
            int sum = 0;
            while (x > 0)
            {
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }

        static bool IsPrime(int x)
        {
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            if (x > 1)
                return true;
            return false;
        }

        static int Fact(int x)
        {
            //the iterative Way
            int fact = 1;
            while (x > 0)
            {
                fact *= x;
                x -= 1;
            }
            return fact;

            /* the recursive Way
            //if(x==0||x==1)
            //return 1;

            //return x * Fact(x - 1);
            */
        }

        static string ChangeChar(string s, int pos, char ch)
        {
            if (pos < 0 || pos >= s.Length)
            {
                Console.WriteLine("the Position is un valid");
            }

            char[] CharArray = s.ToCharArray();
            CharArray[pos] = ch;
            return new string(CharArray);
        }
        static void Main(string[] args)
        {

            #region 1.Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.WriteLine("Enter the Size of the identity matrix  : \n");
            //int n = int.Parse(Console.ReadLine());
            //int[,] IdentityMatrix = new int[n, n];

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            IdentityMatrix[i, j] = 1;
            //        }
            //    }
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write($"{IdentityMatrix[i, j]}  ");
            //    }
            //    Console.WriteLine('\n');
            //}

            #endregion

            #region  2.Write a program in C# Sharp to find the sum of all elements of the array..
            //Console.WriteLine("Enter the Size of the matrix  : ");
            //int n = int.Parse(Console.ReadLine());
            //int[] IdentityMatrix = new int[n];
            //int sum = 0;
            //for (int i = 0; i < n; i++) {
            //        IdentityMatrix[i] =int.Parse(Console.ReadLine());
            //        sum += IdentityMatrix[i];
            //    }
            //Console.WriteLine($"the sum of the array Elements : {sum}");
            #endregion

            #region 3.Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.WriteLine("Enter the size of the array");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //int[] arr2 = new int[n];
            //int[] arr3 = new int[n*2];
            //for (int i = 0; i < n; i++) arr1[i]=int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++) arr2[i] = int.Parse(Console.ReadLine());
            //Array.ConstrainedCopy(arr1, 0, arr3, 0, n);
            //Array.ConstrainedCopy(arr2, 0, arr3, n, n);
            //Array.Sort(arr3);
            //for (int i = 0; i < 2*n; i++)
            //{
            //    Console.WriteLine($"{arr3[i]} ");
            //}

            #endregion

            #region 4. Write a program in C# Sharp to count the frequency of each element of an array.

            //Console.WriteLine("Enter the size of the array");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];                    //considering the array elements in range (1 to n)
            //int[] freq = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //    freq[arr1[i]]++;
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    if (freq[i]>0)
            //    Console.WriteLine($"{i} : {freq[i]} \n");
            //}

            #endregion

            #region 5.Write a program in C# Sharp to find maximum and minimum element in an array

            //Console.WriteLine("Enter the size of the array");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //for (int i = 0; i < n; i++) arr1[i]=int.Parse(Console.ReadLine());
            //Console.WriteLine(arr1.Max());
            //Console.WriteLine(arr1.Min());
            #endregion

            #region 6.Write a program in C# Sharp to find the second largest element in an array.

            //Console.WriteLine("Enter the size of the array");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //for (int i = 0; i < n; i++) arr1[i] = int.Parse(Console.ReadLine());
            //Array.Sort(arr1);
            //Console.WriteLine(arr1[n - 2]);

            #endregion

            #region 7.Consider an Array of Integer values with size N, having values as in this Example

            //Console.WriteLine("Enter the size of the array");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //for (int i = 0; i < n; i++) arr1[i] = int.Parse(Console.ReadLine());
            //int MxLen = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (arr1[i] == arr1[j])
            //        {
            //            MxLen = Math.Max(j - i - 1,MxLen);
            //        }
            //    }
            //}
            //Console.WriteLine($"the max distance between 2 equal values is : {MxLen}");

            #endregion

            #region 8.Given a list of space separated words, reverse the order of the words.

            //string[] s = Console.ReadLine().Split();
            //int sz=s.Length;
            //for(int i = sz-1; i >=0; i--)
            //{
            //    Console.Write($"{s[i]} ");
            //}

            #endregion

            #region 9.Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //Console.WriteLine("Enter the size of the array");
            //int n = int.Parse(Console.ReadLine());
            //int[,] arr1 = new int[n,n];
            //int[,] arr2 = new int[n, n];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        arr1[i,j] = int.Parse(Console.ReadLine());
            //    }
            //}
            //Array.Copy(arr1, arr2, n * n);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write($"{arr2[i,j]} ");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region 10.Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.

            //Console.WriteLine("Enter the size of the array");
            //int n = int.Parse(Console.ReadLine());
            //int[] arr1 = new int[n];
            //for (int i = 0; i < n; i++) arr1[i] = int.Parse(Console.ReadLine());

            //Array.Reverse(arr1);
            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write($"{arr1[i]} ");

            //}
            #endregion

            #region 11.Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            //1. Passing by Value (Default call of the function)
            // a. the data is copied and passed to the function
            //b. the changes occur in the function only and  not  change the actual data

            //2.Passing by Reference
            //a. the addresses of the data is passed to the function
            //b. any change on the data of function will change the actual data (because they have the same data)

            //int x = 10;
            //PassByValueEX(x);
            //Console.WriteLine($"when call by value : {x}");
            //PassByReferenceEX(ref x);
            //Console.WriteLine($"when call by Reference : {x}");
            #endregion

            #region 12.Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.

            //Console.Write("Enter Number : ");
            //int num=int.Parse(Console.ReadLine());
            //Console.WriteLine($"The sum of the digits of the number {num} is {SumOfDigits(num)}");

            #endregion

            #region 13.-Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not .

            //Console.Write("Enter Number : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(IsPrime(num)?$"the number {num} is Prime" : $"the number {num} is Not Prime");

            #endregion

            #region 14.Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter

            //Console.Write("Enter Number : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"the Factorial of {num} is {Fact(num)}");

            #endregion

            #region 15 Create a function named "ChangeChar" to modify a letter in a       certain position (0 based) of a string, replacing it with a different letter 
            //Console.Write("Enter the string : ");
            //string s=Console.ReadLine();
            //Console.Write("Enter the char position to replace it with new char : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the char :  ");
            //char ch = Console.ReadKey().KeyChar;
            //Console.WriteLine($"the new String : {ChangeChar(s, num, ch)}");

            #endregion

        }
    }
}

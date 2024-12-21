using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Asssignment
    {
        #region 1. Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
        //Console.WriteLine("Enter 3 points : \n");
        //int x1 = int.Parse(Console.ReadLine());
        //int y1 = int.Parse(Console.ReadLine());
        //int x2 = int.Parse(Console.ReadLine());
        //int y2 = int.Parse(Console.ReadLine());
        //int x3 = int.Parse(Console.ReadLine());
        //int y3 = int.Parse(Console.ReadLine());

        //int s1 = ((y2 - y1) * (x3 - x2));
        //int s2 = ((y3 - y2) * (x2 - x1));
        //if (s1 == s2)
        //{
        //    Console.WriteLine("the 3 point are locate in the same single line");
        //}
        //else
        //{
        //    Console.WriteLine("the 3 point are NOT in the SAME LINE");
        //}
        #endregion

        #region  2. Write a program to allow the user to enter a string and print the REVERSE of it.
        //Console.WriteLine("Enter A string to reverse it \n");
        //string s = Console.ReadLine();
        //int sz = s.Length;
        //for(int i = sz-1; i >=0; i--)
        //{
        //    Console.Write(s[i]);
        //}
        #endregion

        #region 3.Write a program to allow the user to enter int and print the REVERSED of it.
        //Console.WriteLine("Enter the Intger to REVERSE");
        //int x = int.Parse(Console.ReadLine());
        //while (x > 0)
        //{
        //    Console.Write(x % 10);
        //    x /= 10;
        //}

        #endregion

        #region 4.Write a program in C# Sharp to find prime numbers within a range of numbers.

        //Console.Write("Input starting number of range : ");
        //int num = int.Parse(Console.ReadLine());
        //Console.Write("Input ending number of range : ");
        //int num1 = int.Parse(Console.ReadLine());
        //bool flag = true;
        //for(int i=num;i<num1;i++)
        //{
        //    flag = true;
        //    for(int j = 2; j*j<=i; j++)
        //    {
        //        if (i % j == 0)
        //        {

        //            flag = false;
        //            break;
        //        }
        //    }
        //    if(flag&&i>=2)
        //        Console.Write($" {i} ");

        //}
        //Time Complixity O(N log(N))
        #endregion

        #region 5.. Write a program in C# Sharp to convert a decimal number into binary without using an array.
        //Console.Write("Enter a number to convert to Binary representation : ");
        //int num = int.Parse(Console.ReadLine());
        //while (num > 0)
        //{
        //    Console.Write(num%2);
        //    num /= 2;
        //}
        #endregion

        #region 6. Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task.
        //Console.WriteLine("Enter the time taken for the task");
        //int num = int.Parse(Console.ReadLine());
        //if(num >= 2 && num < 3)
        //{
        //    Console.WriteLine("this worker is highly efficient.");
        //}
        //else if (num >= 3 && num < 4)
        //{
        //    Console.WriteLine("this worker must inrease his speeed.");
        //}
        //else if (num >= 4 && num < 5)
        //{
        //    Console.WriteLine("this worker must train to enhance his speeed.");
        //}
        //else if (num >= 5 )
        //{
        //    Console.WriteLine("this worker must leave the company.");
        //}

        #endregion



    }
}

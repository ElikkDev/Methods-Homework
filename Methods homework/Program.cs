using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;


class Program
{
    //#region Second Task
    //static void Main()
    //{
    //    double result = Celsium(500);
    //    Console.WriteLine(result);

    //}

    //static double Celsium(double far)
    //{
    //    return (far - 32) * 5 / 9;
    //}
    //#endregion

    #region Third task

    //static void Main()
    //{
    //    int[] result = Dividor(12);

    //    for (int i = 0; i < result.Length; i++)
    //    {
    //        Console.WriteLine(result[i]);
    //    }

    //}

    //static int[] Dividor(int number)
    //{
    //    int count  = 0;
    //    for (int i = 1; i <= number; i++)
    //    {
    //        if (number % i == 0)
    //        {
    //            count++;

    //        }
    //    }

    //    int[] arr = new int[count];

    //    int index = 0;

    //    for (int i = 1; i <= number; i++)
    //    {
    //        if (number % i == 0)
    //        {
    //            arr[index] = i;
    //            index++;
    //        }
    //    }

    //    return arr;
    //}
    #endregion

    #region fourth task
    //static void Main()
    //{

    //    int answer = Factorial(5);
    //    Console.WriteLine(answer);

    //}

    //static int Factorial(int number)
    //{
    //   int number2 = 1;
    //    if (number == 0)
    //    {
    //        return 1;
    //    }

    //    else if (number < 0)
    //    {
    //        return -1;
    //    }

    //    else
    //    {
    //        for (int i = 1; i <= number; i++)
    //        {
    //            number2 *= i;
    //        }

    //        return number2;
    //    }
    //}
    #endregion

    #region Fifth task

    static void Main()
    {
        bool result = isPrime(12);
        Console.WriteLine(result);

    }

    static bool isPrime(int number)
    {
        int count = 0;

        for (int i  = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;
            }
        }
        if (count == 2)
        {
            return true;
        }
        else
        {
            return false;
        }
        
        
    }


    #endregion



}





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

    static void Main()
    {
        int[] result = Dividor(12);

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
        
    }

    static int[] Dividor(int number)
    {
        int count  = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                count++;

            }
        }

        int[] arr = new int[count];

        int index = 0;

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                arr[index] = i;
                index++;
            }
        }

        return arr;
    }



    #endregion
}





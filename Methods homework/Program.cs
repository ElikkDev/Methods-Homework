using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;


class Program
{
    static void Main()
    {
        bool result = isEven(5);
        Console.WriteLine(result);
        
    }

    static bool isEven(int number)
    {
        return number % 2 == 0;
    }
}
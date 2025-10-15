using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;


class Program
{
    static void Main()
    {
        double result = Celsium(500);
        Console.WriteLine(result);
        
    }

    static double Celsium(double far)
    {
        return (far - 32) * 5 / 9;
    }
}
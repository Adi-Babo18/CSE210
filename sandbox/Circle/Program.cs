using System;
using System.Security.Cryptography;

class Program
{
    public static void Main(string[] args)
    {
        Circle myCircle = new Circle();

        // myCircle.SetRadius(10);

        double area = myCircle.GetArea();

        Console.WriteLine(area);
        
    }
}
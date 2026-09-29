using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle();

        double area = myCircle.GetArea();

        Console.WriteLine(area);

    }
}

























    //static double AddNumbers(double x, int y)
    //{
        // Console.WriteLine(x);
        //return x + y;
    //}

    //static string MyName()
    //{
    //    return "Bob";
    //}

    //static void DisplayGreeting(string name)
    //{
        //Console.WriteLine($"Welcome {name}, it's nice to meet you.");
    //}

    //static void Main(string[] args)
    //{
        //string myName = MyName();
        //DisplayGreeting(myName);
        //double total = AddNumbers(12.234, 20);
        //Console.WriteLine(total);

        //bool done = false;
        //while (! done)
        //{
        //    Console.WriteLine("Are we done (y/n)?");
        //    done = Console.ReadLine() == "y";
        //}

        //for(double i = 0; i < 16; i++)
        //{
        //    Console.WriteLine(i);
        //}

        //for(double i = 0; i <1.0; i += 0.01)
        //{
        //    Console.WriteLine(i);
        //}

        //List<string> myFriends = new List<string> = {"Bob", "Betty", "Bubba"};

        //myFriends.Add("Doug");

        //foreach(string friend in myFriends)
        //{
        //    Console.WriteLine(friend);
        //}
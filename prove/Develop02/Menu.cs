class Menu
{
    public int ProcessMenu()
    {
        Console.WriteLine("In the same class.");

        int input = 0;

        while (input < 1 || input > 5)
        {
            Console.WriteLine("Welcome to the Journal Program.");
            Console.WriteLine("Create, Display, Save, or Read Journal Entires.");
            Console.WriteLine("1. Create a new Journal Entry.");
            Console.WriteLine("2. Display the Journal.");
            Console.WriteLine("3. Save the Journal Entry.");
            Console.WriteLine("4. Read from Journal .");
            Console.WriteLine("5. Quit.");
            Console.Write(">");
            input = int.Parse(Console.ReadLine());
        }
        return input;
    }
}
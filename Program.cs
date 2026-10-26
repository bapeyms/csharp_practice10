namespace csharp_practice10;

public delegate void ShowMessageDelegate(string message);

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("--- METHODS ---");
        // ShowMessageDelegate del1 = Print1;
        // ShowMessageDelegate del2 = Print2;
        // ShowMessageDelegate del3 = Print3;
        //
        // del1("MESSAGE 1 from Print1");
        // del2("MESSAGE 2 from Print2");
        // del3("MESSAGE 3 from Print3");

        Console.WriteLine("\n--- ARRAY OF DELEGATES ---");
        ShowMessageDelegate[] multiDel = { Print1, Print2, Print3 };
        string message = "TEST MESSAGE";
        int choice;

        do
        {
            Console.WriteLine("\n --- MENU ----");
            Console.WriteLine("1. Show message 'TEST MESSAGE' from Print1");
            Console.WriteLine("2. Show message 'TEST MESSAGE' from Print2");
            Console.WriteLine("3. Show message 'TEST MESSAGE' from Print3");
            Console.WriteLine("0. Exit");
            Console.Write("Choose an option: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("[ERROR]: Enter a number");
                continue;
            }
            if (choice >=1 && choice <= multiDel.Length)
            {
                multiDel[choice - 1](message);
            }
            else if (choice == 0)
            {
                Console.WriteLine("Exiting...");
            }
            else
            {
                Console.WriteLine("[ERROR: Non-existing choice]");
            }
        } while (choice != 0);
    }

    public static void Print1(string message)
    {
        Console.WriteLine($"[PRINT 1]: {message}");
    }
    public static void Print2(string message)
    {
        Console.WriteLine($"[PRINT 2]: {message}");
    }
    public static void Print3(string message)
    {
        Console.WriteLine($"[PRINT 3]: {message}");
    }
}
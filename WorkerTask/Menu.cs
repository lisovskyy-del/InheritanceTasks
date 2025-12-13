namespace MainProgram.WorkerTask;

class Menu
{
    public static void Run()
    {
        President president = new();
        Security security = new();
        Manager manager = new();
        Engineer engineer = new();

        while (true)
        {
            Console.WriteLine("\n1. Show info about President");
            Console.WriteLine("2. Show info about security");
            Console.WriteLine("3. Show info about manager");
            Console.WriteLine("4. show info about engineer");
            Console.WriteLine("0. Exit");
            Console.Write("Your choice: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int userChoice))
            {
                if (userChoice == 0)
                {
                    Console.WriteLine("\nExitting..");
                    break;
                }
                else if (userChoice == 1)
                {
                    president.Print();
                }
                else if (userChoice == 2)
                {
                    security.Print();
                }
                else if (userChoice == 3)
                {
                    manager.Print();
                }
                else if (userChoice == 4)
                {
                    engineer.Print();
                }
                else
                {
                    Console.WriteLine("\nInvalid choice! Enter a number between 0-4!");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input! Enter a number!");
            }
        }
    }
}

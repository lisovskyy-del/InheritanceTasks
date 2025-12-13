namespace MainProgram;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        while (true)
        {
            Console.WriteLine("\nChoose task: \n");
            Console.WriteLine("1. Money");
            Console.WriteLine("2. Device");
            Console.WriteLine("3. Musical Instrument");
            Console.WriteLine("0. Exit");
            Console.Write("Your choice: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int userChoice))
            {
                if (userChoice == 0)
                {
                    Console.WriteLine("\nExitting...");
                    return;
                }
                else if (userChoice == 1)
                {
                    MoneyTask.Menu.Run();
                }
                else if (userChoice == 2)
                {
                    DeviceTask.Menu.Run();
                }
                else if (userChoice == 3)
                {
                    InstrumentTask.Menu.Run();
                }
                else
                {
                    Console.WriteLine("\nInvalid choice! Enter a number between 0-6!");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input! Enter a number!");
            }
        }
    }
}
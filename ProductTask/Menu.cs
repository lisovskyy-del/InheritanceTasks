namespace MainProgram.ProductTask;

class Menu
{
    static string StringInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (input != null)
            {
                return input;
            }
            Console.WriteLine("\nInvalid input. Please enter a string.");
        }
    }

    static int IntInput(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            Console.WriteLine("\nInvalid input. Please enter a number.");
        }
    }

    static Electronics ElectronicsInput()
    {
        string name = StringInput("\nEnter electronic's name: ");
        int price = IntInput("\nEnter electronic's price: ");
        return new Electronics(name, price);
    }

    static Furniture FurnitureInput()
    {
        string name = StringInput("\nEnter furniture's name: ");
        int price = IntInput("\nEnter furniture price: ");
        return new Furniture(name, price);
    }


    public static void Run()
    {
        Electronics? electronic = null;
        Furniture? furniture = null;
        List<Product> products = new();

        while (true)
        {
            Console.WriteLine("\n1. Create an Electronic");
            Console.WriteLine("2. Create a furniture");
            Console.WriteLine("3. Calculate price");
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
                    electronic = ElectronicsInput();

                    if (electronic != null)
                    {
                        products.Add(electronic);
                    }
                }
                else if (userChoice == 2)
                {
                    furniture = FurnitureInput();

                    if (furniture != null)
                    {
                        products.Add(furniture);
                    }
                }
                else if (userChoice == 3)
                {
                    foreach (var product in products)
                    {
                        Console.WriteLine(product);
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid choice! Enter a number between 0-2!");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input! Enter a number!");
            }
        }
    }
}

using System.Numerics;
using System.Reflection;

namespace MainProgram.MoneyTask;

class Menu
{
    static int ReadIntInput(string prompt)
    {
        int result;
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (int.TryParse(input, out result))
            {
                return result;
            }
            Console.WriteLine("\nInvalid input. Please enter a number.");
        }
    }

    static char ReadCharInput(string prompt)
    {
        char result;
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int userChoice))
            {
                if (userChoice == 1)
                {
                    result = '$';
                    return result;
                }
                else if (userChoice == 2)
                {
                    result = '€';
                    return result;
                }
                else if (userChoice == 3)
                {
                    result = '₴';
                    return result;
                }
                else
                {
                    Console.WriteLine("\nInvalid choice! Enter a number between 1-3.");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input! Enter a number!");
            }
        }
    }

    static Money MoneyInput()
    {
        int whole = ReadIntInput("\nEnter a whole number (ex. 16): ");
        int fraction = ReadIntInput("\nEnter a fraction number (ex. 35): ");
        char symbol = ReadCharInput("\nChoose currency: \n" +
            "\n1. Dollar ($)" +
            "\n2. Euro (€)" +
            "\n3. Hryvnia (₴)" +
            "\nYour choice: ");
        return new Money(whole, fraction, symbol);
    }

    static Product ProductInput(Money price)
    {
        Console.Write("\nEnter product's name: ");
        string? name = Console.ReadLine();

        // if user enters null or empty, use default name
        if (string.IsNullOrWhiteSpace(name))
        {
            name = "Unnamed Product";
        }

        return new Product(name, price);
    }

    public static void Run()
    {
        Money? money = null;
        Product? product = null;

        while (true)
        {
            Console.WriteLine("\n1. Create a product");
            Console.WriteLine("2. Decrease Price");
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
                    money = MoneyInput();
                    money?.Show();

                    if (money != null)
                    {
                        product = ProductInput(money);
                        product.Show();
                    }
                }
                else if (userChoice == 2)
                {
                    if (product != null)
                    {
                        Console.WriteLine("\nEnter amount to decrease the price:");

                        Money? decreaseAmount = MoneyInput();
                        if (decreaseAmount != null)
                        {
                            product.DecreasePrice(decreaseAmount);
                            Console.WriteLine("\nPrice decreased. Updated product:");
                            product.Show();
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPlease create a product first.");
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

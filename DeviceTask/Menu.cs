namespace MainProgram.DeviceTask;

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

    static Device DeviceInput()
    {
        string name = StringInput("\nEnter device's name: ");
        string description = StringInput("\nEnter device's description: ");
        return new Device(name, description);
    }

    static Kettle KettleInput()
    {
        string name = StringInput("\nEnter kettle's name: ");
        string description = StringInput("\nEnter kettle's description: ");
        return new Kettle(name, description);
    }

    static Microwave MicrowaveInput()
    {
        string name = StringInput("\nEnter mircowave's name: ");
        string description = StringInput("\nEnter microwave's description: ");
        return new Microwave(name, description);
    }

    static Car CarInput()
    {
        string name = StringInput("\nEnter car's name: ");
        string description = StringInput("\nEnter car's description: ");
        return new Car(name, description);
    }

    static Streamship StreamshipInput()
    {
        string name = StringInput("\nEnter streamship's name: ");
        string description = StringInput("\nEnter streamship's description: ");
        return new Streamship(name, description);
    }

    public static void Run()
    {
        Device? device = null;
        Kettle? kettle = null;
        Microwave? microwave = null;
        Car? car = null;
        Streamship? streamship = null;

        while (true)
        {
            Console.WriteLine("\n1. Create a device");
            Console.WriteLine("2. Create a kettle");
            Console.WriteLine("3. Create a microwave");
            Console.WriteLine("4. Create a car");
            Console.WriteLine("5. Create a streamship");
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
                    device = DeviceInput();

                    if (device != null)
                    {
                        device.Show();
                        device.Sound();
                        device.Desc();
                    }
                }
                else if (userChoice == 2)
                {
                    kettle = KettleInput();

                    if (kettle != null)
                    {
                        kettle.Show();
                        kettle.Sound();
                        kettle.Desc();
                    }
                }
                else if (userChoice == 3)
                {
                    microwave = MicrowaveInput();

                    if (microwave != null)
                    {
                        microwave.Show();
                        microwave.Sound();
                        microwave.Desc();
                    }
                }
                else if (userChoice == 4)
                {
                    car = CarInput();

                    if (car != null)
                    {
                        car.Show();
                        car.Sound();
                        car.Desc();
                    }
                }
                else if (userChoice == 5)
                {
                    streamship = StreamshipInput();

                    if (streamship != null)
                    {
                        streamship.Show();
                        streamship.Sound();
                        streamship.Desc();
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid choice! Enter a number between 0-5!");
                }
            }
            else
            {
                Console.WriteLine("\nInvalid input! Enter a number!");
            }
        }
    }
}

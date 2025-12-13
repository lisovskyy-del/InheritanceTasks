namespace MainProgram.InstrumentTask;

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

    static MusicalInstrument MusicalInstrumentInput()
    {
        string name = StringInput("\nEnter the instrument's name: ");
        string description = StringInput("\nEnter the instrument's description: ");
        string history = StringInput("\nEnter the instrument's history: ");
        return new MusicalInstrument(name, description, history);
    }

    static Violin ViolinInput()
    {
        string name = StringInput("\nEnter violin's name: ");
        string description = StringInput("\nEnter violin's description: ");
        string history = StringInput("\nEnter violin's history: ");
        return new Violin(name, description, history);
    }

    static Trombone TromboneInput()
    {
        string name = StringInput("\nEnter trombone's name: ");
        string description = StringInput("\nEnter trombone's description: ");
        string history = StringInput("\nEnter trombone's history: ");
        return new Trombone(name, description, history);
    }

    static Ukulele UkuleleInput()
    {
        string name = StringInput("\nEnter ukulele's name: ");
        string description = StringInput("\nEnter ukulele's description: ");
        string history = StringInput("\nEnter ukulele's history: ");
        return new Ukulele(name, description, history);
    }

    static Violonchelo VioloncheloInput()
    {
        string name = StringInput("\nEnter violonchelo's name: ");
        string description = StringInput("\nEnter violonchelo's description: ");
        string history = StringInput("\nEnter violonchelo's history: ");
        return new Violonchelo(name, description, history);
    }

    public static void Run()
    {
        MusicalInstrument? instrument = null;
        Violin? violin = null;
        Trombone? trombone = null;
        Ukulele? ukulele = null;
        Violonchelo? violonchelo = null;

        while (true)
        {
            Console.WriteLine("\n1. Create a musical instrument");
            Console.WriteLine("2. Create a violin");
            Console.WriteLine("3. Create a trombone");
            Console.WriteLine("4. Create a ukulele");
            Console.WriteLine("5. Create a violonchelo");
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
                    instrument = MusicalInstrumentInput();

                    if (instrument != null)
                    {
                        instrument.Show();
                        instrument.Sound();
                        instrument.Desc();
                        instrument.History();
                    }
                }
                else if (userChoice == 2)
                {
                    violin = ViolinInput();

                    if (violin != null)
                    {
                        violin.Show();
                        violin.Sound();
                        violin.Desc();
                        violin.History();
                    }
                }
                else if (userChoice == 3)
                {
                    trombone = TromboneInput();

                    if (trombone != null)
                    {
                        trombone.Show();
                        trombone.Sound();
                        trombone.Desc();
                        trombone.History();
                    }
                }
                else if (userChoice == 4)
                {
                    ukulele = UkuleleInput();

                    if (ukulele != null)
                    {
                        ukulele.Show();
                        ukulele.Sound();
                        ukulele.Desc();
                        ukulele.History();
                    }
                }
                else if (userChoice == 5)
                {
                    violonchelo = VioloncheloInput();

                    if (violonchelo != null)
                    {
                        violonchelo.Show();
                        violonchelo.Sound();
                        violonchelo.Desc();
                        violonchelo.History();
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

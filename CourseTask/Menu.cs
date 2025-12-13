namespace MainProgram.CourseTask;

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

    static Course CourseInput()
    {
        string name = StringInput("\nEnter course's name: ");
        string duration = StringInput("\nEnter course's duration: ");
        return new Course(name, duration);
    }

    static OnlineCourse OnlineCourseInput()
    {
        string name = StringInput("\nEnter online course name: ");
        string platform = StringInput("\nEnter online course platform: ");
        string duration = StringInput("\nEnter online course duration: ");
        return new OnlineCourse(name, platform, duration);
    }

    public static void Run()
    {
        Course? course = null;
        OnlineCourse? onlineCourse = null;

        while (true)
        {
            Console.WriteLine("\n1. Create a course");
            Console.WriteLine("2. Create an online course");
            Console.WriteLine("0. Exit");
            Console.Write("Your choice: ");
            string? input = Console.ReadLine();

            if (int.TryParse(input, out int userChoice))
            {
                if (userChoice == 0)
                {
                    Console.WriteLine("\nExitting...");
                    break;
                }
                else if (userChoice == 1)
                {
                    course = CourseInput();

                    if (course != null)
                    {
                        Console.WriteLine(course);
                    }
                }
                else if (userChoice == 2)
                {
                    onlineCourse = OnlineCourseInput();

                    if (onlineCourse != null)
                    {
                        Console.WriteLine(onlineCourse);
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

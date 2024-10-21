public class program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Hello, please enter a number between 1 and 100.");
        Console.WriteLine();

        int userNumber = int.Parse(Console.ReadLine());

        if (userNumber >= 1 && userNumber <= 100)
        {



            if (userNumber < 60 && (userNumber % 2 != 0))
            {

                Console.WriteLine();
                Console.WriteLine("Thank you. You've picked " + userNumber);
                Console.WriteLine();

                Console.WriteLine(userNumber + " is odd and less than 60.");

            }

            else if (userNumber <= 24 && userNumber >= 2 && (userNumber % 2 == 0))
            {

                Console.WriteLine();
                Console.WriteLine("Thank you. You've picked " + userNumber);
                Console.WriteLine();
                Console.WriteLine(userNumber + " is Even and less than 25.");

            }

            else if (userNumber <= 60 && userNumber >= 26 && (userNumber % 2 == 0))
            {

                Console.WriteLine();
                Console.WriteLine("Thank you. You've picked " + userNumber);
                Console.WriteLine();
                Console.WriteLine(userNumber + " is Even and between 26 and 60, inclusive.");

            }

            else if (userNumber > 60 && (userNumber % 2 == 0))
            {

                Console.WriteLine();
                Console.WriteLine("Thank you. You've picked " + userNumber);
                Console.WriteLine();
                Console.WriteLine(userNumber + " is even and greater than 60.");

            }

            else if (userNumber > 60 && (userNumber % 2 != 0))
            {

                Console.WriteLine();
                Console.WriteLine("Thank you. You've picked " + userNumber);
                Console.WriteLine();
                Console.WriteLine(userNumber + " is odd and greater than 60 and.");

            }

        }

        else
        {
            Console.WriteLine();
            Console.WriteLine("The number you picked is outside the requested range! Get out of here immediately.");

        }


    }
}



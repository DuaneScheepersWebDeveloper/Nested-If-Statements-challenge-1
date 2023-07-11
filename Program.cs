namespace Nested_If_Statements_challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool loggedIn = false;
            string username = "";
            string password = "";

            Console.WriteLine("Welcome to the User Login System!");

            // Registration
            Console.WriteLine("\nRegistration");
            Console.Write("Enter a username: ");
            username = Console.ReadLine();

            Console.Write("Enter a password: ");
            password = Console.ReadLine();

            Console.WriteLine("\nRegistration Successful!");

            // Login
            Console.WriteLine("\nLogin");
            Console.Write("Enter your username: ");
            string inputUsername = Console.ReadLine();

            Console.Write("Enter your password: ");
            string inputPassword = Console.ReadLine();

            if (inputUsername == username && inputPassword == password)
            {
                Console.WriteLine("\nLogin Successful!");
                loggedIn = true;
            }
            else
            {
                Console.WriteLine("\nLogin Failed! Incorrect username or password.");
                loggedIn = false;
            }

            // Additional Program Logic
            if (loggedIn)
            {
                // Your additional program logic here after successful login
                Console.WriteLine("\nWelcome, " + username + "!");
            }
            else
            {
                // Your additional program logic here if login fails
                Console.WriteLine("\nAccess Denied. Exiting the program.");
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
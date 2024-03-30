namespace OOP_Assignment__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int attempts = 3;

            while (attempts > 0)
            {
                Console.Write("Input your username: ");
                string username = Console.ReadLine();

                Console.Write("Input your password: ");
                string password = Console.ReadLine();

                if (username == "Admin" && password == "Admin1234!")
                {
                    Console.WriteLine("Login succesful.");
                    break;
                }
                else
                {

                    attempts--;
                    if (attempts > 0)
                        Console.WriteLine("Incorrect credentials. Please try again.");
                    Console.WriteLine($"You have {attempts} attempts left.");
                }
            }
            if (attempts == 0)
            {
                Console.WriteLine("You've used your maximum login attempts.Try again in 5 minutes.");
            }
        }
    }
}
namespace GuessNr
{
    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("-----Menu------");
            Console.WriteLine("Press on 1 to look if the number is valied or not! ");
            Console.WriteLine("Press on 2 to guess until the number is valied!");
            Console.WriteLine("Press on 9 to exit!");
        }

        static void Valied()
        {
            int number = Convert.ToInt16(Console.ReadLine());
            if (number < 11)
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
        }

        static void Guess()
        {
            int number = Convert.ToInt16(Console.ReadLine());
            bool loop = true;
            while (loop)
            {
                if (number <= 10)
                {
                    Console.WriteLine("Yes it is valied.");
                    loop = false;
                }
                else
                {
                    Console.WriteLine("It is not a valied number, try again.");
                    number = Convert.ToInt16(Console.ReadLine());
                }
            }
           
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username: ");
            string? userName = Console.ReadLine();
            bool loop = true;
            do
            {
                try
                {
                    Console.Clear(); 
                    Menu();
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(userName + " get a number between 1-10");
                            Valied();
                            break;
                        case 2:
                            Console.WriteLine(userName + " guess a number between 1-10");
                            Guess();
                            break;
                        case 9:
                            loop = false;
                            Console.WriteLine("Welcome back");
                            break;
                        default:
                            Console.WriteLine("Somthings get wrong here!");
                            break;
                    }
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey(true);
                    Console.Clear();
                }
                catch (Exception)
                {
                    throw;
                }
            }while (loop);
        }
    }
}

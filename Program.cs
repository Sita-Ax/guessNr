namespace GuessNr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter username: ");
            string userName = Console.ReadLine();

            Console.WriteLine(userName + " get a number between 1-10");

            int number = Convert.ToInt16(Console.ReadLine());

             if(number < 11)
            {
                Console.WriteLine("Valid");
            }
             else if(number > 10)
            Console.WriteLine("Invalid");
        }
    }
}

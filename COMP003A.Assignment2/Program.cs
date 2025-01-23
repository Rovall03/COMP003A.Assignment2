namespace COMP003A.Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string firstName;
            string lastName;
            int age;
            double itemPrice;
            bool isStudent;

            Console.WriteLine("What is your first name? ");
            firstName = Console.ReadLine();

            
            Console.WriteLine("What is your last name? ");
            lastName = Console.ReadLine();

            Console.WriteLine("How old are you? ");
            age= int.Parse(Console.ReadLine());

            Console.WriteLine("What is the price of the item you're intrested in? ");
            itemPrice = double.Parse(Console.ReadLine());

            Console.WriteLine("Are you a student? (true/false): ");
            isStudent = bool.Parse(Console.ReadLine());

           
            int ageFuture = age + 5;

            double price = itemPrice * .9;
            double seniorPrice = itemPrice * .8;

            Console.WriteLine($"\n Hello {firstName} {lastName}! ");
            Console.WriteLine($" In 5 years, you will be {ageFuture}" );
            Console.WriteLine($"The original price of the item is {itemPrice.ToString("f2")}");
            Console.WriteLine($"As a Student, your discounted price is {price.ToString ("f2")}");
            Console.WriteLine($"As a senior citizen, your discount price would be {seniorPrice.ToString("f2")}");

        }
    }
}

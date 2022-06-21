namespace GenericsTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n1. Find maximum among three integers");

                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FindMaxNumber findMaxNumber = new FindMaxNumber();

                        //Max Number in First position
                        Console.WriteLine("Maximum integer is : " + findMaxNumber.MaxNumberInt(8, 6, 5));

                        //Max Number in Second position
                        Console.WriteLine("Maximum integer is : " + findMaxNumber.MaxNumberInt(6, 9, 7));

                        //Max Number in Third position
                        Console.WriteLine("Maximum integer is : " + findMaxNumber.MaxNumberInt(5, 7, 8));
                        break;
                    default:
                        Console.WriteLine("Please enter correct option from the list");
                        break;
                }
            } while (choice != 0);
        }
    }
    
}

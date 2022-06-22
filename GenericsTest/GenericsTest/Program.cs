namespace GenericsTest
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("\n1. Find maximum among Three Integers Values");
                Console.WriteLine("2. Find maximum among Three Floats Values");
                Console.WriteLine("2. Find maximum among Three String Values");
                Console.WriteLine("4. Find maximum among Int, Float, and String using Generic Method");

                Console.Write("Enter your choice : ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        FindMaxNumber findMaxNumber = new FindMaxNumber();

                        //TC1
                        Console.WriteLine("Maximum integer is : " + findMaxNumber.MaxNumberInt(8, 6, 5));

                        //TC@
                        Console.WriteLine("Maximum integer is : " + findMaxNumber.MaxNumberInt(6, 9, 7));

                        //TC3
                        Console.WriteLine("Maximum integer is : " + findMaxNumber.MaxNumberInt(5, 7, 8));
                        break;
                    case 2:
                        FindMaxFloats findMaxFloats = new FindMaxFloats();

                        //TC1
                        Console.WriteLine("Maximum float number is : " + findMaxFloats.MaxNumberFloat(8.7f, 6.4f, 5.8f));

                        //TC2
                        Console.WriteLine("Maximum float number is : " + findMaxFloats.MaxNumberFloat(6.4f, 9.1f, 7.3f));

                        //TC3
                        Console.WriteLine("Maximum float number is : " + findMaxFloats.MaxNumberFloat(5.5f, 7.3f, 8.4f));
                        break;
                    case 3:
                        FindMaxString findMaxString = new FindMaxString();

                        //TC1
                        Console.WriteLine("Maximum string is : " + findMaxString.MaxNumberString("8", "6", "5"));

                        //TC2
                        Console.WriteLine("Maximum string is : " + findMaxString.MaxNumberString("6", "9", "7"));

                        //TC3
                        Console.WriteLine("Maximum string is : " + findMaxString.MaxNumberString("5", "7", "8"));
                        break;
                    case 4:
                        GenericMethod genericMethod = new GenericMethod();

                        //TC Integer
                        Console.WriteLine("Maximum integer is : " + genericMethod.MaxAmongThree(8, 6, 5));
                        Console.WriteLine("Maximum integer is : " + genericMethod.MaxAmongThree(6, 9, 7));
                        Console.WriteLine("Maximum integer is : " + genericMethod.MaxAmongThree(5, 7, 8));

                        //TC Float
                        Console.WriteLine("Maximum float number is : " + genericMethod.MaxAmongThree(8.7f, 6.4f, 5.8f));
                        Console.WriteLine("Maximum float number is : " + genericMethod.MaxAmongThree(6.4f, 9.1f, 7.3f));
                        Console.WriteLine("Maximum float number is : " + genericMethod.MaxAmongThree(5.5f, 7.3f, 8.4f));

                        //TC String 
                        Console.WriteLine("Maximum string is : " + genericMethod.MaxAmongThree("8", "6", "5"));
                        Console.WriteLine("Maximum string is : " + genericMethod.MaxAmongThree("6", "9", "7"));
                        Console.WriteLine("Maximum string is : " + genericMethod.MaxAmongThree("5", "7", "8"));
                        break;
                    default:
                        Console.WriteLine("Please enter correct option from the list");
                        break;
                }
            } while (choice != 0);
        }
    }
    
}

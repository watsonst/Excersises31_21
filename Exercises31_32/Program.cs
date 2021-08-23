using System;

namespace Exercises31_32
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueOfUserIndex1();
        }


    public static void ValueOfUserIndex1()
    {
        string answer = string.Empty;

        do
        {
            int[] givenNumbersArray = { 2, 8, 0, 24, 51 };

            Console.Write("Enter an index of the array: ");
            string userInput = Console.ReadLine();
            int userIndex = Convert.ToInt32(userInput);

            try
            {
                int arrayElement = givenNumbersArray[userIndex];

                Console.WriteLine(value: $"The value at index {userInput} is {arrayElement}");
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"That is not a valid index.");
            }

            Console.Write("Would you like to continue? (y/n): ");
            answer = Console.ReadLine().ToLower();

            if (answer == "n")
            {
                Console.WriteLine("GoodBye!");
                break;
            }


        } while (answer == "y");

    }
}
 }
    

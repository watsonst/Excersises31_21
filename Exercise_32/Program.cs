using System;

namespace Exercise_32
{
    class program
    { 
    static void Main(string[] args)
    {
        IndexOfUserInput();
    }

    public static void IndexOfUserInput()
    {
        string answer = string.Empty;

        do
        {
            try 
            { 

            string[] givenNumbersArray = { "2", "8", "0", "24", "51" };

            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();
            int userIndex = Convert.ToInt32(userInput);

                if (userIndex.ToString() != "2" && userIndex.ToString() != "8" && userIndex.ToString() != "0" && userIndex.ToString() != "24" && userIndex.ToString() != "51")
                    {
                    Console.WriteLine($"That value cannot be found in the array");
                    }

                else
                    {
                     int arrayElement = Array.IndexOf(givenNumbersArray, userInput);
                     Console.WriteLine(value: $"The value {userInput} can be found at index {arrayElement}");
                    }
            }
            catch (FormatException ex)
            {
                    Console.WriteLine($"That value cannot be found in the array");
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
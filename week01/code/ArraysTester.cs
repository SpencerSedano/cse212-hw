using System.ComponentModel;
using System.Runtime;

public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}


        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");

        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
       
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
    /// <summary>
    /// This function will produce a list of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    private static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // To my understanding, I have a number and a length, I need to multiply the
        // number by the length to get the last number.
        // Then, I can reduce the number times the length until I get 0
        // or I can do the opposite, starting at 0, and go up till the number given by number * length

        // Creating my array of doubles
        var result = new double[length];

       // Because I will use the i variable to get the multiples, I need another variable to track 
       // the index, and because I have two loops, I am creating two variables
        int counterPositive = 0;
        int counterNegative = 0;

        // First, I will create a for loop for positive numbers
        if (number > 0)
        {
            // my i variable will loop through the multiples, it will add number to i each iteration
            for (double i = 0; i <= number * length; i += number)
            {
                // I do not need to add 0 to my iteration, so I skip it using continue
                if (i == 0)
                {
                    continue;
                }
                // counterPositive variable is keeping track of the index and incrementing by 1
                // through each iteration
                result[counterPositive] = i;
                counterPositive++;
            }
        }  

        // I create a for loop for negative numbers
        if (number < 0)
        {
            // my i variable will loop through the multiples, it will add number to i each iteration
            // NOTE: Because it's a negative number, the i will be greater than number * length
            // and there is no need to write i -= number, because number is already negative 
            // if I write i -= number, we'll get a positive number in the result.
            for (double i = 0; i >= number * length; i += number)
            {
                // I do not need to add 0 to my iteration, so I skip it using continue
                if (i == 0)
                {
                    continue;
                }
                // counterPositive variable is keeping track of the index and incrementing by 1
                // through each iteration
                result[counterNegative] = i;
                counterNegative++;
            }
        } 

        // Returning my array of doubles
        return result;
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    private static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // I have a list of integers and an integer as parameters (data, amount)

        // Edge cases, when there is no need to rotate, this will return the same list. For example,
        // if the amount is the same as the data.Count, it will return the same list.
        amount %= data.Count;
        if (amount == 0)
        {
            return;
        } 

        // Getting the correct position to get the range
        int startIndex = data.Count - amount;
        List<int> sublist = data.GetRange(startIndex, amount);

        // Insert the sublist at the beginning of the original list
        data.InsertRange(0, sublist);


        // Delete the remainder elements of the list (I am removing the original elements of sublist because I already added the sublist at the beginning)
        // I added removingRange variable to count again because a new set of numbers have been added to the list
        int removingRange = data.Count - amount;
        data.RemoveRange(removingRange, amount);

    }
}

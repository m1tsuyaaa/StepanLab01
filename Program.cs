using System;

class Program
{
    static void Main()
    {
        int baseNumber, exponent, powerResult, secondCharIndex, startCounter, initialValue, originalNumber, transformedNumber;
        string numberString, resultString;

        secondCharIndex = 1;
        startCounter = 0;
        initialValue = 1;

        Console.WriteLine("=== Task 1: Power calculation ===");

        Console.Write("Enter base number: ");
        baseNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter exponent: ");
        exponent = Convert.ToInt32(Console.ReadLine());

        if (baseNumber <= 0 || exponent <= 0)
        {
            Console.WriteLine("\nError: Both numbers must be natural (greater than zero)");
        } else {
            powerResult = initialValue;

            for (int counter = startCounter; counter < exponent; ++counter)
            {
                powerResult = powerResult * baseNumber;
            }

            Console.WriteLine($"\nResult: {baseNumber}^{exponent} = {powerResult}");
        }

        Console.WriteLine("\n=== Task 2: Number transformation ===");

        Console.Write("Enter number (must be >= 100): ");
        originalNumber = Convert.ToInt32(Console.ReadLine());

        if (originalNumber < 100)
        {
            Console.WriteLine("\nError: Input number must be >= 100 and contain more than two digits");
        } else {
            numberString = originalNumber.ToString();
            resultString = numberString.Remove(secondCharIndex, 1) + numberString[secondCharIndex];
            transformedNumber = int.Parse(resultString);

            Console.WriteLine($"\nOriginal number: {originalNumber}");
            Console.WriteLine($"Transformed number: {transformedNumber}");
        }
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
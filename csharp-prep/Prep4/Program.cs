using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
     

        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        
        List <int> numbers = new List<int>();

        int promptNumber = -1;
        while (promptNumber != 0) 
        {
            Console.Write("Enter a number: ");
            string askNumber = Console.ReadLine();
            promptNumber = int.Parse(askNumber);

            if (promptNumber != 0) 
            {
                numbers.Add(promptNumber);
            }
           


        } 

        int total = 0;
        int minNumber = 9999;
        foreach (int number in numbers) 
        {
            total += number;
            if (minNumber>number && number>0)
            {
                minNumber = number;
            }
        
        }
        Console.WriteLine($"The sum is: {total}");

        float ave = ((float)total)/numbers.Count();
        Console.WriteLine($"The average is: {ave}");

        int maxNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {maxNumber}");

        Console.WriteLine($"The smallest positive number is: {minNumber}");

        

        

        
        

    }
}
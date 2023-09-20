using System;

class Program
{
    static void Main(string[] args)
    {
        //Random Class
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        bool myBool = false;
        int count = 0;
        //Prompt
        
        while (myBool == false)
        {
            Console.Write("What is the magic number? ");
            string askNumber = Console.ReadLine();
            int promptNumber = int.Parse(askNumber);



            //Operation 

            if (promptNumber == number) 
            {
                Console.WriteLine("You have guessed the magic number!");
                myBool = true;
                count += 1;
            }
            else if (promptNumber < number) 
            {
                Console.WriteLine("Higher");
                count += 1;

            }
            else if (promptNumber > number) 
            {
                Console.WriteLine("Lower");
                count += 1;
            }
        } 

        Console.WriteLine($"You had {count} guesses!");
        
    } 
        




    
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        
        DisplayResult(name,squareNumber);



        //display "Welcome to the Program"
        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the Program!");

        }
        //prompting for name
        static string PromptUserName () 
        {
            Console.WriteLine("What is your name? ");
            string promptName = Console.ReadLine();
            return promptName;
            
        }
        //prompting for favourite number
        static int PromptUserNumber ()
        {
            Console.Write("What is your favorite number? ");
            string number = Console.ReadLine();
            int promptNumber = int.Parse(number);
            return promptNumber;
        }

        //square number
        static int SquareNumber (int number)
        {
            
            int promptNumber = number * number;
            return promptNumber;

        }
        //Display Result
        static void DisplayResult (string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is: {squaredNumber}");
        }
    }
}
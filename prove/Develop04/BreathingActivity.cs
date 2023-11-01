public class BreathingActivity : Activity
{

    public BreathingActivity(int duration) : base(duration)
    {
        BreatheActivity(duration);
        
    }

    public void BreatheActivity(int duration)
    {
        int remainder = duration % 10;
        int times = duration - remainder;

        Console.Clear();
        Console.WriteLine("Get Ready");

        StringSpinner();
        Console.WriteLine("\n");

        if (remainder > 5)
        {
            BreatheFiveIn();
            BreatheFiveOut();
            Console.WriteLine("\n");
        }

        while (times != 0)
        {
            BreatheIn();
            BreatheOut();
            Console.WriteLine("\n");
            times -= 10;

        }
       

    }


    public static void BreatheIn()
    {


        Console.Write("Breathe in....");
        for (int i = 4; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Write("\n");


    }

    public static void BreatheOut()
    {
        Console.Write("Now breathe out....");
        for (int i = 6; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public static void BreatheFiveIn()
    {
        Console.Write("Breathe in....");
        for (int i = 2; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Write("\n");
    }

    public static void BreatheFiveOut()
    {
        Console.Write("Now breathe out....");
        for (int i = 3; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }




}
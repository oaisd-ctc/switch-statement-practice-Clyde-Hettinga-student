public class Program
{
    static int number;

    public static void Main()
    {
        InputProcess();
        Convert(number);
    }

    public static void InputProcess()
    {
        Console.WriteLine("Enter a number 0-10");
        number = TakeNumber();
        while (!(number >= 0 && number <= 10))
        {
            Console.WriteLine("That's not in range. Try again.");
            number = TakeNumber();
        }
    }

    public static int TakeNumber()
    {
        string input = Console.ReadLine();
        int num = int.Parse(input);
        return num;
    }

    public static void Convert(int num)
    {
        string converted = "";
        
        if (num == 0)
            converted = "zero";
        else if (num == 1)
            converted = "one";
        else if (num == 2)
            converted = "two";
        else if (num == 3)
            converted = "three";
        else if (num == 4)
            converted = "four";
        else if (num == 5)
            converted = "five";
        else if (num == 6)
            converted = "six";
        else if (num == 7)
            converted = "seven";
        else if (num == 8)
            converted = "eight";
        else if (num == 9)
            converted = "nine";
        else if (num == 10)
            converted = "ten";

        Console.WriteLine($"Your number is {converted}.");
    }
}
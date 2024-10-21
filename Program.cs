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
        
        switch (num)
        {
            case 0:
                converted = "zero";
                break;
            case 1:
                converted = "one";
                break;
            case 2:
                converted = "two";
                break;
            case 3:
                converted = "three";
                break;
            case 4:
                converted = "four";
                break;
            case 5:
                converted = "five";
                break;
            case 6:
                converted = "six";
                break;
            case 7:
                converted = "seven";
                break;
            case 8:
                converted = "eight";
                break;
            case 9: 
                converted = "nine";
                break;
            case 10:
                converted = "ten";
                break;
        }

        Console.WriteLine($"Your number is {converted}.");
    }
}
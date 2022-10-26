namespace Exercise_1;

static class Program
{
    public static void Main(string[] args)
    {
        int x = 0;
        bool isValid = true;
        try
        {
            Console.WriteLine("Enter a score: ");
            x = int.Parse(Console.ReadLine() ?? String.Empty);
        }
        catch (FormatException)
        {
            isValid = false;
            Console.WriteLine("Invalid format score");
        }
        catch (OverflowException)
        {
            isValid = false;
            Console.WriteLine("Score is too large");
        }
        finally
        {
            if (isValid)
                Console.WriteLine("Score is: " + x);
        }
    }
}
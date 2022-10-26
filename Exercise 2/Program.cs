namespace Exercise_2;

static class Program
{
    public static void Main(string[] args)
    {
        var list = new List<string>();
        try
        {
            var streamReader = new StreamReader("TextFile.txt");
            while (!streamReader.EndOfStream)
            {
                var line = streamReader.ReadLine();
                if (line == null) continue;
                list.Add(line);
            }

            var i = 1;
            foreach (var line in list)
            {
                if (i % 2 == 0)
                    Console.WriteLine(line);
                i++;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
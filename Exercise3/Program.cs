namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение а: ");
            string? a = Console.ReadLine();
            int num1 = Convert.ToInt32(a);

            if (num1 % 2 == 0)
            {
                Console.WriteLine(num1 + " - чётное");
            }
            else
            {
                Console.WriteLine(num1 + " - нечётное");
            }
        }
    }
}
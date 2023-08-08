namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max;

            Console.WriteLine("Введите значение а: ");
            string? a = Console.ReadLine();
            int num1 = Convert.ToInt32(a);

            Console.WriteLine("Введите значение b: ");
            string? b = Console.ReadLine();
            int num2 = Convert.ToInt32(b);

            Console.WriteLine("Введите значение c: ");
            string? c = Console.ReadLine();
            int num3 = Convert.ToInt32(c);

            if (num1 > num2 && num1 > num3)
            {
                max = num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
                
            Console.WriteLine("Максимальное значение равно " + max);
        }
    }
}
namespace Exercise1
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

            if (num1 > num2)
            { 
                max = num1;
            }
            else
            {
                max = num2;
            } 

            Console.WriteLine("Максимальное значение равно " + max);
        }        
    }

    
}
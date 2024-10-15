namespace Lab2_ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hình a:");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nHình b:");
            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nHình c:");
            int n = 5; // Số dòng của tam giác
            for (int i = 1; i <= n; i++)
            {
                // In khoảng trắng
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write("  ");
                }
                // In dấu *
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}

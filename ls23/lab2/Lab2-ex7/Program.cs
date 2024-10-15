namespace Lab2_ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10; // Số dòng của tam giác

            for (int i = 1; i <= n; i++)
            {
                // In khoảng trắng để căn giữa
                for (int j = 1; j <= n - i; j++)
                {
                    Console.Write(" ");
                }

                // In các số tăng dần
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(k);
                }

                // In các số giảm dần
                for (int l = i - 1; l >= 1; l--)
                {
                    Console.Write(l);
                }
                Console.WriteLine();
            }
        }
    }
}

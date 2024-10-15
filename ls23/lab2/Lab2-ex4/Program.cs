namespace Lab2_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Các số có 3 chữ số mà tổng các chữ số là chẵn:");

            for (int i = 100; i <= 999; i++)
            {
                int hangTram = i / 100;
                int hangChuc = (i / 10) % 10;
                int hangDonVi = i % 10;

                if ((hangTram + hangChuc + hangDonVi) % 2 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

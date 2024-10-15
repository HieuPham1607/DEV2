namespace lab2_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập năm: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Nhập tháng (1-12): ");
            int y = int.Parse(Console.ReadLine());

            // Kiểm tra tính hợp lệ của tháng
            if (y < 1 || y > 12)
            {
                Console.WriteLine("Tháng không hợp lệ. Vui lòng nhập từ 1 đến 12.");
                return;
            }

            // Xác định số ngày trong tháng
            int days = DateTime.DaysInMonth(x, y);

            Console.WriteLine("Tháng {0} năm {1} có {2} ngày.", y, x, days);
        }
    }
}

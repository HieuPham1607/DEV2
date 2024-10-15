namespace Lab2_ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số tiền gửi ban đầu: ");
            double soTienGui = double.Parse(Console.ReadLine());

            Console.Write("Nhập lãi suất hàng năm (%): ");
            double laiSuatNam = double.Parse(Console.ReadLine());

            Console.Write("Nhập số tháng gửi: ");
            int soThangGui = int.Parse(Console.ReadLine());

            // Tính lãi suất hàng tháng
            double laiSuatThang = (laiSuatNam / 12) / 100;

            // Khởi tạo số dư hiện tại
            double soDuHienTai = soTienGui;

            // Tính lãi và cập nhật số dư qua từng tháng
            for (int i = 1; i <= soThangGui; i++)
            {
                double tienLaiThang = soDuHienTai * laiSuatThang;
                soDuHienTai += tienLaiThang;

                Console.WriteLine($"Tháng {i}: Tiền lãi = {tienLaiThang:C}, Số dư = {soDuHienTai:C}");
            }

            // In kết quả cuối cùng
            Console.WriteLine("\nSố dư cuối kỳ: {0:C}", soDuHienTai);
            Console.WriteLine("Tiền lãi cuối kỳ: {0:C}", soDuHienTai - soTienGui);
        }
    }
}

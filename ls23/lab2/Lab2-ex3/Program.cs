namespace Lab2_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập số giây: ");
            int soGiay = int.Parse(Console.ReadLine());

            // Tính toán giờ, phút, giây
            int gio = soGiay / 3600;
            int phut = (soGiay % 3600) / 60;
            int giayConLai = soGiay % 60;

            // In kết quả
            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", gio, phut, giayConLai);
        }
    }
}

namespace Lab1_1
/// <summary>
/// Author : Phạm Hiệu
/// Date : 14/10/2024
/// Chương trình C# đầu tiên
/// In ra nội dung thông tin giới thiệu về bản thân
/// </summary>

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Lệnh in ra màn hình dòng văn bản sau đó xuống dòng
            Console.WriteLine("Họ và tên : Phạm Quốc Hiệu!");
            // Lệnh in ra có định dạng
            Console.WriteLine("Ngày sinh: {0}", "16/07/2003");
            Console.Write("Địa chỉ: Tầng 6, Số 25 Phố Vũ Ngọc Phan  \n");
            Console.WriteLine("Điện thoại: 0969670959");
            Console.WriteLine("Email:Phamhiuhiu01@gmail.com");

        }
    }
}


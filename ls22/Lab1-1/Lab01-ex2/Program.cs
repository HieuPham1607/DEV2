namespace Lab01_ex2
/// <summary>
/// Author : Phạm Hiệu
/// Date : 14/10/2024
/// Chương trình C# đầu tiên
/// </summary>
//Viết chương trình thực hiện các yêu cầu sau
//- Khai báo các biến để lưu trữ thông tin của Nhân Viên bao gồm:
//o Mã Nhân viên
//o Họ tên nhân viên
//o Ngày sinh
//o Địa chỉ
//o Điện thoại
//o Email
//- Gán giá trị cho các biến
//- Hiển thị trên màn hình thông tin của nhân viên

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Xuất có unicode
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Viết chương trình thực hiện yêu cầu sau");
            //khai báo biến
            string maNV;
            string HoVaTen;
            DateTime ngaysinh;
            string diaChi;
            string dienThoai;
            string email;

            //Gán giá trị
            maNV = "NV001";
            HoVaTen = "Phạm Quốc Hiệu";
            ngaysinh = DateTime.Now;
            diaChi = "Nhị Khê";
            dienThoai = "0969670959";
            email = "Phamhiuhiu01@gmail.com";


            //Hiển thị thông tin
            Console.WriteLine("===== Thông tin cá nhân");
            Console.WriteLine("Mã nhân viên",maNV);
            Console.WriteLine("Họ tên nhân viên",HoVaTen);
            Console.WriteLine("Ngày sinh",ngaysinh);
            Console.WriteLine("Địa chỉ",diaChi);
            Console.WriteLine("Điện thoại", dienThoai);
            Console.WriteLine("email",email);
        }
    }
}

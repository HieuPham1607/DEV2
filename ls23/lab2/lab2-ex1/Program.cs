namespace lab2_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            // Khai bao bien
            string ID;
            string Name;
            DateTime Birthday;
            string Address;
            double Salary ;
            double Bonus;

            //  Gán giá trị
            ID = "NV001";
            Name = "Hiệu";
            Birthday = new DateTime(2003,07,16);
            Address = "Số 25 Phố Vũ Ngọc Phan";
            Salary = 20000;
            Bonus = 10;

            // Hiển thị thông tin
            Console.WriteLine("===== THÔNG TIN CÁ NHÂN");
            Console.WriteLine("Mã nhân viên:" + ID);
            Console.WriteLine("Họ và tên:{0}", Name);
            Console.WriteLine("Ngày sinh:{0:dd/MM/yyyy}", Birthday);
            Console.WriteLine("Đia chỉ: " , Address);
            Console.WriteLine("Lương:" + Salary);
            Console.WriteLine("Email: {0}", Bonus);

        }
    }
}

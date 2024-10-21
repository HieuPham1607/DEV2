namespace Lab5
    ///<summary>
    ///Một số thao tác với mảng một chiều
    ///</summary>
    ///<param name = "args" ></ param >
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khai báo và khởi tạo mảng 1 chiều
            int[] m = { 1,2,3,3,2,1 };
            //duyệt mảng và ỉn a dữ liệu
            Console.Write("Cac phan tu cua mang");
            for (int i = 0; i < m.Length; i++) { 
                Console.Write(" {0} ", m[i]);
            }
            //Tìm phần tử lớn nhất
            int max = m[0];
            for (int i = 1; i < m.Length; i++) { 
                if (max < m[i])
                    max = m[i];
            }
            Console.WriteLine("\nPhan tu lon nhat:" + max);
            //Kiểm tra mảng có đối xứng không?
            bool kt = true;
            for (int i = 0; i < m.Length / 2; i++) { 
                if (m[i] != m[m.Length - 1 - i])
                {
                    kt = false;
                    break;
                }
            }
            if (kt)
                Console.WriteLine("Mang doi xung");
            else
                Console.WriteLine("Mang khong doi xung");
        }
    }
}

namespace Lab4_3
{
    //định nghĩa lớp trừu tượng
    abstract class Shape
    {
        protected float radius, length, width;
        //Khai báo các phương thức trừu tượng
        public abstract float Area();//tính diện tích
        public abstract float Circumference();//tính chu vi
    }
    class Circle : Shape
    {
        //phương thức nhập liệu
        public void InputData()
        {
            Console.Write("Nhap ban kinh:");
            radius = int.Parse(Console.ReadLine());
        }
        //ghi đè phương thức tính diện tích
        public override float Area()
        {
            return 3.14F * radius * radius;
        }
        //ghi đè phương thức tính chu vi
        public override float Circumference()
        {
            return 2 * 3.14F * radius;
        }
    }
    class Rectangle : Shape
    {
        //phương thức nhập liệu
        public void InputData()
        {
            Console.Write("Nhap chieu dai:");
            length = int.Parse(Console.ReadLine());
            Console.Write("Nhap chieu rong:");
            width = int.Parse(Console.ReadLine());
        }
        //ghi đè phương thức tính diện tích
        public override float Area()
        {
            return length * width;
        }
        //ghi đè phương thức tính chu vi
        public override float Circumference()
        {
            return 2 * length * width;
        }
        static void Main(string[] args)
        {
            //Khởi tạo hình chữ nhật
            Rectangle rec = new Rectangle();
            //nhập dữ liệu
            rec.InputData();
            //in thông tin
            Console.WriteLine("Dien tich hinh chu nhat la:{0:N}", rec.Area());
            Console.WriteLine("Chu vi hinh chu nhat la:{0:N}", rec.Circumference());
            //Khởi tạo hình tròn
            Circle cir = new Circle();
            //nhập dữ liệu
            cir.InputData();
            //in thông tin
            Console.WriteLine("Dien tich hinh tron la:{0:N}", cir.Area());
            Console.WriteLine("Chu vi hinh tron la:{0:N}", cir.Circumference());
        }
    }

}

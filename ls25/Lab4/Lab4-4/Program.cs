namespace Lab4_4
{
    //định nghĩa giao diện
    interface IPerson
    {
        //phương thức insert
        void Insert(object obj);
        //phương thức xóa
        void Delete(object obj);
        //phương thức sửa
        void Update(object obj);
        //phương thức hiển thị
        void Display(object obj);
    }
    class Staff : IPerson
    {
        //thực thi các phương thức của giao diện
        public void Insert(object obj)
        {
            Console.WriteLine("Da luu doi tuong: " + obj);
        }
        public void Delete(object obj)
        {
            Console.WriteLine("Da xoa doi tuong: " + obj);
        }
        public void Update(object obj)
        {
            Console.WriteLine("Da cap nhat doi tuong: " + obj);
        }
        public void Display(object obj)
        {
            Console.WriteLine("Thong tin doi tuong: " + obj);
        }
    }
    class Student : IPerson
    {
        //khai báo thuộc tính
        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        //thực thi các phương thức từ giao diện
        public void Insert(object obj)
        {
            Console.WriteLine("Da luu doi tuong: " + obj);
        }
        public void Delete(object obj)
        {
            Console.WriteLine("Da xoa doi tuong: " + obj);
        }
        public void Update(object obj)
        {
            Console.WriteLine("Da cap nhat doi tuong: " + obj);
        }
        public void Display(object obj)
        {
            Student st = (Student)obj;
            Console.WriteLine("Id:" + st.Id);
            Console.WriteLine("Name:" + st.Name);
            Console.WriteLine("Age:" + st.Age);
        }
        static void Main(string[] args)
        {
            //Tạo một nhân viên
            IPerson staff = new Staff();
            object data = "Đại học nguyễn trãi";
            //gọi các hành động
            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Display(data);
            //tạo sinh viên
            IPerson student = new Student()
            {
                Id = "S10",
                Name = "Hiệu",
                Age = 20
            };
            //hiển thị dữ liệu
            student.Display(student);
        }
    }
}

using System.Text;

namespace Lab_Extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tạo ứng dụng C# và thực hiên những công việc sau.");
            // Tạo một mảng Student với kích thước 3
            Student[] students = new Student[10];



            int chon = 0;

            do
            {

                menu();
                Console.Write("Mời bạn chọn");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("1- Khởi tạo một mảng 1 chiều gồm 10 phần tử Student.");
                        InitializeStudents(students);
                        DisplayStudents(students);
                        Console.WriteLine("Mảng Student đã được khởi tạo.");
                        break;
                    case 2:
                        Console.WriteLine("2- Tìm phần tử student có tuổi nhỏ nhất của mảng.");
                        Student youngest = FindYoungestStudent(students);
                        Console.WriteLine($"Sinh viên có tuổi nhỏ nhất là: {youngest.Name}, Tuổi: {youngest.Age}");
                        break;
                    case 3:
                        Console.WriteLine("3- Sắp xếp mảng tăng dần theo tuổi sinh viên (student).");
                        Array.Sort(students, (s1, s2) => s1.Age.CompareTo(s2.Age));
                        Console.WriteLine("Mảng đã được sắp xếp theo tuổi sinh viên.");
                        DisplayStudents(students);
                        break;
                    case 4:
                        Console.WriteLine("4- Tìm sinh viên có tuổi lớn nhất.");
                        Student oldest = FindOldestStudent(students);
                        Console.WriteLine($"Sinh viên có tuổi lớn nhất là: {oldest.Name}, Tuổi: {oldest.Age}");
                        break;
                    case 5:
                        Console.WriteLine("8- Kết thúc.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Bạn chọn sai chức năng.");
                        break;
                }
                Console.WriteLine();
            } while (true);

        }
        static void menu()
        {
            Console.WriteLine
                (
                "1- Khởi tạo một mảng 1 chiều gồm 10 phần tử Student.\r\n" +
                "2- Tìm phần tử student có tuổi nhỏ nhất của mảng.\r\n" +
                "3- Sắp xếp mảng tăng dần theo tuổi sinh viên (student).\r\n" +
                "4- Tìm sinh viên có tuổi lớn nhất.\r\n" +
                "5- Kết thúc\n" 
                );

        }
        static void InitializeStudents(Student[] students)
        {
            // Khởi tạo từng đối tượng Student
            students[0] = new Student(1, "Nguyen", 20);
            students[1] = new Student(2, "Tuan", 22);
            students[2] = new Student(3, "Anh", 19);
            students[3] = new Student(4, "Linh", 21);
            students[4] = new Student(5, "Hoang", 23);
            students[5] = new Student(6, "Mai", 20);
            students[6] = new Student(7, "Hoa", 18);
            students[7] = new Student(8, "Khanh", 24);
            students[8] = new Student(9, "Binh", 20);
            students[9] = new Student(10, "Duc", 25);
            // Khởi tạo mảng với dữ liệu mẫu
            //for (int i = 0; i < students.Length; i++)
            //{
            //    students[i] = new Student(i + 1, $"Student {i + 1}", 18 + i); // Giả sử tuổi từ 18 trở lên
            //}
        }

        static Student FindYoungestStudent(Student[] students)
        {
            Student youngest = students[0];
            foreach (var student in students)
            {
                if (student.Age < youngest.Age)
                {
                    youngest = student;
                }
            }
            return youngest;
        }

        static Student FindOldestStudent(Student[] students)
        {
            Student oldest = students[0];
            foreach (var student in students)
            {
                if (student.Age > oldest.Age)
                {
                    oldest = student;
                }
            }
            return oldest;
        }

        static void DisplayStudents(Student[] students)
        {
            Console.WriteLine("Danh sách sinh viên:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}


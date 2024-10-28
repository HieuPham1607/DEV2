using System.Collections;

namespace Lab9
{
    internal class Program
    {
        //1
        public interface IStudent
        {
            int StudID { get; set; }
            string StudName { get; set; }
            string StudGender { get; set; }
            int StudAge { get; set; }
            string StudClass { get; set; }
            float StudAvgMark { get;}

            void Print();
        }
        //3
        public static Hashtable studentTable = new Hashtable();
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Insert new student...");
                Console.WriteLine("2. Display all the student List...");
                Console.WriteLine("3. Calculator average mark....");
                Console.WriteLine("4. Exit.");

                Console.WriteLine("Option: ");
                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        CreateStudent();
                        break;
                    case "2":
                        PrintAllStudents();
                        break;
                    case "3":
                        CalculateAllStudentsAvg();
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void CreateStudent()
        {
            Student student = new Student();

            Console.WriteLine("Enter Student ID:");
            student.StudID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name:");
            student.StudName = Console.ReadLine();

            Console.WriteLine("Enter Student Gender:");
            student.StudGender = Console.ReadLine();

            Console.WriteLine("Enter Student Age:");
            student.StudAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Class:");
            student.StudClass = Console.ReadLine();

            Console.WriteLine("Enter 3 marks:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter mark {i + 1}:");
                student[i] = int.Parse(Console.ReadLine());
            }

            student.CalAvg();
            studentTable.Add(student.StudID, student);

            Console.WriteLine("Student added successfully!");

            student.Print();
        }

        public static void PrintAllStudents()
        {
            foreach (DictionaryEntry entry in studentTable)
            {
                Student student = (Student)entry.Value;
                student.Print();
            }
        }

        public static void CalculateAllStudentsAvg()
        {
            foreach (DictionaryEntry entry in studentTable)
            {
                Student student = (Student)entry.Value;
                student.CalAvg();
                Console.WriteLine($"Updated Average Mark for Student ID {student.StudID}: {student.StudAvgMark}");
            }
        }
        }
    }

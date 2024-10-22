using System.Collections;

namespace Lab6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo Arraylist");
            //Khởi tạo
            ArrayList arraylist = new ArrayList();

            //Thêm các phân tử
            //Add
            arraylist.Add(111);
            arraylist.Add("Hiệu Hiệu");

            // AddRange
            string[] strs = { "Tùng" , "Cúc" , "Trúc" , "Mai" };
            arraylist.AddRange(strs);

            //In mảng 
            printArray(arraylist);

            //Insert
            arraylist.Insert(0, "Devmaster");
            printArray(arraylist);

            // remove
            arraylist.Remove("Devmaster");
            printArray( arraylist);

            arraylist.RemoveAt(1);
            printArray(arraylist);

            //sort
            arraylist.AddRange(strs);
            printArray(arraylist);
            arraylist.Sort();
            printArray(arraylist);
        }

        static void printArray(ArrayList arraylist)
        {
            Console.WriteLine("Danh sách các phần tử");
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
        }
    }
}

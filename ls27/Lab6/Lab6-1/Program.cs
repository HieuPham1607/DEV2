using System.Collections;

namespace Lab6_1
{
    internal class Program
    {
        //tạo lớp Product
        class Product
        {
            //khai báo trường
            string name;
            double cost;
            int onhand;
            //constructor
            public Product(string n, double c, int h)
            {
                name = n;
                cost = c;
                onhand = h;
            }
            //ghi đè phương thức
            public override string ToString()
            {
                return String.Format("{0,-10}Cost: {1,6:C} On hand: {2}", name,
                cost, onhand);
            }
        }
        static void Main(string[] args)
        {
            //tạo ArrayList
            ArrayList inv = new ArrayList();
            //thêm phần tử vào dánh sách
            inv.Add(new Product("A", 5.9, 3));
            inv.Add(new Product("B", 8.2, 2));
            inv.Add(new Product("C", 3.5, 4));
            inv.Add(new Product("D", 1.8, 8));
            //in ra danh sách phần tử
            Console.WriteLine("Product list:");
            foreach (Product i in inv)
            {
                Console.WriteLine(" " + i);
            }
        }


    }
}

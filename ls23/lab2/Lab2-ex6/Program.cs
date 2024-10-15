namespace Lab2_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Write("Nhập cạnh a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Nhập cạnh b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Nhập cạnh c: ");
            int c = int.Parse(Console.ReadLine());

            // Kiểm tra điều kiện để tạo thành tam giác
            if (a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a)
            {
                // Là tam giác
                Console.WriteLine("a, b, c là độ dài 3 cạnh của một tam giác.");

                // Kiểm tra loại tam giác
                if (a == b && b == c)
                {
                    Console.WriteLine("Tam giác đều");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Tam giác cân");
                }
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    Console.WriteLine("Tam giác vuông");
                }
                else
                {
                    Console.WriteLine("Tam giác thường");
                }
            }
            else
            {
                Console.WriteLine("a, b, c không phải là độ dài 3 cạnh của một tam giác.");
            }
            
        }
    }
}

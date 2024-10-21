namespace Lab5_2
///<summary>
///Chương trình minh họa một số thao tác trên mảng 2 chiều
///</summary>
/// <param name = "args" ></ param >
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            int[,] arrays = {
                {4, 6, 9 },
                {2, 4, 5 },
                {9, 2, 6 },
                {1, 6, 3 }
            };
            //Duyệt mảng và in
            prinArray(arrays);
            prinArrayXY(arrays);
        }
        static void prinArray(int[,] arrays) {
            Console.WriteLine("Cac phan tu trong mang");
            for (int i = 0; i <= arrays.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= arrays.GetUpperBound(1); j++) 
                {
                    Console.Write(" {0} ", arrays[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void prinArrayXY(int[,] arrays) 
        {
            Console.WriteLine("Cac phan tu lon nhat trn hang");
            for (int i = 0; i <= arrays.GetUpperBound(0); i++)
            {
                int max = arrays[i, 0];
                for (int j = 1; j <= arrays.GetUpperBound(1); j++)
                {
                    if (arrays[i, j] > max)
                        max = arrays[i, j];
                }
                Console.WriteLine("Hang {0}:{1}", i, max);
            } 
                
        }
    }
}

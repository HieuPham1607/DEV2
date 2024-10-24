namespace Lab7_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Tạo mới đối tượng House trong namespace Business
           //bạn có thể using ở trên đầu tệp tin để viết ngắn gọc hơn
           Business.House h = new Business.House();
            //gán thông tin
            h.HouseNo = "D294FF";
            h.Price = 425880;
            //in thông tin
            Console.WriteLine("House detail");
            Console.WriteLine("\t House No:" + h.HouseNo);
            Console.WriteLine("\t Price:" + h.Price);
            //Tạo mới đối tượng car trong namespace Business.Dealership
            //Ban có thể using ở trên đầu tệp tin để viết ngắn gọn hơn
            Business.Dealership.Car c = new Business.Dealership.Car();
            c.CarNo = "A0999";
            c.Price = 38425.50M;
            //in thông tin
            Console.WriteLine("Car detail");
            Console.WriteLine("\t Car No: " + h.HouseNo);
            Console.WriteLine("\t Price:" + h.Price);
        }
    }
}

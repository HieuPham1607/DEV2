namespace Lab7_ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();

            Console.Write("Nhap ID:{0}", st.id);
            st.id = (Console.ReadLine());

            Console.Write("Nhap Name:{0}", st.name);
            st.name = (Console.ReadLine());

            Console.Write("Nhap diem ly thuyet:", st.theorymark);
            st.theorymark = Convert.ToByte(Console.ReadLine());

            Console.Write("nhap diem thuc hanh:", st.labmark);
            st.labmark = Convert.ToInt32(Console.ReadLine());

            try
            {

                if (st.theorymark < 0 || st.theorymark > 10)
                {
                    throw new InvalidMarkException("Invalid mark value: " + st.theorymark);
                }
            }
            catch (InvalidMarkException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            try
            {

                if (st.labmark < 0 || st.labmark > 10)
                {
                    throw new InvalidMarkException("Invalid mark value: " + st.labmark);
                }
            }
            catch (InvalidMarkException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            Console.ReadLine();
        }
    }
}

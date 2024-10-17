namespace Lab4_5
{
    // xác định giao diện IDriveable
    public interface IDrivable
    {
        // khai báo phương thức
        void Start();
        void Stop();
        //kê khai tài sản
        bool Started
        {
            get;
        }
    }
    // xác định giao diện ISteerable
    public interface ISteerable
    {
        //khai báo phương thức
        void TurnLeft();
        void TurnRight();
    }
    //xác định giao diện IMovable (có nguồn gốc từ IDriverable và ISteerable)
    public interface IMovable : IDrivable, ISteerable
    {
        //khai báo phương thức
        void Accelerate();
        void Brake();
    }
    // Car class triển khai giao diện IMovable
    public class Car : IMovable
    {
        // khai báo trường cơ bản được sử dụng bởi
        // Thuộc tính bắt đầu của giao diện IDrive
        private bool started = false;
        // hiện thực phương thức Start() của giao diện IDriverable
        public void Start()
        {
            Console.WriteLine("car started");
            started = true;
        }
        // thi hành phương thức Stop() của giao diện IDriverable
        public void Stop()
        {
            Console.WriteLine("car stopped");
            started = false;
        }
        // triển khai thuộc tính Started của giao diện IDriverable
        public bool Started
        {
            get
            {
                return started;
            }
        }
        // triển khai phương thức TurnLeft() của giao diện ISteerable
        public void TurnLeft()
        {
            Console.WriteLine("car turning left");
        }
        // triển khai phương thức TurnRight() của giao diện ISteerable
        public void TurnRight()
        {
            Console.WriteLine("car turning right");
        }
        // triển khai phương thức Accelerate() của giao diện IMovable
        public void Accelerate()
        {
            Console.WriteLine("car accelerating");
        }
        // hiện thực phương thức Brake() của giao diện IMovable
        public void Brake()
        {
            Console.WriteLine("car braking");
        }
        static void Main(string[] args)
        {
            // tạo đối tượng Xe hơi
            Car myCar = new Car();
            // call myCar.Start()
            Console.WriteLine("Calling myCar.Start()");
            myCar.Start();
            // gọi myCar.TurnLeft()
            Console.WriteLine("Calling myCar.TurnLeft()");
            myCar.TurnLeft();
            // gọi myCar.Accelerate()
            Console.WriteLine("Calling myCar.Accelerate()");
            myCar.Accelerate();
            Console.ReadLine();
        }


    }
}
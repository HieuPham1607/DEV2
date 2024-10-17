namespace Lab4
{
    internal class Program
    {
        //Khai báo các trường
        protected int top;
        protected int left;
        //Phương thức khởi tạo
        public Program(int top, int left) 
        {
            this.top = top;
            this.left = left;
        }
        //Phương thức virtual vẽ cửa sổ
        public virtual void DrawProgram() 
        {
            Console.WriteLine("Window: drawing window at {0}, {1}", top, left);
        }
        internal class Button : Program
        {
            //Phương thức khởi tạo
            public Button(int top, int left)
                : base(top, left)
            {
            }
            //Ghi đè phương thức
            public override void DrawProgram()
            {
                Console.WriteLine("Drawing a button at {0}, {1}\n", top, left);
            }
        }
        internal class listBox:Program
        {
            //Khai báo trường mới
            private string listBoxContents;
            //Phương thức khởi tạo
            public listBox(int top, int left, string contents)
            : base(top, left) // Gọi constructor lớp cơ sở
            {
                listBoxContents = contents;
            }
            // Ghi đề phương thức DrawProgram
            public override void DrawProgram()
            {
                base.DrawProgram();//Gọi phương thức lớp cơ sở
                Console.WriteLine("Writing string to the listbox: {0}", listBoxContents);
            }
        }
        static void Main(string[] args)
        {
            //Khởi tạo lớp Program
            Program gram = new Program(1, 2);
            //Khởi tạo lớp listbox
            listBox lb = new listBox(3, 4, "Stand alone list box");
            //Khởi tạo lớp button
            Button b = new Button(5, 6);
            gram.DrawProgram();
            lb.DrawProgram();
            b.DrawProgram();
            //Khởi tạo mảng windowns
            Program[] gramArray = new Program[3];
            gramArray[0] = new Program(1,2);
            gramArray[1] = new listBox(3, 4,"list box in array");
            gramArray[2] = new Button(5, 6);
            for (int i = 0; 1 < 3; i++)
            {
                gramArray[i].DrawProgram();
            }
        }
    }
}

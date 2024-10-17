namespace Lab4._1
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
        internal class listBox : Program
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
    }
}


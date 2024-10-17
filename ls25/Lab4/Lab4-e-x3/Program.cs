namespace Lab4_e_x3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Doc doc = new Doc();
            doc.content = "Đây là nội dung của doc";
            string filePath = "doc.txt";
            //ghi vào file
            doc.Write(filePath);
            //Đọc lại từ file
            doc.Read(filePath);
            Console.WriteLine($"nội dung tài liệu: {doc.content}");
            //mã hóa nội dung
            string encrytedContent = doc.Encrypt();
            Console.WriteLine($"Mã hóa nội dung :{encrytedContent}");

            //Gán dữ liệu đã mã hóa cho doc để thử giải mã
            doc.content = encrytedContent;
            string decryptedContent = doc.Decrypt();
            Console.WriteLine($"Decrypt nội dung :{decryptedContent}");
        }
    }
}

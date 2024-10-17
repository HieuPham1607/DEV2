using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_e_x3
{
    public class Doc:ISoreable, IEncryptable
    {
        public string content { get; set; }
        public string Data
        {
            get { return content; }
            set { content = value; }
        }
        public void Write(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(content);
                Console.WriteLine($"Nội dung viết{fileName}");
            }
        }
        public void Read(string fileName) 
        {
            if (!File.Exists(fileName)){ 
                if (File.Exists(fileName))
                {
                    Console.WriteLine($"File{fileName} không thoát");
                    return;
                }
                using(FileStream fs = new FileStream((string)fileName, FileMode.Open))
                using (StreamReader sr = new StreamReader(fs))
                {
                    content = sr.ReadToEnd();
                    Console.WriteLine($"Nội dung đọc đc từ File{fileName}");
                }
            }
        }
        public string Encrypt() 
        {
            string encryptedData = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(content));
            Console.WriteLine("Nội dung encryted");
            return encryptedData;
        }
        public string Decrypt()
        {
            string decryptedData = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(content));
            Console.WriteLine("Nội dung decrypted");
            return decryptedData;
        }
    }
}

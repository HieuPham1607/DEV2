namespace Lab7_ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Tạo các đối tượng động vật
            AnCo.Bo bo = new AnCo.Bo(1, "Bò sữa", 500);
            AnCo.Trau trau = new AnCo.Trau(2, "Trâu nước", 450);
            AnCo.De de = new AnCo.De(3, "Dê núi", 70);
            AnThit.CaSau caSau = new AnThit.CaSau(4, "Cá sấu Xiêm", 200);
            AnThit.Ho ho = new AnThit.Ho(5, "Hổ Bengal", 180);
            AnThit.SuTu suTu = new AnThit.SuTu(6, "Sư tử Châu Phi", 250);

            // In thông tin của các động vật
            Console.WriteLine($"Bò: ID = {bo.ID}, Name = {bo.Name}, Weight = {bo.Weight} kg");
            Console.WriteLine($"Trâu: ID = {trau.ID}, Name = {trau.Name}, Weight = {trau.Weight} kg");
            Console.WriteLine($"Dê: ID = {de.ID}, Name = {de.Name}, Weight = {de.Weight} kg");
            Console.WriteLine($"Cá sấu: ID = {caSau.ID}, Name = {caSau.Name}, Weight = {caSau.Weight} kg");
            Console.WriteLine($"Hổ: ID = {ho.ID}, Name = {ho.Name}, Weight = {ho.Weight} kg");
            Console.WriteLine($"Sư tử: ID = {suTu.ID}, Name = {suTu.Name}, Weight = {suTu.Weight} kg");
        }
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap so diem trung binh cua sinh vien:");
        float D = float.Parse(Console.ReadLine());
        if (0 <= D && D < 5) Console.WriteLine("Yếu");
        else if (5 <= D && D < 7) Console.WriteLine("Tb");
        else if (7 <= D && D < 8) Console.WriteLine("Khá");
        else if (8 <= D && D <= 10) Console.WriteLine("Giỏi");
        else Console.WriteLine("Nhap sai so diem!");
    }
}
// See https://aka.ms/new-console-template for more information
internal class Program
{
    public static void Main(string[] agrs)
    {
        const int Quydoi = 23000;

        Console.WriteLine("Nhap vao so tien ma ban co");
        int usd = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"So tien quy doi la:{Quydoi * usd}");

    }
}



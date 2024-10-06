using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        double money = 1.0;
        int month = 1;
        double Rate = 1.0;
        Console.WriteLine("Nhập số tiền gửi:");
        money = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập số tháng:");
        month = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhập tỉ lệ lãi suất:");
        Rate = Convert.ToDouble(Console.ReadLine());
        double interRate = 0;
        for (int i = 0; i < month; i++)
        {
            interRate += money * (Rate / 100) / 12;
        }
        Console.WriteLine("Tổng số tiền lãi cho vay là:" + interRate);
    }
}
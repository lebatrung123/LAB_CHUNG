internal class Program
{
    private static void Main(string[] args)
    {
        double c;
        Console.WriteLine("Nhập a:");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập b:");
        double b = Convert.ToDouble(Console.ReadLine());
        if (a != 0)
        {
            c = -b / a;
            Console.WriteLine("Phương có nghiệm là:" + c);


        }
        else if (b == 0)
        {
            Console.WriteLine("Phương trình vô số nghiệm");
        }
        else
        {
            Console.WriteLine("Phương trình vô nghiệm");
        }
    }

}


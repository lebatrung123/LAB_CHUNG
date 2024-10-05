using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao 1 so");
        int so = Convert.ToInt32(Console.ReadLine());
        if (so > 0 && so < 5)
        {
            switch (so)
            {
                case 1:
                    Console.WriteLine("*");
                    Console.WriteLine("**");
                    Console.WriteLine("***");
                    Console.WriteLine("****");
                    break;
                case 2:
                    Console.WriteLine("*****");
                    Console.WriteLine("*****");
                    Console.WriteLine("*****");
                    Console.WriteLine("*****");
                    break;
                case 3:
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    Console.WriteLine("******");
                    break;
                case 4:
                    Console.WriteLine("***");
                    Console.WriteLine("* *");
                    Console.WriteLine("* *");
                    Console.WriteLine("***");
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
        }
        else
        {
            Console.WriteLine("Nhap sai khoang");
        }
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Circle c = new Circle();
        Console.WriteLine("Nhập bán kính hình tròn:");
        c.radius = Convert.ToDouble(Console.ReadLine());

        /*Console.WriteLine(c.GetArea());
        Console.WriteLine(c.GetDistance());
        Console.WriteLine(c.GetPerimeter());

        Square s = new Square(6);
        Console.WriteLine(s.GetArea());
        Console.WriteLine(s.GetPerimeter());

        Circle c1 = new Circle();
        Console.WriteLine(c1.GetArea());
        Console.WriteLine(c1.GetDistance());
        Console.WriteLine(c1.GetPerimeter());*/

        /*TV tv = new TV();
        tv.GetOnOff();
        tv.ChannelUp();
        tv.ChannelDown();
        tv.VolumeUp();
        tv.VolumeDown();
        Console.WriteLine(tv.channel);
        Console.WriteLine(tv.volumeLevel);
        TV tv1 = null;*/
        Rectangle r = new Rectangle();
        Console.WriteLine("Nhập chieu dai hình chu nhat:");
        r.weight = float.Parse(Console.ReadLine());
        Console.WriteLine("Nhập chieu cao hình chu nhat:");
        r.height = float.Parse(Console.ReadLine());
        Console.WriteLine($"Dien tich hinh tron la {c.GetArea()}");
        Console.WriteLine($"Dien tich hinh chu nhat la {r.GetArea()}");


    }
}
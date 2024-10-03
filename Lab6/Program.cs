internal class Program
{
    //viet xong code
    //viet gon dong lenh
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap 1 so:");
        int so = int.Parse(Console.ReadLine());
        if (so >= 0 && so < 999)
        {
            if (so > 0 && so <= 10)
            {
                if (so == 0) Console.WriteLine("Khong");
                else if (so == 1) Console.WriteLine("Mot");
                else if (so == 2) Console.WriteLine("Mot");
                else if (so == 3) Console.WriteLine("Mot");
                else if (so == 4) Console.WriteLine("Mot");
                else if (so == 5) Console.WriteLine("Mot");
                else if (so == 6) Console.WriteLine("Mot");
                else if (so == 7) Console.WriteLine("Mot");
                else if (so == 8) Console.WriteLine("Mot");
                else Console.WriteLine("Chin");
            }
            else if (so >= 10 && so < 99)
            {
                int chuc = so / 10;
                int donvi = so % 10;
                if (chuc == 0) Console.WriteLine("Khong");
                else if (chuc == 1) Console.WriteLine("mot");
                else if (chuc == 2) Console.WriteLine("hai");
                else if (chuc == 3) Console.WriteLine("ba");
                else if (chuc == 4) Console.WriteLine("bon");
                else if (chuc == 5) Console.WriteLine("nam");
                else if (chuc == 6) Console.WriteLine("sau");
                else if (chuc == 7) Console.WriteLine("bay");
                else if (chuc == 8) Console.WriteLine("tam");
                else Console.WriteLine("chin");
                if (donvi == 0) Console.WriteLine("Khong");
                else if (donvi == 1) Console.WriteLine("mot");
                else if (donvi == 2) Console.WriteLine("hai");
                else if (donvi == 3) Console.WriteLine("ba");
                else if (donvi == 4) Console.WriteLine("bon");
                else if (donvi == 5) Console.WriteLine("nam");
                else if (donvi == 6) Console.WriteLine("sau");
                else if (donvi == 7) Console.WriteLine("bay");
                else if (donvi == 8) Console.WriteLine("tam");
                else Console.WriteLine("chin");


            }
            else
            {
                int tram = so / 100;
                int chuc = (so % 100) / 10;
                int donvi = (so % 100) % 10;
                if (tram == 0) Console.WriteLine("khong");
                else if (tram == 1) Console.Write("mot");
                else if (tram == 2) Console.Write("hai");
                else if (tram == 3) Console.Write("ba");
                else if (tram == 4) Console.Write("bon");
                else if (tram == 5) Console.Write("nam");
                else if (tram == 6) Console.Write("sau");
                else if (tram == 7) Console.Write("bay");
                else if (tram == 8) Console.Write("tam");
                else Console.Write("chin");
                if (chuc == 0) Console.WriteLine("khong");
                else if (chuc == 1) Console.Write("mot");
                else if (chuc == 2) Console.Write("hai");
                else if (chuc == 3) Console.Write("ba");
                else if (chuc == 4) Console.Write("bon");
                else if (chuc == 5) Console.Write("nam");
                else if (chuc == 6) Console.Write("sau");
                else if (chuc == 7) Console.Write("bay");
                else if (chuc == 8) Console.Write("tam");
                else Console.Write("chin");
                if (donvi == 0) Console.WriteLine("Khong");
                else if (donvi == 1) Console.Write("mot");
                else if (donvi == 2) Console.Write("hai");
                else if (donvi == 3) Console.Write("ba");
                else if (donvi == 4) Console.Write("bon");
                else if (donvi == 5) Console.Write("nam");
                else if (donvi == 6) Console.Write("sau");
                else if (donvi == 7) Console.Write("bay");
                else if (donvi == 8) Console.Write("tam");
                else Console.Write("chin");

            }
        }
        else
        {
            Console.WriteLine("Nhap sai gia tri, chạy lại chương trình:");
        }


    }
}
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
            if (so > 0 && so < 10)
            {
                if (so == 0) Console.WriteLine("Khong");
                else if (so == 1) Console.WriteLine("Mot");
                else if (so == 2) Console.WriteLine("Hai");
                else if (so == 3) Console.WriteLine("Ba");
                else if (so == 4) Console.WriteLine("Bon");
                else if (so == 5) Console.WriteLine("Nam");
                else if (so == 6) Console.WriteLine("Sau");
                else if (so == 7) Console.WriteLine("Bay");
                else if (so == 8) Console.WriteLine("Tam");
                else Console.WriteLine("Chin");
            }
            else if (so >= 10 && so < 99)
            {
                int chuc = so / 10;
                int donvi = so % 10;
                if (chuc == 0) Console.WriteLine("Khong");
                else if (chuc == 1) Console.Write("Mười");
                else if (chuc == 2) Console.Write("Hai mươi");
                else if (chuc == 3) Console.Write("Ba mươi");
                else if (chuc == 4) Console.Write("Bốn mươi");
                else if (chuc == 5) Console.Write("Năm mươi");
                else if (chuc == 6) Console.Write("Sáu mươi");
                else if (chuc == 7) Console.Write("Bảy mươi");
                else if (chuc == 8) Console.Write("Tám mươi");
                else Console.WriteLine("Chín mươi");
                if (donvi == 0) Console.WriteLine("Khong");
                else if (donvi == 1) Console.WriteLine("Mot");
                else if (donvi == 2) Console.WriteLine("Hai");
                else if (donvi == 3) Console.WriteLine("Ba");
                else if (donvi == 4) Console.WriteLine("Bon");
                else if (donvi == 5) Console.WriteLine("Nam");
                else if (donvi == 6) Console.WriteLine("Sau");
                else if (donvi == 7) Console.WriteLine("Bay");
                else if (donvi == 8) Console.WriteLine("Tam");
                else Console.WriteLine("Chin");


            }
            else
            {
                int tram = so / 100;
                int chuc = (so % 100) / 10;
                int donvi = (so % 100) % 10;
                if (tram == 0) Console.WriteLine("Khong trăm ");
                else if (tram == 1) Console.WriteLine("Một trăm");
                else if (tram == 2) Console.WriteLine("Hai trăm");
                else if (tram == 3) Console.WriteLine("Ba trăm");
                else if (tram == 4) Console.WriteLine("Bốn trăm");
                else if (tram == 5) Console.WriteLine("Năm trăm");
                else if (tram == 6) Console.WriteLine("Sáu trăm");
                else if (tram == 7) Console.WriteLine("Bảy trăm");
                else if (tram == 8) Console.WriteLine("Tám trăm");
                else Console.WriteLine("Chín trăm");
                if (chuc == 0) Console.WriteLine("Lẻ");
                else if (chuc == 1) Console.WriteLine("Mười");
                else if (chuc == 2) Console.WriteLine("Hai mươi");
                else if (chuc == 3) Console.WriteLine("Ba mươi");
                else if (chuc == 4) Console.WriteLine("Bốn mươi");
                else if (chuc == 5) Console.WriteLine("Năm mươi");
                else if (chuc == 6) Console.WriteLine("Sáu mươi");
                else if (chuc == 7) Console.WriteLine("Bảy mươi");
                else if (chuc == 8) Console.WriteLine("Tám mươi");
                else Console.WriteLine("Chín mươi");
                if (donvi == 0) Console.WriteLine("Khong");
                else if (donvi == 1) Console.WriteLine("Mot");
                else if (donvi == 2) Console.WriteLine("Hai");
                else if (donvi == 3) Console.WriteLine("Ba");
                else if (donvi == 4) Console.WriteLine("Bon");
                else if (donvi == 5) Console.WriteLine("Nam");
                else if (donvi == 6) Console.WriteLine("Sau");
                else if (donvi == 7) Console.WriteLine("Bay");
                else if (donvi == 8) Console.WriteLine("Tam");
                else Console.WriteLine("Chin");


            }
        }
        else
        {
            Console.WriteLine("Nhap sai gia tri, chạy lại chương trình:");
        }


    }
}

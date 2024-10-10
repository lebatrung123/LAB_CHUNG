
internal class Program
{

    private static void Main(string[] args)
    {
        int[] mang = new int[100];

        int so;
        int dem;
        int dem1;
        Console.Write("Ban muon nhap bao nhieu so:");
        so = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < so; i++)
        {
            Console.Write("Nhap so thu {0}:", i);
            mang[i] = Convert.ToInt32(Console.ReadLine());

        }
        dem = mang[0];
        dem1 = mang[0];
        for (int i = 1; i < so; i++)
        {

            if (mang[i] > dem)
            {
                dem = mang[i];
            }

            if (mang[i] < dem1)
            {
                dem1 = mang[i];
            }

        }
        Console.WriteLine($"Phần tử lớn nhất trong mảng {+dem}");
        Console.WriteLine($"Phần tử nhỏ nhất trong mảng là {+dem1}");
    }
}
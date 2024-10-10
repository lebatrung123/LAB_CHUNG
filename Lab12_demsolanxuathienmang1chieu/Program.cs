internal class Program
{
    private static void Main(string[] args)
    {
        int[] mang = new int[100];
        int[] mang1 = new int[100];
        int so, dem;
        Console.Write("Ban muon nhap bao nhieu so:");
        so = int.Parse(Console.ReadLine());

        for (int i = 0; i < so; i++)
        {
            Console.Write("Nhap so thu {0}:", i);
            mang[i] = int.Parse(Console.ReadLine());
            mang1[i] = -1;
        }

        for (int i = 0; i < so; i++)
        {
            dem = 1;
            for (int j = i + 1; j < so; j++)
            {
                if (mang[i] == mang[j])
                {
                    dem++;
                    mang1[j] = 0;
                }
            }
            if (mang1[i] != 0)
            {
                mang1[i] = dem;
            }

        }
        Console.WriteLine("So lan xuat hien của tung phan tu la:");
        for (int i = 0; i < so; i++)
        {
            if (mang[i] != 0)
                Console.WriteLine($"Phan tu {+mang[i]} xuất hien {mang1[i]} lần ");
        }

    }
}
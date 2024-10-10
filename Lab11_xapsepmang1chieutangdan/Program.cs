internal class Program
{
    private static void Main(string[] args)
    {
        int[] mang = new int[100];
        int so, temp;
        Console.Write("Ban muon nhap bao nhieu so:");
        so = int.Parse(Console.ReadLine());

        for (int i = 0; i < so; i++)
        {
            Console.Write("Nhap so thu {0}:", i);
            mang[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < so; i++)
        {
            for (int j = i + 1; j < so; j++)
            {
                if (mang[j] < mang[i])
                {
                    temp = mang[i];
                    mang[i] = mang[j];
                    mang[j] = temp;
                }
            }

        }
        Console.WriteLine("Mang sau khi được sắp xếp là:");
        for (int i = 0; i < so; i++)
        {
            Console.Write(" " + mang[i]);
        }

    }


}



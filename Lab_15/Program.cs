internal class Program
{
    private static void Main(string[] args)
    {

        // Console.WriteLine("nhap phan tu vao mang 2 chieu");
        //khai báo mảng 2 chiều
        Console.WriteLine("Nhap kich thuoc cua mang:");

        int n = Convert.ToInt32(Console.ReadLine());
        int[,] mang = new int[n, n];
        // nhap va in mang 2 chieu

        //for (var i = 0; i < mang.GetLength(0); i++)
        //{
        //  for (var j = 0; j < mang.GetLength(1); j++)
        // {
        //     mang[i, j] = Convert.ToInt32(Console.ReadLine());
        // }
        //}
        //for (var i = 0; i < mang.GetLength(0); i++)
        // {
        //for (var j = 0; j < mang.GetLength(1); j++)
        // {
        //     Console.Write(mang[i, j] + "\t");
        // }
        // Console.Write("\n");
        //}

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                mang[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                Console.WriteLine(mang[i, j]);
            }
        }

        int tong = 0;
        for (var i = 0; i < n; i++)
        {
            for (var j = 0; j < n; j++)
            {
                if (i == j)
                {
                    tong += mang[i, j];
                }
            }

        }
        Console.WriteLine("Tong duong cheo chính là {0}", tong);
    }

}
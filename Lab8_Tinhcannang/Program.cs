internal class Program
{
    private static void Main(string[] args)
    {
        double w, h, bmi;
        Console.WriteLine("Nhập cân nặng:");
        w = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Nhập chiều cao:");
        h = Convert.ToDouble(Console.ReadLine());
        bmi = w / (h * h);
        if (bmi < 18.5)
        {
            Console.WriteLine("Underweight");

        }
        else if (bmi >= 18.5 && bmi < 25.0)
        {
            Console.WriteLine("Normal");

        }
        else if (bmi >= 25.0 && bmi < 30.0)
        {
            Console.WriteLine("Overweight");

        }
        else
        {
            Console.WriteLine(" Obese");

        }
    }
}
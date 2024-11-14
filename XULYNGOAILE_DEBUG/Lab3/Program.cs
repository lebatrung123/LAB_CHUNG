public class Program
{
    private static void Main(string[] args)
    {
      
     try
       {
         List<Char> c =new List<Char>();
        c.InsertRange(0, new Char[]{'a','b','c','d','e'});
        int value = c[5];
       }
       catch (IndexOutOfRangeException e)
       {
        Console.WriteLine("Lỗi");
        throw;
       }
        
        
      

    }
}
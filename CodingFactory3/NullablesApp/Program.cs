namespace NullablesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int? i = null;

            Console.WriteLine(num);
            Console.WriteLine("i: {0}", (i == null) ? "null" : "not null");
        }
    }
}
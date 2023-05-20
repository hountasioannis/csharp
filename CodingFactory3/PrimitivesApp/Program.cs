namespace PrimitivesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int: {sizeof(int) * 8}\t{int.MinValue}\t{int.MaxValue}");
            Console.WriteLine($"byte: {sizeof(byte) * 8}\t{byte.MinValue}\t{byte.MaxValue}");
            Console.WriteLine($"short: {sizeof(short) * 8}\t{short.MinValue}\t{short.MaxValue}");
            Console.WriteLine($"long: {sizeof(long) * 8}\t{long.MinValue}\t{long.MaxValue}");
            Console.WriteLine($"ulong: {sizeof(ulong) * 8}\t{ulong.MinValue}\t{ulong.MaxValue}");
            Console.WriteLine($"double: {sizeof(double) * 8}\t{double.MinValue}\t{double.MaxValue}");
        }
    }
}
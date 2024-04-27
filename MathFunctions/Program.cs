using MathFunctions;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        var math = new MathFunctions.Math();
        Console.WriteLine( math.IsPrime(16));
    }
}
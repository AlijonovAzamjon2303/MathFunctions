using MathFunctions;
internal class Program
{
    private static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] fibs = new int[n];
        MathFunctions.Math math = new MathFunctions.Math();
        
        fibs = math.FirstNFibonacci(n);
        Print(fibs);
    }
    static void Print(int[] arr)
    {
        foreach(int fib in arr)
        {
            Console.WriteLine(fib);
        }
    }
}
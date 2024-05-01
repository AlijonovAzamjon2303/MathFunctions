namespace MathFunctions
{
    internal class Math
    {
        public bool IsPrime(int n)
        {
            if(n < 2) return false;
            for(int i = 2; i * i <= n; i++)
            {
                if(n % i == 0) return false; 
            }

            return true;
        }
        public int[] FirstNFibonacci(int n)
        {
            int[] arr = new int[n];
            arr[0] = 0;
            arr[1] = 1;
            
            for(int i = 2; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr;
        }
    }
}

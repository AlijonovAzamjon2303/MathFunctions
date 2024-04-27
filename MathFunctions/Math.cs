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
    }
}

using System;

class Bai31
{
    static void Main()
    {
        
    }

    static bool IsPrime(int n_331)
    {
        if (n_331 < 2) return false;
        for (int i_331 = 2; i_331 * i_331 <= n_331; i_331++)
        {
            if (n_331 % i_331 == 0) return false;
        }
        return true;
    }
}
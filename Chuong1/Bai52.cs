using System;

class Bai52
{
    static void Main()
    {
        
    }

    static int FindMinDigit(int n_331)
    {
        int minDigit_331 = 9;
        while (n_331 > 0)
        {
            int digit_331 = n_331 % 10;
            if (digit_331 < minDigit_331)
            {
                minDigit_331 = digit_331;
            }
            n_331 /= 10;
        }
        return minDigit_331;
    }
}

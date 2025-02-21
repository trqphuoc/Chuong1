using System;

class Bai44
{
    static void Main()
    {
        
    }

    static int SumOfDigits(int n_331)
    {
        int sum_331 = 0;
        while (n_331 > 0)
        {
            sum_331 += n_331 % 10;
            n_331 /= 10;
        }
        return sum_331;
    }
}


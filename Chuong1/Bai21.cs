using System;

class Bai21
{
    static void Main()
    {
      
    }

    static int SumOfDivisors(int n_331)
    {
        int sum_331 = 0;
        for (int i_331 = 1; i_331 <= n_331; i_331++)
        {
            if (n_331 % i_331 == 0)
            {
                sum_331 += i_331;
            }
        }
        return sum_331;
    }
}

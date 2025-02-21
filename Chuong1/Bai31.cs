using System;

class Bai31
{
    static void Main()
    {
        Console.Write("Nhập số nguyên dương n_331: ");
        int n_331 = int.Parse(Console.ReadLine());

        if (IsPrime(n_331))
        {
            Console.WriteLine($"{n_331} là số nguyên tố.");
        }
        else
        {
            Console.WriteLine($"{n_331} không phải là số nguyên tố.");
        }
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
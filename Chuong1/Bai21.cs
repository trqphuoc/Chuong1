using System;

class Bai21
{
    static void Main()
    {
        Console.Write("Nhập số nguyên dương n_331: ");
        int n_331 = int.Parse(Console.ReadLine());

        int sum_331 = SumOfDivisors(n_331);
        Console.WriteLine($"Tổng các ước số của {n_331} là: {sum_331}");
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

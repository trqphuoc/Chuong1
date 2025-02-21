using System;

class Bai44
{
    static void Main()
    {
        Console.Write("Nhập số nguyên dương n_331: ");
        int n_331 = int.Parse(Console.ReadLine());

        int sum_331 = SumOfDigits(n_331);
        Console.WriteLine($"Tổng các chữ số của {n_331} là: {sum_331}");
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


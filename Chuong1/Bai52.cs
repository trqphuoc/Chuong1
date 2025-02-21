using System;

class Bai52
{
    static void Main()
    {
        Console.Write("Nhập số nguyên dương n_331: ");
        int n_331 = int.Parse(Console.ReadLine());

        int minDigit_331 = FindMinDigit(n_331);
        Console.WriteLine($"Chữ số nhỏ nhất của {n_331} là: {minDigit_331}");
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

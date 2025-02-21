using System;

class Bai1
{
    static void Main()
    {
        // Nhập giá trị n từ người dùng
        Console.Write("Nhập giá trị n_331: ");
        int n_331 = int.Parse(Console.ReadLine());

        // Khởi tạo biến tổng
        int sum_331 = 0;

        // Tính tổng từ 1 đến n_331
        for (int i_331 = 1; i_331 <= n_331; i_331++)
        {
            sum_331 += i_331;
        }

        // In ra kết quả
        Console.WriteLine($"Tổng S({n_331}) = {sum_331}");
    }
}
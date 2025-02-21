using System;

class Bai11
{
    static void Main()
    {
        // Nhập giá trị n_331 từ người dùng
        Console.Write("Nhập giá trị n_331: ");
        int n_331 = int.Parse(Console.ReadLine());

        // Khởi tạo biến tổng
        int sum_331 = 0;

        // Tính tổng theo công thức
        for (int k_331 = 1; k_331 <= n_331; k_331++)
        {
            int product_331 = 1;  // Khởi tạo tích của dãy cho mỗi giá trị k_331

            // Tính tích 1 * 2 * ... * k_331
            for (int i_331 = 1; i_331 <= k_331; i_331++)
            {
                product_331 *= i_331;
            }

            // Cộng dồn vào tổng
            sum_331 += product_331;
        }

    }
}

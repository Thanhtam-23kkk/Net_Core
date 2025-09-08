using System;

class Bai2
{
    static void Main()
    {
        Console.Write("Nhập số thứ nhất: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Nhập số thứ hai: ");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Chọn phép tính:");
        Console.WriteLine("1. Tổng");
        Console.WriteLine("2. Hiệu");
        Console.WriteLine("3. Tích");
        Console.WriteLine("4. Thương");
        Console.Write("Nhập lựa chọn (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        double kq = 0;
        switch (choice)
        {
            case 1:
                kq = a + b;
                Console.WriteLine($"Tổng = {kq}");
                break;
            case 2:
                kq = a - b;
                Console.WriteLine($"Hiệu = {kq}");
                break;
            case 3:
                kq = a * b;
                Console.WriteLine($"Tích = {kq}");
                break;
            case 4:
                if (b != 0)
                {
                    kq = a / b;
                    Console.WriteLine($"Thương = {kq}");
                }
                else
                {
                    Console.WriteLine("Không thể chia cho 0!");
                }
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
        }
    }
}
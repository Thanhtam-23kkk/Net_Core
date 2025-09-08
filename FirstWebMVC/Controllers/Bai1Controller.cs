using System;

class Bai1
{
    static void Main()
    {
        Console.Write("Nhập họ tên: ");
        string hoTen = Console.ReadLine();

        Console.Write("Nhập năm sinh: ");
        int namSinh = int.Parse(Console.ReadLine());

        int namHienTai = DateTime.Now.Year;
        int tuoi = namHienTai - namSinh;

        Console.WriteLine($"Họ tên: {hoTen} | Tuổi: {tuoi}");
    }
}

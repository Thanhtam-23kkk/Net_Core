using System;

class Bai3
{
    static void Main()
    {
        Console.Write("Nhập cân nặng (kg): ");
        double canNang = double.Parse(Console.ReadLine());

        Console.Write("Nhập chiều cao (m): ");
        double chieuCao = double.Parse(Console.ReadLine());

        double bmi = canNang / (chieuCao * chieuCao);
        string danhGia;

        if (bmi < 18.5) danhGia = "Gầy";
        else if (bmi < 24.9) danhGia = "Bình thường";
        else if (bmi < 29.9) danhGia = "Thừa cân";
        else danhGia = "Béo phì";

        Console.WriteLine($"Chỉ số BMI = {bmi:F2} → {danhGia}");
    }
}
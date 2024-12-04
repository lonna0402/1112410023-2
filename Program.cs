
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    //1112410023 郭采盈
    public static double CountPi(int n)
    {
        // 檢查 n 是否在合法範圍內
        if (n < 4 || n > 15)
        {
            return -1; // 回傳錯誤值
        }

        double pi = 0.0;

        // 利用萊布尼茲公式計算 Pi
        for (int i = 0; i < n; i++)
        {
            double term = 1.0 / (2.0 * i + 1);
            if (i % 2 == 0)
                pi += term;
            else
                pi -= term;
        }

        return pi * 4.0;
    }

    public static double CalculateCircumference(double radius)
    {
        // 計算圓周長: 2 * π * r
        double pi = CountPi(15); // 使用 15 項近似 Pi
        return 2 * pi * radius;
    }

    public static double CalculateArea(double radius)
    {
        // 計算圓面積: π * r^2
        double pi = CountPi(15); // 使用 15 項近似 Pi
        return pi * radius * radius;
    }

    static void Main()
    {
        Console.WriteLine("請選擇功能：");
        Console.WriteLine("1. 計算圓周率");
        Console.WriteLine("2. 計算圓周長");
        Console.WriteLine("3. 計算圓面積");
        Console.Write("請輸入選項 (1-3): ");

        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                Console.Write("請輸入計算 pi 的項數 (4 到 15): ");
                int n = int.Parse(Console.ReadLine());
                double piApprox = CountPi(n);
                if (piApprox == -1)
                {
                    Console.WriteLine("輸入項數超出範圍！請輸入 4 到 15 之間的值。");
                }
                else
                {
                    Console.WriteLine($"使用 {n} 項近似的 Pi 值為: {piApprox:F15}");
                }
                break;

            case 2:
                Console.Write("請輸入圓的半徑: ");
                double radiusForCircumference = double.Parse(Console.ReadLine());
                double circumference = CalculateCircumference(radiusForCircumference);
                Console.WriteLine($"圓的周長為: {circumference:F15}");
                break;

            case 3:
                Console.Write("請輸入圓的半徑: ");
                double radiusForArea = double.Parse(Console.ReadLine());
                double area = CalculateArea(radiusForArea);
                Console.WriteLine($"圓的面積為: {area:F15}");
                break;

            default:
                Console.WriteLine("無效的選項！");
                break;
        }
    }
}
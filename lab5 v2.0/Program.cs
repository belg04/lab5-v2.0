using System;


class Program
{
    static void Main()
    {
        double a, b, x;
        try
        {
            Console.Write("Введите a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите b:");
            b = double.Parse(Console.ReadLine());

            // Вычисляем корень линейного уравнения ax + b = 0
            double root = SubtractRoot(a, b);
            Console.WriteLine($"Корень уравнения: x={root:F2}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    static double SubtractRoot(double a, double b)
    {
        if (a != 0)
        {
            double x = -b / a;
            return x;
        }
        throw new Exception("Деление на ноль запрещено");
    }
}

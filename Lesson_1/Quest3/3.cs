using System;

namespace Lesson_1
{
  class Class3
  {
    static void Main() // Next type of simple program. More math, to counter a way between two points.
    {
      double x1;
      double x2;
      double y1;
      double y2;
      Console.Write("Введите x1: ");
      x1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Введите x2: ");
      x2 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Введите y1: ");
      y1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Введите y2: ");
      y2 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Результирующее расстояние: {0:F2}", M(x1, x2, y1, y2));
      Console.ReadKey();
    }
    static double M(double x1, double x2, double y1, double y2)
    {
      return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
  }
}
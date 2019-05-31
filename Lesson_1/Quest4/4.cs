using System;

namespace Lesson_1
{
  class Class4
  {
    static void Main() // Another sinplest example. Exchange between two variations, with thurb - buffer and without it.
    {
      Console.Write("Введите число A: ");
      int A = Convert.ToInt32(Console.ReadLine());
      Console.Write("Введите число B: ");
      int B = Convert.ToInt32(Console.ReadLine());
      int C = A;
      A = B;
      B = C;
      Console.Write("Теперь А = {0}, а B = {1}", A, B);
      Console.ReadKey();
      A = A + B;
      B = A - B;
      A = A - B;
      Console.Write("Обратный обмен без использования буферной переменной: A = {0}, B = {1}", A, B);
      Console.ReadKey();
    }
  }
}
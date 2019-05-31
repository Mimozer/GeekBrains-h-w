using System;


namespace Lesson_1
{
  class Class2
  {
    static void Main() //Here we create another example of simple program, with some math in it. You can count youre mass index.
    {
      double tal;
      double mas;
      Console.Write("Введите рост: ");
      tal = Convert.ToDouble(Console.ReadLine());
      Console.Write("Введите вес: ");
      mas = Convert.ToDouble(Console.ReadLine());
      double imt;
      imt = mas / (tal * tal);
      Console.Write("Ваш ИМТ равен " + imt);
      Console.ReadKey();
    }
  }
}
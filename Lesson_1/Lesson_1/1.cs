using System;

namespace Lesson_1
{
  class Class1
  {
      static void Main() //Here we create a simplest program, which represents your data in line. 
      {
          Console.WriteLine("Введите своё имя:  ");
          string nam = Console.ReadLine(); //We don't need TryParse, because all variables don't prosecced.
          Console.WriteLine("Введите свою фамилию:  ");
          string sur = Console.ReadLine();
          Console.WriteLine("Введите свой возраст:  ");
          string age = Console.ReadLine();
          Console.WriteLine("Введите свой рост:  ");
          string tal = Console.ReadLine();
          Console.WriteLine("Введите свой вес:  ");
          string mas = Console.ReadLine();
          Console.WriteLine("Вы ввели: " + nam + " " + sur + " " + age + " " + tal + " " + mas + ".");
          Console.ReadKey();
          Console.WriteLine("Вы ввели: {0} {1} {2} {3} {4}.", nam, sur, age, tal, mas);
          Console.ReadKey();
      }
  }
}
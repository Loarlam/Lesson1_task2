/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется: Создать класс с именем Rectangle.  
В теле класса создать два поля, описывающие длины сторон double side1, side2.   
Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого поля side1 и side2 инициализируются значениями аргументов.  
Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр прямоугольника - double PerimeterCalculator().  
Создать два свойства double Area и double Perimeter с одним методом доступа get. 
Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит на экран периметр и площадь. 
*/

using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите две стороны прямоугольника через enter");
            Rectangle rectangle = new Rectangle(Double.Parse(Console.ReadLine()), Double.Parse(Console.ReadLine()));
            Console.WriteLine("\nP прямоугольника = {0}.\nS прямоугольника = {1}", rectangle.Perimeter, rectangle.Area);
            Console.ReadKey();
        }
    }
}

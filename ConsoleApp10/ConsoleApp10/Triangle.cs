using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    ///// <summary>
    ///// Создаем обобщенный класс Треугольник 
    ///// </summary>
    ///// <typeparam name="T"></typeparam>
    //class Triangle<T>
    //{
    //    /// <summary>
    //    /// Создаем личные поля обобщенного класса
    //    /// </summary>
    //    private T a;
    //    private T b;
    //    private T c;

    //    /// <summary>
    //    /// Создаем конструктоп без параметров
    //    /// </summary>
    //    public Triangle()
    //    {

    //    }
    //    /// <summary>
    //    /// Создаем конструктор с параметрамми стороны треугольника
    //    /// </summary>
    //    /// <param name="sideA"></param>
    //    /// <param name="sideB"></param>
    //    /// <param name="sideC"></param>
    //    public Triangle(T sideA, T sideB, T sideC)
    //    {
    //        a = sideA;
    //        b = sideB;
    //        c = sideC;
    //    }

    //    /// <summary>
    //    /// Свойства поля стороны a
    //    /// </summary>
    //    public T SideA
    //    {
    //        get { return a; }
    //        set { a = value; }
    //    }

    //    /// <summary>
    //    /// Свойства поля стороны b
    //    /// </summary>
    //    public T SideB
    //    {
    //        get { return b; }
    //        set { b = value; }
    //    }

    //    /// <summary>
    //    /// Свойства поля стороны c
    //    /// </summary>
    //    public T SideC
    //    {
    //        get { return c; }
    //        set { c = value; }
    //    }

    //    /// <summary>
    //    /// Метод вывода информации
    //    /// </summary>
    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"Стороны треугольника: a = {a}, b = {b}, c = {c}");
    //    }

    //    /// <summary>
    //    /// Создаем метод который использует формулу Герона для расчета треугольника
    //    /// </summary>
    //    /// <returns></returns>
    //    public double CalculateArea()
    //    {
    //        /// <summary>
    //        /// Проверка на возможность построения треугольника
    //        /// </summary>
    //        if (Convert.ToDouble(a) + Convert.ToDouble(b) > Convert.ToDouble(c) &&
    //            Convert.ToDouble(b) + Convert.ToDouble(c) > Convert.ToDouble(a) &&
    //            Convert.ToDouble(a) + Convert.ToDouble(c) > Convert.ToDouble(b))
    //        {
    //            /// <summary>
    //            /// Используем формулу Герона для расчета площади треугольника
    //            /// </summary>
    //            double s = (Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c)) / 2;
    //            double area = Math.Sqrt(s * (s - Convert.ToDouble(a)) * (s - Convert.ToDouble(b)) * (s - Convert.ToDouble(c)));
    //            return area;
    //        }
    //        else
    //        {
    //            Console.WriteLine("Невозможно построить треугольник с заданными сторонами.");
    //            return 0;
    //        }
    //    }
    //}
}

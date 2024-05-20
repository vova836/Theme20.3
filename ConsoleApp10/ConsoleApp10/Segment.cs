using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    ///// <summary>
    ///// Создаем обобщенный класс Сегмент
    ///// </summary>
    ///// <typeparam name="T"></typeparam>
    //class Segment<T>
    //{
    //    /// <summary>
    //    /// Создаем поля Сегмента
    //    /// </summary>
    //    private T x1;
    //    private T y1;
    //    private T x2;
    //    private T y2;

    //    /// <summary>
    //    /// Конструктор без параметров
    //    /// </summary>
    //    public Segment()
    //    {

    //    }

    //    /// <summary>
    //    /// Конструктор с параметрамми
    //    /// </summary>
    //    /// <param name="x1"></param>
    //    /// <param name="y1"></param>
    //    /// <param name="x2"></param>
    //    /// <param name="y2"></param>
    //    public Segment(T x1, T y1, T x2, T y2)
    //    {
    //        this.x1 = x1;
    //        this.y1 = y1;
    //        this.x2 = x2;
    //        this.y2 = y2; 
    //    }

    //    /// <summary>
    //    /// Свойства поля x1
    //    /// </summary>
    //    public T X1
    //    {
    //        get { return x1; }
    //        set { x1 = value; }
    //    }

    //    /// <summary>
    //    /// Свойства поля y1
    //    /// </summary>
    //    public T Y1
    //    {
    //        get { return y1; }
    //        set { y1 = value; }
    //    }

    //    /// <summary>
    //    /// Свойства поля x2
    //    /// </summary>
    //    public T X2
    //    {
    //        get { return x2; }
    //        set { x2 = value; }
    //    }

    //    /// <summary>
    //    /// Свойства поля y2
    //    /// </summary>
    //    public T Y2
    //    {
    //        get { return y2; }
    //        set { y2 = value; }
    //    }

    //    /// <summary>
    //    /// Метод вывода информации
    //    /// </summary>
    //    public void DisplayInfo()
    //    {
    //        Console.WriteLine($"Координаты сегмента: ({x1}, {y1}), ({x2}, {y2})");
    //    }

    //    /// <summary>
    //    /// Метод создает решения Сегмента
    //    /// </summary>
    //    /// <returns></returns>
    //    public double CalculateLength()
    //    {
    //        double length = Math.Sqrt(Convert.ToDouble(x2) - Convert.ToDouble(x1)) * (Convert.ToDouble(x2) - Convert.ToDouble(x1)) +
    //                        (Convert.ToDouble(y2) - Convert.ToDouble(y1)) * (Convert.ToDouble(y2) - Convert.ToDouble(y1));
    //        return length;
    //    }
    //}
}

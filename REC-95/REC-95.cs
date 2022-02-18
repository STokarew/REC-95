using System;

namespace REC_95
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату Х вершины А ");
            var x1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y вершины А ");
            var y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Х вершины B ");
            var x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y вершины B ");
            var y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Х вершины C ");
            var x3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату Y вершины C ");
            var y3 = int.Parse(Console.ReadLine());
            Point a = new Point(x1, y1);
            Point b = new Point(x2, y2);
            Point c = new Point(x3, y3);
            Triangle Triangle0 = new Triangle(a, b, c);
            Triangle0.showPoints();
            Triangle0.showSides();
            Triangle0.showPerimetr();
            Triangle0.showArea();
            Console.ReadKey();
        }
    }
}

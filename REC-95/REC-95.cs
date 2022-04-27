using System;

namespace REC_95
{
    class Program
    {
        static void Main(string[] args)
        {
            var pointA = new Point(1, 1);
            var pointB = new Point(5, 1);
            var pointC = new Point(3, 5);

            var triangle = new Triangle(pointA, pointB, pointC);

            Console.WriteLine($"Вершины: {triangle.GetPoints()}");
            Console.WriteLine($"Периметр: {triangle.GetPerimetr(pointA, pointB, pointC)}");
            Console.WriteLine($"Площадь: {triangle.GetArea()}");
            Console.ReadKey();
        }
    }
}

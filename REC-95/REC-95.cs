using System;

namespace REC_95
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle();

            triangle.A.X = 1;
            triangle.A.Y = 1;
            triangle.B.X = 5;
            triangle.B.Y = 1;
            triangle.C.X = 3;
            triangle.C.Y = 5;

            Console.WriteLine($"Вершины: {triangle.GetPoints(triangle.A, triangle.B, triangle.C)}\n");
            Console.WriteLine($"Периметр: {triangle.GetPerimetr(triangle.A, triangle.B, triangle.C)}\n");
            Console.WriteLine($"Площадь: {triangle.GetArea(triangle.A, triangle.B, triangle.C)}\n");
            Console.ReadKey();
        }
    }
}

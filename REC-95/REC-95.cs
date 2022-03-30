using System;

namespace REC_95
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle T = new Triangle();

            T.A.X = 1;
            T.A.Y = 1;
            T.B.X = 5;
            T.B.Y = 1;
            T.C.X = 3;
            T.C.Y = 5;

            Console.WriteLine($"Вершины: {T.GetPoints(T.A, T.B, T.C)}\n");
            Console.WriteLine($"Периметр: {T.GetPerimetr(T.A, T.B, T.C)}\n");
            Console.WriteLine($"Площадь: {T.GetArea(T.A, T.B, T.C)}\n");
            Console.ReadKey();
        }
    }
}

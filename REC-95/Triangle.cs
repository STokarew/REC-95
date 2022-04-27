using System;

namespace REC_95
{
    internal class Triangle
    {
        private readonly Point _a;
        private readonly Point _b;
        private readonly Point _c;

        public Triangle(Point a, Point b, Point c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public string GetPoints()
        {
            return $"A({_a.X},{_a.Y}) B({_b.X},{_b.Y}) C({_c.X}, {_c.Y})";
        }

        public double GetPerimetr(Point _a, Point _b, Point _c)
        {
            var perimetr =
               (SideLength(_a, _b) + SideLength(_b, _c) + SideLength(_c, _a));
            return perimetr;
        }

        public double GetArea()
        {
            // не проверял верность формулы
            var halfPerimetr = GetPerimetr(_a, _b, _c) / 2;
            var area = Math.Sqrt(halfPerimetr
                * (halfPerimetr - SideLength(_a, _b))
                * (halfPerimetr - SideLength(_b, _c))
                * (halfPerimetr - SideLength(_c, _a)));
            return area;
        }

        private double SideLength(Point a, Point b)
        {
            // не проверял верность формулы
            var abLength = Math.Sqrt(
               Math.Pow((b.X - a.X), 2) + Math.Pow((b.Y - a.Y), 2));
            return abLength;
        }
    }
}

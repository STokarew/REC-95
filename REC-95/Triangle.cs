using System;

namespace REC_95
{
    class Triangle
    {
        internal Point A { get; set; } = new Point();
        internal Point B { get; set; } = new Point();
        internal Point C { get; set; } = new Point();

        internal string GetPoints(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
            var str = $"A({A.X},{A.Y}) B({B.X},{B.Y}) C({C.X}, {C.Y})";
            return str;
        }

        private double GetSide(Point a, Point b)
        {
            A = a;
            B = b;
            var AB = Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
            return AB;
        }

        internal double GetPerimetr(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
            var P = (GetSide(A, B) + GetSide(B, C) + GetSide(C, A));
            return P;
        }

        internal double GetArea(Point a, Point b, Point c)
        {
            var S = Math.Sqrt(GetPerimetr(A, B, C) / 2
                * (GetPerimetr(A, B, C) / 2 - GetSide(A, B))
                * (GetPerimetr(A, B, C) / 2 - GetSide(B, C))
                * (GetPerimetr(A, B, C) / 2 - GetSide(C, A)));
            return S;
        }

    }
}

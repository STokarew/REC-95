using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REC_95
{
    class Triangle
    {
        public Point A { set; get; }
        public Point B { set; get; }
        public Point C { set; get; }

        public Double AB;
        public Double BC;
        public Double CA;
        public Double P;
        public Double S;

        public Triangle(Point a, Point b, Point c)
        {
            A = a;
            B = b;
            C = c;
            AB = Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
            BC = Math.Sqrt(Math.Pow((C.X - B.X), 2) + Math.Pow((C.Y - B.Y), 2));
            CA = Math.Sqrt(Math.Pow((A.X - C.X), 2) + Math.Pow((A.Y - C.Y), 2));
            P = (AB + BC + CA);
            S = Math.Sqrt(P / 2 * (P / 2 - AB) * (P / 2 - BC) * (P / 2 - CA));/* формула герона*/

            if ((AB >= BC + CA) | (BC >= AB + CA) | (CA >= AB + BC))
            {
                throw new ArgumentNullException(nameof(Triangle));
            }
        }
        public void showPoints()
        {
            Console.WriteLine($"\nA({A.X},{A.Y})\nB({B.X},{B.Y})\nC({C.X},{C.Y})\n");
        }
        public void showSides()
        {
            Console.WriteLine($"AB = {AB}\nBC = {BC}\nCA = {CA}\n");
        }
        public void showPerimetr()
        {
            Console.WriteLine($"P = {P}\n");
        }
        public void showArea()
        {
            Console.WriteLine($"S = {S}");
        }
    }

}

using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;
            Point p1 = new Point(5, 4);
            Point p2 = new Point(3, 4);
            Point p3 = new Point(5, 6);
            p1.PrintInfo();
            p1.FindDistance(p2);
            p1.FindVectorTo(p2);
            p1.Translate(2, 1);
            p1.Scale(2);
            p3.Centre_rotate(pi / 3);
            p3.Rotate(p1, pi / 3);
        }
    }

}

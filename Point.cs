using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp
{
    class Point
    {
        internal double _x;
        internal double _y;
        internal double  _rho;
        internal double _theta;
        internal Point P;
        internal double _dist;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
            FindRho(x, y);
            FindTheta(x, y);
        }
        public Point()
        {
            _x = 0;
            _y = 0;
            FindRho(_x, _y);
            FindTheta(_x, _y);
        }
        public virtual void FindRho(double x, double y)
        {
            //Distance to origin (0, 0)
            _rho = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public virtual void FindTheta(double x, double y)
        {
            //Angle to horizontal axis
            _theta = Math.Atan2(y, x);
        }
        public void PrintInfo()
        {
            Console.WriteLine("x = {0}", _x);
            Console.WriteLine("y = {0}", _y);
            Console.WriteLine("rho = {0}", _rho);
            Console.WriteLine("theta = {0}", _theta);
        }

        public void FindDistance(Point p)
        {
            //Distance to other
            _dist = Math.Sqrt(Math.Pow(this._x - p._x, 2) + Math.Pow(this._y - p._y, 2));
            Console.WriteLine("Distance between points = {0}", _dist);
        }

        public void FindVectorTo(Point p)
        {
            //Returns the Point representing the vector from self to other Point
            P = new Point(this._x - p._x, this._y - p._y);
            Console.WriteLine("Point({0}; {1})", P._x, P._y);
        }

        public void Translate(double dx, double dy)
        {
            this._x += dx;
            this._y += dy;
            Console.WriteLine("Point({0};{1}) moved to ({2}; {3})", _x - dx, _y - dy, _x, _y);
        }

        public void Scale (double factor)
        {
            this._x *= factor;
            this._y *= factor;
            Console.WriteLine("Point({0};{1}) scaled to ({2}; {3}), Factor = {4}", _x / factor, _y / factor, _x, _y, factor);
        }

        public void Centre_rotate(double angle)
        {
            _x = this._rho * Math.Cos(this._theta + angle);
            _y = this._rho * Math.Sin(this._theta + angle);
            Console.WriteLine("Point({0},{1})", _x, _y);
        }

        public void Rotate(Point p, double angle)
        {
            Point B = new Point(_x - p._x, _y - p._y);
            B.Centre_rotate(angle);
            B._x += p._x;
            B._y += p._y;
            Console.WriteLine("Point({0}; {1})", B._x, B._y);
        }

    }


}

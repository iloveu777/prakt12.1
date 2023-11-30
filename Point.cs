using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace prakt12._1
{
    internal class Point
    {
        public double X;
        public double Y;
        public Point() { }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public void Print()
        {
            WriteLine($"X - {X}, Y - {Y}");
        }
        public void Distance()
        {
            WriteLine($"расстояние от начала координат до точки = {Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)):f2}");
        }
    }
}

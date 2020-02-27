using System;
using System.Linq;

namespace FiguresLib
{
    public abstract class Figure
    {
        public abstract double Area();
    }

    public class Circle : Figure
    {
        private double radius;

        public Circle(double r)
        {
            if (r > 0)
                radius = r;
            else
                throw new Exception("Это не круг!");
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;


        public Triangle(double a, double b, double c)
        {
            // сохраняем самую большую сторону в this.c
            if (a >= b && a >= c)
            {
                this.c = a;
                this.a = c;
                this.b = b;
            }
            else if (b >= a && b >= c)
            {
                this.c = b;
                this.b = c;
                this.a = a;
            }
            else if (c >= b && c >= a)
            {
                this.c = c;
                this.a = a;
                this.b = b;
            }

            if (this.c >= this.a + this.b)
            {
                throw new Exception("Ошибка! Это не треугольник!");
            }
        }

        public override double Area()
        {
            // полупериметр
            double p = (a + b + c) / 2;
            // по формуле Герона
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool CheckIfRight()
        { 
            return (c*c == a*a + b*b);
        }

    }
}

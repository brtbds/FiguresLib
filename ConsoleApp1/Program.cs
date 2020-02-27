using System;
using FiguresLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Figure[] figures = new Figure[3];

            figures[0] = new Circle(2);
            figures[1] = new Triangle(4, 6, 3);

            Circle cir = new Circle(5);

            figures[2] = cir;

            foreach (Figure f in figures)
            {
                Console.WriteLine(f.Area());

            }
        }
    }
}

using System;
using Xunit;

namespace FiguresLib.Tests
{
    public class FigureTest
    {
        [Fact]
        public void Raidus_Less_Than_Zero_Exception()
        {
            Assert.Throws<Exception>(() => new Circle(-5));
        }

        [Fact]
        public void Check_Area_Circle()
        {
            double radius = 6;
            double area = radius * radius * Math.PI;

            Figure cir = new Circle(radius);
            double result = cir.Area();

            Assert.Equal(area, result);
        }

        [Fact]
        public void Triangle_Side_Less_Than_Zero()
        {
            Assert.Throws<Exception>(() => new Triangle(4, 5, -2));
        }

        [Fact]
        public void Triangle_Side_Is_Zero()
        {
            Assert.Throws<Exception>(() => new Triangle(0, 2, 3));
        }

        [Fact]
        public void Triangle_Side_Bigger_Than_Other_Two_Sum()
        {
            Assert.Throws<Exception>(() => new Triangle(4, 5, 21));
        }

        [Fact]
        public void Triangle_Side_Equals_Other_Two_Sum()
        {
            Assert.Throws<Exception>(() => new Triangle(4, 5, 9));
        }

        [Fact]
        public void Triangle_Check_Area()
        {
            const double AREA_SIZE = 12;
            Figure triangle = new Triangle(5, 5, 6);

            double result = triangle.Area();

            Assert.Equal(AREA_SIZE, result);
        }

        [Fact]
        public void Triangle_Check_If_Right()
        {
            Triangle triangle = new Triangle(5, 3, 4);

            bool result = triangle.CheckIfRight();

            Assert.True(result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASD_Square_exercise
{
    class Square
    {
        private Point A;
        private Point B;
        private Point C;
        private Point D;
        private double sideA;
        private double sideB;
        public double x1;
        public double x2;
        public double y1;
        public double y2;

        public Square(double x1,double y1,double x2,double y2)
        {
            this.A = new Point(x1, y1);
            this.C = new Point(x2, y2);
            this.B = new Point(x2, y1);
            this.D = new Point(x1, y2);
            this.sideA=calculateSide(A,B);
            this.sideB = calculateSide(A, D);
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;            
        }
        
        private double calculateSide(Point a, Point b)
        {
            double firstPair = Math.Abs(b.x - a.x);
            double secondPair = Math.Abs(b.y - a.y);
            return Math.Sqrt(Math.Pow(firstPair,2)+Math.Pow(secondPair,2));
        }

        public double CalculateArea()
        {
            return sideA * sideB;
        }
        //static void Main(string[] args) { //test
        //    Square sqr = new Square(2, 0, 4, 1);
        //    sqr.CalculateArea();

        //}
    }
}

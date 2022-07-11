using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class Triangle
    {
        private double a;
        private double b;
        private double c;
        private double square;
        private bool isright;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            Square();
        }
        private void Square()
        {
            double p = (a + b + c) / 2;
            square = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
        public void Isright_triangle()
        {
            if (Math.Pow(c, 2) == ((Math.Pow(a, 2)) + Math.Pow(b, 2)))
            {
                isright = true;
            }
            else isright = false;
            
        }
    }
}

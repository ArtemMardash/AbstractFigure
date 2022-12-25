using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    public class Triangle : Figure
    {
        private double a;
        private double c;
        private double b;


        public Triangle(string name, double a, double c, double b) : base(name)
        {
            this.a = a;
            this.c = c;
            this.b = b;
        }

        public override double Area2 { 
            get 
            {
                double p, s;
                p = (a + b + c) / 2;
                s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine($"Отработало свойство Area2 класса Triangle S = {s}");
                return s;
            } 
        }
        public override void Area()
        {
            double p, s;
            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine($"S = {s}");
        }
        public void SetABC(double a, double b, double c)
        {
            if(a + b >c && c + a >b && c+b > a)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            else
            {
                this.a = 1;
                this.b = 1;
                this.c = 1;
            }
        }
        public void GetABC(out double a, out double b, out double c)
        {
            a = this.a;
            b = this.b;
            c = this.c;
        }

        public new virtual void Print()
        {
            base.Print();
            Console.WriteLine($"a = {a}\n b = {b}\n c = {c}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFigure
{
    public abstract class Figure
    {
        private string name;
        public string Name { get { return name; } set { if (value.Length > 3) name = value; } }
        public abstract double Area2 { get; }
        public Figure(string name)
        {
            this.name = name;
        }

        public abstract void Area();

        public virtual void Print()
        {
            Console.WriteLine($"Figure name - {name}");
        }
    }
}

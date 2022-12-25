namespace AbstractFigure
{

    public class TriangleColour : Triangle
    {
        private int colour;
        public int Colour { get { return colour; } set { if (value > 0 && value <= 255) colour = value; else { this.colour = 0; } } }
       
        public override double Area2
        {
            get
            {
                Console.WriteLine($"Отработало свойство Area2 класса TriangleColour.");
                return base.Area2;
            }
        }

        public TriangleColour(string name, double a, double c, double b, int colour) : base(name, a, c, b)
        {
            if (colour > 0 && colour <= 255) this.colour = colour;
            else this.colour = 0;
        }
        public new void Area()
        {
            base.Area();
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Colour number = {colour}\n");
        }
    }
}

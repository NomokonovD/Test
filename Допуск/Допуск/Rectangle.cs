namespace Task 
{
    class Rectangle : Square
    {
        public Rectangle(double Height, double Width) : base(Height)
        {
            this.Height = Height;
            this.Width = Width;
        }

        public override double Area()
        {
            return Height * Width;
        }

        public override void Print()
        {
            Console.WriteLine("Площадь прямоугольника с высотой " + Height + " и шириной " + Width + " = " + Area());
        }
    }
}

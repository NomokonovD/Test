

namespace Task
{
    class Square: Figure
    {
        protected double Height;
        protected double Width;

        public Square(double side) { 
            Height = Width=side;
        }

        public override double Area()
        {
            return Height*Width;
        }

        public virtual void Print()
        {
            Console.WriteLine("Площадь квадрата со стороной " + Height + " = " + Area());
        }
    }

    
}

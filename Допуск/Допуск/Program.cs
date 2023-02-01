namespace Task
{
    abstract class Figure
    {
        public abstract double Area();

    }

    class Program
    {
        static void Main(string[] args)
        {
            Figure circle  = new Circle(5);
            Console.WriteLine("Площадь круга = "+ circle.Area());

            var square = new Square(10);
            square.Print();

            var rectangle = new Rectangle(5,7);
            rectangle.Print();
        }
    }
}
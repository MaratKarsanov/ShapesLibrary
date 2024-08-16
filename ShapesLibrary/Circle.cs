namespace ShapesLibrary
{
    public class Circle : IShape
    {
        private double radius;
        public double Radius 
        { 
            get
            {
                return radius;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Radius must be a positive number");
                radius = value;
            }
        }
        public double Square => 2 * Math.PI * Radius * Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }
    }
}

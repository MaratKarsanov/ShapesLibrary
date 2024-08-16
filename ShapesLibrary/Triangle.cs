namespace ShapesLibrary
{
    public class Triangle : IShape
    {
        private double firstSide;
        private double secondSide;
        private double thirdSide;
        public double FirstSide
        {
            get
            {
                return firstSide;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Side of a triangle must be a positive number");
                if (!IsExisting(value, secondSide, thirdSide))
                    throw new ArgumentException("The triangle inequality does not hold");
                firstSide = value;
            }
        }
        public double SecondSide
        {
            get
            {
                return secondSide;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Side of a triangle must be a positive number");
                if (!IsExisting(firstSide, value, thirdSide))
                    throw new ArgumentException("The triangle inequality does not hold");
                secondSide = value;
            }
        }
        public double ThirdSide
        {
            get
            {
                return thirdSide;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Side of a triangle must be a positive number");
                if (!IsExisting(firstSide, secondSide, value))
                    throw new ArgumentException("The triangle inequality does not hold");
                thirdSide = value;
            }
        }
        public double Square
        {
            get
            {
                var p = (firstSide + secondSide + thirdSide) / 2;
                return Math.Sqrt(p * (p - firstSide) * (p - secondSide) * (p - thirdSide));
            }
        }
        public bool IsRight
        {
            get
            {
                var firstSideSquare = firstSide * firstSide;
                var secondSideSquare = secondSide * secondSide;
                var thirdSideSquare = thirdSide * thirdSide;
                return firstSideSquare == secondSideSquare + thirdSideSquare
                    || secondSideSquare == firstSideSquare + thirdSideSquare
                    || thirdSideSquare == firstSideSquare + secondSideSquare;
            }
        }

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0 || secondSide <= 0 || thirdSide <= 0)
                throw new ArgumentException("Sides of a triangle must be a positive numbers");
            if (!IsExisting(firstSide, secondSide, thirdSide))
                throw new ArgumentException("The triangle inequality does not hold");
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.thirdSide = thirdSide;
        }

        private bool IsExisting(double firstSide, double secondSide, double thirdSide)
        {
            return firstSide < secondSide + thirdSide
                && secondSide < firstSide + thirdSide
                && thirdSide < secondSide + firstSide;
        }
    }
}

namespace ShapesLibrary.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(5, 4, 7)]
        [InlineData(2, 3, 4.5)]
        public void IsRight_WhenNotRight_ReturnsFalse(double firstSide,
            double secondSide,
            double thirdSide)
        {
            //Arrange
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            //Act
            var result = triangle.IsRight;

            //Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(5, 12, 13)]
        [InlineData(8, 15, 17)]
        public void IsRight_WhenRight_ReturnsTrue(double firstSide,
            double secondSide,
            double thirdSide)
        {
            //Arrange
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            //Act
            var result = triangle.IsRight;

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void Constructor_WithZeroSide_ThrowsRightException()
        {
            try
            {
                var triangle = new Triangle(1, 1, 0);
            }
            catch(ArgumentException ex)
            {
                Assert.Equal("Sides of a triangle must be a positive numbers", ex.Message);
            }
        }

        [Fact]
        public void Constructor_WithNegativeSide_ThrowsRightException()
        {
            try
            {
                var triangle = new Triangle(1, 1, -1);
            }
            catch (ArgumentException ex)
            {
                Assert.Equal("Sides of a triangle must be a positive numbers", ex.Message);
            }
        }

        [Fact]
        public void Constructor_WithWrongSides_ThrowsRightException()
        {
            try
            {
                var triangle = new Triangle(1, 1, 5);
            }
            catch (ArgumentException ex)
            {
                Assert.Equal("The triangle inequality does not hold", ex.Message);
            }
        }

        [Theory]
        [InlineData(3, 4, 5)]
        [InlineData(5, 12, 13)]
        [InlineData(8, 15, 17)]
        public void Square_WhenRight_ReturnsRightValue(double firstSide,
            double secondSide,
            double thirdSide)
        {
            //Arrange
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            //Act
            var result = triangle.Square;

            //Assert
            Assert.Equal(firstSide * secondSide / 2, result);
        }

        [Fact]
        public void Square_5and4and7_ReturnsRightValue()
        {
            //Arrange
            var triangle = new Triangle(5, 4, 7);

            //Act
            var result = triangle.Square;

            //Assert
            Assert.True(Math.Abs(9.797959 - result) < 0.001);
        }
    }
}
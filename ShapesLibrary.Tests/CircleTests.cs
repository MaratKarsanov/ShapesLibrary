namespace ShapesLibrary.Tests
{
    public class CircleTests
    {
        [Theory]
        [InlineData(-2)]
        [InlineData(0)]
        public void Constructor_WithWrongRadius_ThrowsRightException(double radius)
        {
            try
            {
                var circle = new Circle(radius);
            }
            catch(ArgumentException ex)
            {
                Assert.Equal("Radius must be a positive number", ex.Message);
            }
        }

        [Theory]
        [InlineData(2)]
        [InlineData(5)]
        [InlineData(10)]
        public void Square_ReturnsRightValue(double radius)
        {
            //Arrange
            var circle = new Circle(radius);

            //Act
            var result = circle.Square;

            //Assert
            Assert.Equal(2 * Math.PI * circle.Radius * circle.Radius, result);
        }
    }
}

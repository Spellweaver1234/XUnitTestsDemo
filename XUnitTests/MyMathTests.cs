using UnitTestsDemo;

using Xunit;

namespace XUnitTests
{
    public class MyMathTests
    {
        [Fact]
        public  void SumResult2()
        {
            // Arrange
            MyMath myMath = new();

            // Act
            var result = myMath.Sum(1, 1);

            // Assert
            Assert.Equal(2, result);
        }
        [Fact]
        public void SumResult0()
        {
            // Arrange
            MyMath myMath = new();

            // Act
            var result = myMath.Sum(0, 0);

            // Assert
            Assert.Equal(0, result);
        }
        [Fact]
        public void SumResult10()
        {
            // Arrange
            MyMath myMath = new();

            // Act
            var result = myMath.Sum(5, 5);

            // Assert
            Assert.Equal(10, result);
        }
        [Fact]
        public void SumWrongResult()
        {
            // Arrange
            MyMath myMath = new();

            // Act
            var result = myMath.Sum(1, 1);

            // Assert
            Assert.NotEqual(3, result);
        }
    }
}
using Xunit;

namespace Maskinpark.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var arrange = false;

            // Act
            var actual = true;


            // Assert
            Assert.Equal(actual, arrange);
        }
    }
}
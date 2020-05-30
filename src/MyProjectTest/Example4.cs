using System;
using Xunit;
using Xunit.Abstractions;

namespace MyProjectTest
{
    public class Example4
    {
        private readonly ITestOutputHelper _output;
        private string message = "Division by zero is not accepted";

        public Example4(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void ShouldFailDivideByZero()
        {
            var ex = Assert.Throws<DivideByZeroException>(() => ThrowAnException());
            Assert.Equal(message, ex.Message);
        }

        [Fact]
        public void ShouldFailDivideByZeroRecord()
        {
            // Arrange
            var ex = Record.Exception(() => ThrowAnException());

            // Act
            if (!(ex is DivideByZeroException))
                Assert.True(false);

            // Assert
            Assert.Equal(message, ex.Message);
        }

        private void ThrowAnException()
        {
            throw new DivideByZeroException(message);
        }
    }
}

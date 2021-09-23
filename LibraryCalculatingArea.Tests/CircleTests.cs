using System;
using Xunit;

namespace LibraryCalculatingArea.Tests
{
    public class CircleTests
    {
        [Fact]
        public void SquareTest()
        {
            Circle circle = new(2.00); 
            
            var result = circle.Square(); 
            
            Assert.Equal(Math.Round(12.56637, 4), Math.Round(result, 4));
        }
    }
}
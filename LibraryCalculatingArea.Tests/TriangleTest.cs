using System;
using Xunit;

namespace LibraryCalculatingArea.Tests
{
    public class TriangleTest
    {
        [Fact]
        public void SquareTest()
        {
            Triangle triangle = new(4, 5, 6);

            var result = triangle.Square();
            
            Assert.Equal(Math.Round(9.92156, 4), Math.Round(result, 4));
        }
        
        [Fact]
        public void IsRightTriangleTest()
        {
            Triangle triangle = new(26, 24, 10);

            var result = triangle.IsRightTriangle();
            
            Assert.True(result);
        }
    }
}
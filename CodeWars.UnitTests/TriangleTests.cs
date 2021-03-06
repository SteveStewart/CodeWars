﻿using Xunit;

namespace CodeWars.UnitTests
{
    //Trait is a way of grouping and organising tests, not required but have left it here 
    //as a reminder.
    [Trait("Category", "Triangle")]
    public class TriangleTests
    {
        [Fact]
        public void IsTriangle_ValidPostiveNumbers_ReturnsTrue()
        {
            Assert.True(Triangle.IsTriangle(5, 7, 10));
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, 3, 2)]
        [InlineData(3, 1, 2)]
        public void IsTriangle_SumOfSidesEqualOtherSide_ReturnsFalse(int a, int b, int c)
        {
            Assert.False(Triangle.IsTriangle(a, b, c));
        }

        [Theory]
        [InlineData(-1, 2, 3)]
        [InlineData(1, -2, 3)]
        [InlineData(1, 2, -3)]
        public void IsTriangle_NegativeSides_ReturnsFalse(int a, int b, int c)
        {
            Assert.False(Triangle.IsTriangle(a, b, c));
        }

        [Theory]
        [InlineData(1, 2, 4)]
        [InlineData(4, 1, 2)]
        [InlineData(1, 4, 2)]
        public void IsTriangle_PositiveSides_ReturnsFalse(int a, int b, int c)
        {
            Assert.False(Triangle.IsTriangle(a, b, c));
        }
    }
}

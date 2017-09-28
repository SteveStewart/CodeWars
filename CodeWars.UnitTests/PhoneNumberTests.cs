using Xunit;

namespace CodeWars.UnitTests
{
    //Trait is a way of grouping and organising tests, not required but have left it here 
    //as a reminder.
    [Trait("Category", "PhoneNumber")]
    public class PhoneNumberTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }, "(123) 456-7890")]
        [InlineData(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, "(111) 111-1111")]
        [InlineData(new int[] { 10, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, "")]
        [InlineData(new int[] { 10, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }, "")]
        public void FixedTest(int[] numbers, string result)
        {
            Assert.Equal(PhoneNumber.CreatePhoneNumber(numbers), result);
        }

    }
}

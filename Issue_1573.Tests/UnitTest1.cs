namespace Issue_1573.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(MyEnumExtensions.TryParse("something", out var value));
        }
    }
}
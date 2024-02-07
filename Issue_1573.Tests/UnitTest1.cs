namespace Issue_1573.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.True(Class1.TryParse("something", out var value));
        }
    }
}
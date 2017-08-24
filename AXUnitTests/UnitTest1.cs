using System;
using Xunit;

namespace AXUnit
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var s = Library1.GetMessage();
            Assert.Equal(s, "Hello there Boy");
        }
    }
}

using System;
using SimpleApp;
using Xunit;

namespace SimpleUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var logic = new SomeLogic();
            var date = new DateTime(2019, 10, 30);
            var actual = logic.GetDayOfWeek(date);

            Assert.Equal("Wednesday", actual);
        }
    }
}

using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            var book = new Book("");

            var expected = 15;
            Assert.Equal(expected, actual);
        }
    }
}

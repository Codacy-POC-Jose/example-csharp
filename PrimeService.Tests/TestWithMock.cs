using System;
using Xunit;

namespace PrimeService.Tests
{
    public class TestWithMock
    {
        private class TestMockData : IMockMe
        {
            public TestMockData(int testData)
            {
                this.TestData = testData;
            }

            public int TestData { get; }
            public int OtherData => throw new NotImplementedException();
        }
        
        [Fact]
        public void Test1()
        {
            IMockMe input = new TestMockData(11);
            Assert.False(15 == input.TestData);
        }
    }
}

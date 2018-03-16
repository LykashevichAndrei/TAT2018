using System;
using Xunit;
using task_DEV_2;

namespace XUnitTestProject1
{
    public class EvenElementsOfTheStringTest
    {
        [Fact]
        [Xunit.Theory]
        [InlineData("abcdef","ace")]
        [InlineData("abab","aa")]
        public void CreateNewStringWithEvenElements(string NewString, string Result)
        {
            EvenElementsOfTheString str = new EvenElementsOfTheString();
            string testResult = FindingEvenElemenstInString();
            Xunit.Assert.Equal(Result, testResult);
        }
    }
}

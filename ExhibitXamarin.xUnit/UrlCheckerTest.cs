using System;
using Xunit;
using static ExhibitXamarin.UrlChecker;

namespace ExhibitXamarin.xUnit
{
    public class UrlCheckerTest
    {
        private readonly UrlChecker checker;

        public UrlCheckerTest()
        {
            checker = new UrlChecker();
        }

        [Fact]
        public void Check_Null_IllegalUrlException()
        {
            Action act = () => checker.Check(null);
            Assert.Throws<IllegalUrlException>(act);
        }

        [Fact]
        public void Check_EmptyString_IllegalUrlException()
        {
            Action act = () => checker.Check("");
            Assert.Throws<IllegalUrlException>(act);
        }

        [Fact]
        public void Check_BadUrl_IllegalUrlException()
        {
            Action act = () => checker.Check("s");
            Assert.Throws<BadUrlException>(act);
        }

        [Fact]
        public void Check_HttpUrl_HttpUrlException()
        {
            Action act = () => checker.Check("http://");
            Assert.Throws<HttpUrlException>(act);
        }

        [Fact]
        public void Check_HttpsUrl()
        {
            checker.Check("https://google.com");
        }

        private void AssertIllegalUrlException(Action act)
        {
            Assert.Throws<IllegalUrlException>(act);
        }
    }
}

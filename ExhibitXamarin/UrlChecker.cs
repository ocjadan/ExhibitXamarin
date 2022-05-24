using System;
namespace ExhibitXamarin
{
    public class UrlChecker
    {
        public UrlChecker()
        {
        }

        public void Check(string url)
        {
            CheckNull(url);
            CheckEmpty(url);
            CheckHttp(url);
            CheckHttps(url);
        }

        private void CheckEmpty(string url)
        {
            if (url.Length == 0)
                throw new IllegalUrlException();
        }

        private void CheckNull(string url)
        {
            if (url == null)
                throw new IllegalUrlException();
        }

        private void CheckHttp(string url)
        {
            if (url.StartsWith("http:"))
                throw new HttpUrlException();
        }

        private void CheckHttps(string url)
        {
            if (!url.StartsWith("https://"))
                throw new BadUrlException();
        }

        public class IllegalUrlException : Exception { }
        public class HttpUrlException : Exception { }
        public class BadUrlException : Exception { }
    }
}

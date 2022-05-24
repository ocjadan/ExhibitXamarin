using System;
using System.Threading.Tasks;
using Xunit;
using static ExhibitXamarin.UrlChecker;

namespace ExhibitXamarin.xUnit
{
    public class RestClientTest
    {
        private readonly RestClient client;

        public RestClientTest()
        {
            client = new RestClient(new UrlChecker());
        }

        [Fact]
        public async void Get_EmptyUrl_ThrowsIllegalUrlException()
        {
            Func<Task> act = () => client.Get("");
            await Assert.ThrowsAsync<IllegalUrlException>(act);
        }

        [Fact]
        public async void Get_Null_ThrowsIllegalUrlException()
        {
            Func<Task> act = () => client.Get(null);
            await Assert.ThrowsAsync<IllegalUrlException>(act);
        }

        [Fact]
        public async void Get_HttpUrl_ThrowsHttpUrlException()
        { 
            Func<Task> act = () => client.Get("http://");
            await Assert.ThrowsAsync<HttpUrlException>(act);
        }
    }
}

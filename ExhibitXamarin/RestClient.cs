using System.Net.Http;
using System.Threading.Tasks;

namespace ExhibitXamarin
{
    public class RestClient
    {
        private readonly UrlChecker urlChecker;

        public RestClient(UrlChecker urlChecker)
        {
            this.urlChecker = urlChecker;
        }

        public async Task<string> Get(string url)
        {
            urlChecker.Check(url);

            using (var client = new HttpClient()) {
                // TODO: Android returns a corrupt string but iOS does not.
                return await client.GetStringAsync(url);
            }
        }
    }
}

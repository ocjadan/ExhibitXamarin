using System;

namespace ExhibitXamarin
{
    public class RequestBuilder
    {
        private readonly RestClient client;
        private readonly UrlProvider urlProvider;

        public RequestBuilder(RestClient client, UrlProvider urlProvider) {
            this.client = client;
            this.urlProvider = urlProvider;
        }

        public Request Build(string name)
        {
            switch(name)
            {
                case "Questions":
                    return new GetQuestionsRequest(client, urlProvider);
                default:
                    throw new RequestDoesNotExist();
            }
        }

        public class RequestDoesNotExist : Exception { }
    }
}
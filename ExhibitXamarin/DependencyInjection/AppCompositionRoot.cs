namespace ExhibitXamarin.DependencyInjection
{
    public class AppCompositionRoot
    {
        public PageCompositionRoot PageCompositionRoot => new PageCompositionRoot(this);

        public UrlChecker UrlChecker => new UrlChecker();

        public UrlProvider UrlProvider => new UrlProvider();

        public GetQuestionsRequest GetQuestionsRequest => (GetQuestionsRequest) RequestBuilder.Build("Questions");

        private RequestBuilder RequestBuilder => new RequestBuilder(RestClient, UrlProvider);

        private RestClient RestClient => new RestClient(UrlChecker);
    }
}

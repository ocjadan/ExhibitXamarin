namespace ExhibitXamarin
{
    public class UrlProvider
    {
        private const string ApiUrl = "https://api.stackexchange.com/2.3";
        public readonly string GetQuestionsUrl = $"{ApiUrl}/questions?&site=stackoverflow";
    }
}
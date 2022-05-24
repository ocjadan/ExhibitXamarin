using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ExhibitXamarin
{
    public class GetQuestionsRequest : GetRequest<List<QuestionSchema>>
    {
        private const string ItemsKey = "items";
        private const string QuestionIdKey = "question_id";
        private const string TitleKey = "title";
        private const string IsAnsweredKey = "is_answered";
        private const string CreationDateKey = "creation_date";
        private readonly RestClient client;
        private readonly UrlProvider urlProvider;

        public GetQuestionsRequest(RestClient client, UrlProvider urlProvider)
        {
            this.client = client;
            this.urlProvider = urlProvider;
        }

        public async Task<List<QuestionSchema>> GetAsync()
        {
            string response = await client.Get(urlProvider.GetQuestionsUrl);
            return ParseToQuestions(response);
        }

        private List<QuestionSchema> ParseToQuestions(string response)
        {
            return JObject
                .Parse(response)[ItemsKey]
                .Children()
                .Select((JToken token) => new QuestionSchema(
                    token.Value<long>(QuestionIdKey),
                    token.Value<string>(TitleKey),
                    token.Value<bool>(IsAnsweredKey),
                    token.Value<long>(CreationDateKey))
                )
                .ToList();
        }
    }
}

using System.Collections.Generic;

namespace ExhibitXamarin
{
    public class QuestionsViewModel
    {
        private GetQuestionsRequest _getQuestionsRequest;

        public QuestionsViewModel(GetQuestionsRequest getQuestionsRequest)
        {
            _getQuestionsRequest = getQuestionsRequest;
        }

        public async void GetQuestions()
        {
            List<QuestionSchema> questions = await _getQuestionsRequest.GetAsync();
        }
    }
}

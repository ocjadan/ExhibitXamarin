namespace ExhibitXamarin
{
    public class QuestionSchema
    {
        public long QuestionId;
        public bool IsAnswered;
        public long CreationDate;
        public string Title;

        public QuestionSchema(long questionId, string title, bool isAnswered, long creationDate)
        {
            QuestionId = questionId;
            Title = title;
            IsAnswered = isAnswered;
            CreationDate = creationDate;

        }
    }
}

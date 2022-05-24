namespace ExhibitXamarin.DependencyInjection
{
    public class PageCompositionRoot
    {
        private AppCompositionRoot _appCompositionRoot;

        public PageCompositionRoot(AppCompositionRoot appCompositionRoot)
        {
            _appCompositionRoot = appCompositionRoot;
        }

        public QuestionsViewModel QuestionsViewModel => new QuestionsViewModel(_appCompositionRoot.GetQuestionsRequest);
    }
}

using System;
using ExhibitXamarin.DependencyInjection;
using Xamarin.Forms;

namespace ExhibitXamarin
{
    public partial class MainPage : ContentPage
    {
        private Lazy<PageCompositionRoot> _pageCompositionRoot = new Lazy<PageCompositionRoot>(() => (Application.Current as App).AppCompositionRoot.Value.PageCompositionRoot);
        protected PageCompositionRoot PageCompositionRoot => _pageCompositionRoot.Value;

        private QuestionsViewModel _questionsViewModel;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            _questionsViewModel = PageCompositionRoot.QuestionsViewModel;
            base.OnAppearing();
            _questionsViewModel.GetQuestions();
        }
    }
}

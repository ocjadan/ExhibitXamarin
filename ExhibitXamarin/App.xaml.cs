using System;
using ExhibitXamarin.DependencyInjection;
using Xamarin.Forms;

namespace ExhibitXamarin
{
    public partial class App : Application
    {
        public Lazy<AppCompositionRoot> AppCompositionRoot = new Lazy<AppCompositionRoot>();

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

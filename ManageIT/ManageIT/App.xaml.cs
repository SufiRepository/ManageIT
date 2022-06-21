using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ManageIT
{
    public partial class App : Application
    {
        public App()
        {
            //InitializeComponent();

            //MainPage = new MainPage();
            InitializeComponent();
            MainPage = new NavigationPage(new Views.MainLogin.MainLogin());
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

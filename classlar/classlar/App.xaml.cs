using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace classlar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Get<Database>().GetData();
            MainPage = new NavigationPage(new AnaSayfa());
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

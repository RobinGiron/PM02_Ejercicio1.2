using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Tarea1_2.Views;

namespace Tarea1_2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new BindingPage());
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

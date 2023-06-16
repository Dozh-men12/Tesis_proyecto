using System.ComponentModel;
using Tesis.View.Tabbed;
using Xamarin.Forms;

namespace Tesis
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContainerTabbedPage();
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


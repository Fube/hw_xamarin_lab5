using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
{
    public partial class App : Application
    {

        static DBUser database;
        public static DBUser Database
        {
            get
            {
                if (database == null)
                {
                    database = new DBUser(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "user.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new RegisterPage());
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

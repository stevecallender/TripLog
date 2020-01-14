using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TripLog
{
    public partial class App : Application
    {
        public static string FolderPath { get; set; }

        public App()
        {
            InitializeComponent();
            FolderPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData));
            MainPage = new NavigationPage(new MyPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

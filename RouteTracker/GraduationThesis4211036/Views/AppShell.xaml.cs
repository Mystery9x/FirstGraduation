using GraduationThesis4211036.Views;
using System;
using Xamarin.Forms;

namespace GraduationThesis4211036
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new MainPage();
        }
    }
}

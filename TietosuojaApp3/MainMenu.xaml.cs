using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TietosuojaApp3
{
    public partial class MainMenu : ContentPage
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var page = new GameScreen();

            Navigation.PushAsync(page);

            NavigationPage.SetHasNavigationBar(page, false);
        }
    }
}

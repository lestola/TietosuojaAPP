using System;
using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

using Xamarin.Forms;

namespace TietosuojaApp3
{
    public partial class MainMenu : ContentPage
    {
        //määritellään webclientti

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

        void Settings_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new SettingsScreen());
        }

        void Ohje_Clicked(object sender, System.EventArgs e)
        {
            
            Navigation.PushAsync(new Ohje());

        }
    }
}

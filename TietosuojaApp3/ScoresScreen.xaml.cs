using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TietosuojaApp3
{
    public partial class ScoresScreen : ContentPage
    {
        public ScoresScreen()
        {
            InitializeComponent();
        }

        void MainMenu_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}

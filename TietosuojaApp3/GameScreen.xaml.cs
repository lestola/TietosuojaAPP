using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TietosuojaApp3
{
    public partial class GameScreen : ContentPage
    {
        public GameScreen()
        {
            InitializeComponent();


        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ScoresScreen());
        }
    }
}

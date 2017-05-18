using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TietosuojaApp3
{
    public partial class SettingsScreen : ContentPage
    {
        public SettingsScreen()
        {
            InitializeComponent();

            HardnesLevelPicker.Items.Add("Helppo");
            HardnesLevelPicker.Items.Add("Normaali");
            HardnesLevelPicker.Items.Add("Vaikea");
            SubjectPicker.Items.Add("Tietoturva");
            SubjectPicker.Items.Add("SOTE");
            SubjectPicker.Items.Add("Yhdistykset");
            SubjectPicker.Items.Add("Oppilaitokset");
        }

        void Save_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}

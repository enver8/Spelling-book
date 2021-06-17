﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace Slovarica
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tt : ContentPage
    {
        public Tt()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("T");
        }
    }
}
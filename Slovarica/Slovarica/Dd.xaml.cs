using System;
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
    public partial class Dd : ContentPage
    {
        public Dd()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("D");
        }

        private async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Deer");
        }

        private async void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Dog");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace SitesFamosos
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.meutimao.com.br/"));
        }

        private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://globoesporte.globo.com/"));
        }

        private void TapGestureRecognizer_Tapped3(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.marvel.com/"));
        }
    }
}

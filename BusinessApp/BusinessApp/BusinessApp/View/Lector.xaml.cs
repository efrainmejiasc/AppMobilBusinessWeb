using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZXing.Net.Mobile.Forms;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BusinessApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Lector : ContentPage
	{
		public Lector ()
		{
			InitializeComponent ();
          
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Scanner();
        }


        private async void Scanner()
        {
            var scannerPage = new ZXingScannerPage();

            scannerPage.Title = "Lector de Codigo QR";
            scannerPage.OnScanResult += (result) =>
            {
                scannerPage.IsScanning = false;

                Device.BeginInvokeOnMainThread(() =>
                {
                    Navigation.PopAsync();
                    DisplayAlert("Valor Obtenido", result.Text, "OK");
                });
            };

            await Navigation.PushAsync(scannerPage);
        }

    }
}
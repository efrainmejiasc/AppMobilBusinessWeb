using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BusinessApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FacturaEntrada : ContentPage
	{
		public FacturaEntrada ()
		{
			InitializeComponent ();
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            EstablecerEncabezadoFacturaEntradaVista();
        }

        private void EstablecerEncabezadoFacturaEntradaVista()
        {
            var m = new FacturaVista()
            {
                NumeroFactura = "Nº 000051",
                Rif = "V-11346727",
                RazonSocial = "Emc Ingenieria de Software",

            };

            nroFactura.Text = m.NumeroFactura;
            miRif.Text = m.Rif;
            miRazonSocial.Text = m.RazonSocial;
            subtotal.Text = "0.00";
            total.Text = "0.00";
            descuento.Text = "0.00";
        }
	}
}
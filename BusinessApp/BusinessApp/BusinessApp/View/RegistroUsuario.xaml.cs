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
	public partial class RegistroUsuario : ContentPage
	{
		public RegistroUsuario ()
		{
			InitializeComponent ();
            btnCancelar.Clicked += Cancelar;
		}

        protected void RegistrarUsuario(object sender, EventArgs e) { }

        protected void Cancelar(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new MainPage());
        }
    }
}
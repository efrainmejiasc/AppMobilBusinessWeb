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
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
            btnRegistrar.Clicked += RegistrarUsuario;
        }

        private void RegistrarUsuario (object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new RegistroUsuario());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using BusinessApp.Models;
using BusinessApp.Engine;

namespace BusinessApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuDesplegable : MasterDetailPage
    {
        //public List<MenuModel> menuModel = new List<MenuModel>();

        public MenuDesplegable ()
		{
			InitializeComponent ();
            MyMenu();
            //BindingContext = menuModel;
		}

        public void MyMenu()
        {
            Detail = new NavigationPage(new Feed());
            List<Models.MenuModel> menuModel = new List<Models.MenuModel>()
            {
                new MenuModel{Page= new MainPage(),Id=0, MenuTitle="Perfil", MenuDetail="",icon="user.JPG"},
                new MenuModel{Page= new MainPage(),Id=1, MenuTitle="Inicio", MenuDetail="Autentificacion",icon="login.JPG"},
                new MenuModel{Page= new MainPage(),Id=2, MenuTitle="Feed", MenuDetail="Noticias",icon="feed.JPG"},
                new MenuModel{Page= new MainPage(),Id=3, MenuTitle="Asistencia Clase", MenuDetail="Listado",icon="lista.JPG"},
                new MenuModel{Page= new MainPage(),Id=4, MenuTitle="Actualizar Asistencia", MenuDetail="Lector QR",icon="qrcode.JPG"},
                new MenuModel{Page= new MainPage(),Id=5, MenuTitle="Registrar Dispositivo", MenuDetail="Tu telefono",icon="regdispositivo.JPG"},
                new MenuModel{Page= new MainPage(),Id=6, MenuTitle="Escarnear Carnet", MenuDetail="Ver",icon="vercarnet.JPG"},
                new MenuModel{Page= new MainPage(),Id=7, MenuTitle="Salir", MenuDetail="Cerrar Aplicacion",icon="logout.JPG"},
            };

            LstMenu.ItemsSource = menuModel;
        }

        private void LstMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var modelo = e.SelectedItem as MenuModel;
            switch(modelo.Id){
                case (0):
                    ((NavigationPage)this.Parent).PushAsync(new SetPerfil());
                    break;
                case (1):
                    ((NavigationPage)this.Parent).PushAsync(new Login());
                    break;
                case (2):
                    ((NavigationPage)this.Parent).PushAsync(new Feed());
                    break;
                case (3):
                    ((NavigationPage)this.Parent).PushAsync(new AsistenciaClase());
                    break;
                case (4):
                    ((NavigationPage)this.Parent).PushAsync(new ActualizarAsistencia());
                    break;
                case (5):
                    ((NavigationPage)this.Parent).PushAsync(new RegistrarDispositivo());
                    break;
                case (6):
                    ((NavigationPage)this.Parent).PushAsync(new Lector());
                    break;
                case (7):
                    var closer = DependencyService.Get<ICloseApplication>();
                    closer?.ExitApplication();
                    break;
            }

        } 

    }

}
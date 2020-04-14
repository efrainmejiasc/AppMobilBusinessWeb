using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BusinessApp.Models;
using BusinessApp.View;
using BusinessApp.Engine;

namespace BusinessApp
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            MyMenu();
        }
        protected override void OnAppearing()
        {
            try
            {
                base.OnAppearing();
                MyMenu();
            }
            catch { }

        }

        public void MyMenu()
        {
            Detail = new NavigationPage(new Feed());
            List<Models.MenuModel> menuModel = new List<Models.MenuModel>()
            {
                new MenuModel{Page= new Feed(),Id=0, MenuTitle="Perfil", MenuDetail="",icon="user.JPG"},
                new MenuModel{Page= new Feed(),Id=1, MenuTitle="Inicio", MenuDetail="Autentificacion y Registro",icon="login.JPG"},
                new MenuModel{Page= new Feed(),Id=2, MenuTitle="Feed", MenuDetail="Noticias",icon="feed.JPG"},
                new MenuModel{Page= new Feed(),Id=3, MenuTitle="Factura de Entrada", MenuDetail="Ingreso",icon="facturaentrada.JPG"},
                new MenuModel{Page= new Feed(),Id=4, MenuTitle="Factura de Salida", MenuDetail="Egreso",icon="facturasalida.JPG"},
                new MenuModel{Page= new Feed(),Id=5, MenuTitle="Escarnear Carnet", MenuDetail="Ver",icon="vercarnet.JPG"},
                new MenuModel{Page= new Feed(),Id=6, MenuTitle="Salir", MenuDetail="Cerrar Aplicacion",icon="logout.JPG"},
            };

            LstMenu.ItemsSource = menuModel;
        }

        private void LstMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var modelo = e.SelectedItem as MenuModel;
            switch (modelo.Id)
            {
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
                    ((NavigationPage)this.Parent).PushAsync(new FacturaEntrada());
                    break;
                case (4):
                    ((NavigationPage)this.Parent).PushAsync(new FacturaSalida());
                    break;
                case (5):
                    ((NavigationPage)this.Parent).PushAsync(new Lector());
                    break;
                case (6):

                    break;
                case (7):
                    var closer = DependencyService.Get<ICloseApplication>();
                    closer?.ExitApplication();
                    break;
            }
        }
    }
}

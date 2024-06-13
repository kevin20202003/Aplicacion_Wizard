using Aplicacion_Wizard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Aplicacion_Wizard.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Step3Page : ContentPage
    {
        User user;

        public Step3Page(User user)
        {
            InitializeComponent();
            this.user = user;
            NavigationPage.SetHasBackButton(this, false); // Desactiva el botón de retroceso
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            CarsListView.ItemsSource = await App.Database.GetCarsByUserAsync(user.ID);
        }

        async void OnNextButtonClicked(object sender, EventArgs e)
        {
            // Reinicia el wizard navegando a Step1Page
            await Navigation.PushAsync(new Step1Page());
        }
    }
}
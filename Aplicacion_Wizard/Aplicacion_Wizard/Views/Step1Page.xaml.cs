using Aplicacion_Wizard.Models;
using Aplicacion_Wizard.Data;
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
    public partial class Step1Page : ContentPage
    {
        public Step1Page()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false); // Desactiva el botón de retroceso
        }

        // Constructor opcional que acepta un User
        public Step1Page(User user)
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false); // Desactiva el botón de retroceso
            // Puedes usar el objeto `user` aquí si es necesario
        }

        async void OnNextButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Name = NameEntry.Text,
                Email = EmailEntry.Text
            };

            await App.Database.SaveUserAsync(user);
            await Navigation.PushAsync(new Step2Page(user));
        }
    }
}
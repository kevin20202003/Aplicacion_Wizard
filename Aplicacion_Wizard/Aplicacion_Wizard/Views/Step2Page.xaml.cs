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
    public partial class Step2Page : ContentPage
    {
        User user;

        public Step2Page(User user)
        {
            InitializeComponent();
            this.user = user;
            NavigationPage.SetHasBackButton(this, false); // Desactiva el botón de retroceso
        }

        async void OnNextButtonClicked(object sender, EventArgs e)
        {
            var car = new Car
            {
                Make = MakeEntry.Text,
                Model = ModelEntry.Text,
                Year = int.Parse(YearEntry.Text),
                UserID = user.ID
            };

            await App.Database.SaveCarAsync(car);
            await Navigation.PushAsync(new Step3Page(user));
        }
    }
}
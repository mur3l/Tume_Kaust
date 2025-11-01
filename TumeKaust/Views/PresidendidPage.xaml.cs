using TumeKaust.Models;
using TumeKaust.Services;

namespace TumeKaust.Views
{
    public partial class PresidendidPage : ContentPage
    {
        public PresidendidPage()
        {
            InitializeComponent();
        }

        // Viib valitud isiku detaili vaatesse
        private async void OnDetailsClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is Person selectedPerson)
            {
                var detailedPerson = PersonService.GetPersonDetails(selectedPerson.Name);

                if (detailedPerson != null)
                {
                    await Navigation.PushAsync(new PersonalDetails(detailedPerson));
                }

                else
                {
                    await DisplayAlert("Viga", "Isiku andmeid ei leitud.", "OK");
                }
            }
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

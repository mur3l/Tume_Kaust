using TumeKaust.Models;

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
                await Navigation.PushAsync(new PersonalDetails(selectedPerson));
            }
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

using TumeKaust.Models;

namespace TumeKaust.Views
{
    public partial class PoliitikudPage : ContentPage
    {
        public PoliitikudPage()
        {
            InitializeComponent();
        }

        private async void OnPersonSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Person selected)
            {
                await DisplayAlert("Valitud isik", selected.Name, "OK");
                // TODO: Navigate to a PersonDetails page later
            }
            ((CollectionView)sender).SelectedItem = null;
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

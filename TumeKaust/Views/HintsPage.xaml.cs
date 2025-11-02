using TumeKaust.Models;

namespace TumeKaust.Views
{
    public partial class HintsPage : ContentPage
    {
        public HintsPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            var hints = await App.HintDatabase.GetHintsAsync();

            if (hints != null && hints.Any())
                HintsCollection.ItemsSource = hints;
            else
                await DisplayAlert("Teade", "Vihjeid pole veel saadetud.", "OK");
        }
    }
}

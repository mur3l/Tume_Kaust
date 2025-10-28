using TumeKaust.Models;

namespace TumeKaust.Views
{
    public partial class SuunamudijadPage : ContentPage
    {
        public SuunamudijadPage()
        {
            InitializeComponent();
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

using TumeKaust.Models;

namespace TumeKaust.Views
{
    public partial class PresidendidPage : ContentPage
    {
        public PresidendidPage()
        {
            InitializeComponent();
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

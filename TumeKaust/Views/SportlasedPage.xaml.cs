using TumeKaust.Models;

namespace TumeKaust.Views
{
    public partial class SportlasedPage : ContentPage
    {
        public SportlasedPage()
        {
            InitializeComponent();
        }

        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}

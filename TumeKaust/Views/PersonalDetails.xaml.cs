using TumeKaust.Models;

namespace TumeKaust.Views
{
    public partial class PersonalDetails : ContentPage
    {
        private readonly Person _person;

        public PersonalDetails(Person person)
        {
            InitializeComponent();
            _person = person;
            BindingContext = _person;
        }

        private async void OnLogoTapped(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void OnNewsTapped(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is string newsText)
            {
                int newsIndex = _person.News.IndexOf(newsText);

                if (newsIndex >= 0 && newsIndex < _person.NewsLinks.Count)
                {
                    string url = _person.NewsLinks[newsIndex];
                    await Launcher.OpenAsync(url);
                }
            }
        }
    }
}
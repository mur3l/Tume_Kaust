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
    }
}
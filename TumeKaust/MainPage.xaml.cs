using TumeKaust.Models;
using TumeKaust.Services;
using TumeKaust.Views;

namespace TumeKaust
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private async void OnOpenDetailsClicked(object sender, EventArgs e)
        {
            // Võtame näidisandmed PersonService’ist
            var person = PersonService.GetPersonByName("Lennart Meri");

            // Liigume detailivaatele ja anname isiku kaasa
            await Navigation.PushAsync(new PersonalDetails(person));
        }

        private async void OnPersonSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Person selectedPerson)
            {
                await Navigation.PushAsync(new PersonalDetails(selectedPerson));
            }

            // Tühjenda valik pärast klikki
            ((CollectionView)sender).SelectedItem = null;
        }

    }
}

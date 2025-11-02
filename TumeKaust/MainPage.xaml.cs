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
            FadeInImage();
        }

        private async void OnCategorySelected(object sender, SelectionChangedEventArgs e)
        {
            // Kontrollime, kas valiti mõni element
            if (e.CurrentSelection.FirstOrDefault() is MainPageCategoryGrid selectedCategory)
            {
                await DisplayAlert("Valitud kategooria", selectedCategory.Name, "OK");

                // Tulevikus saad lisada navigeerimise:
                // await Navigation.PushAsync(new CategoryDetailPage(selectedCategory));
            }

            // Tühjendame valiku, et uuesti klõpsata saaks
            ((CollectionView)sender).SelectedItem = null;
        }

        private async void FadeInImage()
        {
            await Task.Delay(1000); // ootab 1 sekundi
            await logoimage.FadeTo(1, 5000); // 5 sekundi jooksul fade-in
        }

        private async void OnRecentSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Models.PersonalDetailsGrid selected)
            {
                // Leia inimene andmeservicest nime järgi
                var person = TumeKaust.Services.PersonService.GetPersonByName(selected.Name);
                if (person != null)
                {
                    // Ava detailivaade
                    await Navigation.PushAsync(new Views.PersonalDetails(person));
                }
                else
                {
                    await DisplayAlert("Viga", "Isiku andmeid ei leitud.", "OK");
                }
            }

            ((CollectionView)sender).SelectedItem = null;
        }

        //private async void OpenPersonalDetails(object sender, SelectionChangedEventArgs e)
        //{
        //    if (e.CurrentSelection.FirstOrDefault() is Person selected)
        //    {
        //        try
        //        {
        //            await DisplayAlert("Valitud isik", selected.Name, "OK");
        //        }
        //        catch (Exception ex)
        //        {
        //            // Handle the exception
        //            await DisplayAlert("Error", $"An error occurred: {ex.Message}", "OK");
        //        }
        //    }
        //    ((CollectionView)sender).SelectedItem = null;
        //}

        private async void OnPersonSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Person selectedPerson)
            {
                await Navigation.PushAsync(new PersonalDetails(selectedPerson));
            }

           // Tühjenda valik pärast klikki
           ((CollectionView)sender).SelectedItem = null;
        }

        private async void OnPoliitikudTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PoliitikudPage());
        }

        private async void OnSportlasedTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SportlasedPage());
        }

        private async void OnPresidendidTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PresidendidPage());
        }

        private async void OnSuunamudijadTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SuunamudijadPage());
        }

        private async void OnAllCategoriesClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Categories());
        }

        private async void OnSendHintClicked(object sender, EventArgs e)
        {
            string text = HintEntry.Text?.Trim();

            if (string.IsNullOrEmpty(text))
            {
                await DisplayAlert("Tühjus", "Palun kirjuta midagi enne saatmist.", "OK");
                return;
            }

            var hint = new Hint { Text = text };
            await App.HintDatabase.SaveHintAsync(hint);

            HintEntry.Text = string.Empty;
            await DisplayAlert("Aitäh!", "Sinu vihje salvestati edukalt.", "OK");
        }

        private async void OnViewHintsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.HintsPage());
        }



    }
}

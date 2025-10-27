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
                }

        //private async void OnRecentSelected(object sender, SelectionChangedEventArgs e)
        //{
        //    if (e.CurrentSelection.FirstOrDefault() is Models.PersonalDetailsGrid selected)
        //    {
        //        await DisplayAlert("Valitud isik", selected.Name, "OK");
        //        // Tulevikus: await Navigation.PushAsync(new PersonDetailPage(selected));
        //    }
        //    ((CollectionView)sender).SelectedItem = null;
        //}
    }
}

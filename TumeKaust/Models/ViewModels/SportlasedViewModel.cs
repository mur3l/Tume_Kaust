using System.Collections.ObjectModel;
using System.Windows.Input;
using TumeKaust.Models;

namespace TumeKaust.ViewModels
{
    public class SportlasedViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }
        public ICommand OpenPersonCommand { get; set; }

        public SportlasedViewModel()
        {
            Persons = new ObservableCollection<Person>
            {
                new Person 
                { 
                    Name = "Andrus Veerpalu", 
                    Description = "Eesti murdmaasuusataja, kahekordne olümpiavõitja ja maailmameister. Üks Eesti kõige edukamaid talispordisportlasi.",
                    ImagePath = "veerpalu.png",
                    Category = "Sportlased"
                },
                new Person 
                { 
                    Name = "Kristina Šmigun-Vähi", 
                    Description = "Eesti murdmaasuusataja, kahekordne olümpiavõitja ja maailmameister. Andrus Veerpalu õde ja üks Eesti kõige edukamaid naissportlasi.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Sportlased"
                },
                new Person 
                { 
                    Name = "Gerd Kanter", 
                    Description = "Eesti kettaheitja, olümpiavõitja ja maailmameister. Üks maailma parimaid kettaheitjaid aastatel 2005-2015.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Sportlased"
                },
                new Person 
                { 
                    Name = "Ott Tänak", 
                    Description = "Eesti rallisõitja, 2019. aasta autoralli maailmameister (WRC). Esimene eestlane, kes on selle tiitli võitnud.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Sportlased"
                },
                new Person 
                { 
                    Name = "Jüri Vips", 
                    Description = "Eesti autosportlane, kes on võistelnud vormelisarjades, sealhulgas Formula 2-s ja Red Bulli noorteprogrammis.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Sportlased"
                },
                new Person 
                { 
                    Name = "Marko Asmer", 
                    Description = "Eesti autosportlane, kes on võistelnud Formula 1-s ja teistes kõrgetasemelistes autosportide sarjades.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Sportlased"
                }
            };

            OpenPersonCommand = new Command<Person>(OnPersonSelected);
        }

        private async void OnPersonSelected(Person person)
        {
            await Application.Current.MainPage.DisplayAlert("Valitud sportlane", person.Name, "OK");
            // TODO: Navigate to PersonDetails page
        }
    }
}

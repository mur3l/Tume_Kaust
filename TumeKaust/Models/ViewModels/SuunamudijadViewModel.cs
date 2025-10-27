using System.Collections.ObjectModel;
using System.Windows.Input;
using TumeKaust.Models;

namespace TumeKaust.ViewModels
{
    public class SuunamudijadViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }
        public ICommand OpenPersonCommand { get; set; }

        public SuunamudijadViewModel()
        {
            Persons = new ObservableCollection<Person>
            {
                new Person 
                { 
                    Name = "Brigitte Susanna Hunt", 
                    Description = "Eesti meediategelane, laulja ja saatejuht. Tuntud peamiselt oma tegevuse kaudu telesaadetes ja sotsiaalmeedias.",
                    ImagePath = "hunt.jpg",
                    Category = "Suunamudijad"
                },
                new Person 
                { 
                    Name = "Mariann Treimann (Mallukas)", 
                    Description = "Eesti ettevõtja, moelooja ja sotsiaalmeediategelane. Tuntud oma stiiliga ja moeveebisaitidega.",
                    ImagePath = "mallukas.png",
                    Category = "Suunamudijad"
                },
                new Person 
                { 
                    Name = "Kristina Pärtelpoeg", 
                    Description = "Eesti näitleja ja sisulooja. Tuntud rollide poolest nii teatrilaval kui ka teleseriaalides.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Suunamudijad"
                },
                new Person 
                { 
                    Name = "Ott Tänak", 
                    Description = "Eesti rallisõitja, 2019. aasta autoralli maailmameister (WRC). Esimene eestlane, kes on selle tiitli võitnud.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Suunamudijad"
                },
                new Person 
                { 
                    Name = "Jüri Vips", 
                    Description = "Eesti autosportlane, kes on võistelnud vormelisarjades, sealhulgas Formula 2-s ja Red Bulli noorteprogrammis.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Suunamudijad"
                }
            };

            OpenPersonCommand = new Command<Person>(OnPersonSelected);
        }

        private async void OnPersonSelected(Person person)
        {
            await Application.Current.MainPage.DisplayAlert("Valitud isik", person.Name, "OK");
            // TODO: Navigate to PersonDetails page
        }
    }
}

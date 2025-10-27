using System.Collections.ObjectModel;
using System.ComponentModel;
using TumeKaust.Models;

namespace TumeKaust.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MainPageCategoryGrid> Categories { get; } = new();
        public ObservableCollection<PersonalDetailsGrid> RecentPeople { get; } = new();


        public MainPageViewModel()
        {
            LoadCategories();
            LoadRecentPeople();
        }

        private void LoadCategories()
        {
            // Näidisandmed (hiljem saad siia oma andmebaasi päringu)
            Categories.Add(new MainPageCategoryGrid { Name = "Presidendid", Image = "meri1.png" });
            Categories.Add(new MainPageCategoryGrid { Name = "Poliitikud", Image = "poliitikud.jpg" });
            Categories.Add(new MainPageCategoryGrid { Name = "Suunamudijad", Image = "suunamudijad.webp" });
            Categories.Add(new MainPageCategoryGrid { Name = "Sportlased", Image = "sportlased.png" });
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void LoadRecentPeople()
        {
            var allPeople = new List<PersonalDetailsGrid>
        {
            new() { PersonalDetailsId = 1, Name = "Andrus Veerpalu", Image = "sportlased.png", UpdatedAt = DateTime.Now.AddHours(-1) },
            new() { PersonalDetailsId = 2, Name = "Lennart Meri", Image = "meri1.png", UpdatedAt = DateTime.Now.AddHours(-2) },
            new() { PersonalDetailsId = 3, Name = "Rain Epler", Image = "poliitikud.jpg", UpdatedAt = DateTime.Now.AddHours(-3) },
            new() { PersonalDetailsId = 4, Name = "Mingi triin ja justin vist olid", Image = "suunamudijad.webp", UpdatedAt = DateTime.Now.AddHours(-4) }
        };

            // Sorteeri hiljuti uuendatud järgi ja võta kolm esimest
            foreach (var person in allPeople.OrderByDescending(p => p.UpdatedAt).Take(2))
            {
                RecentPeople.Add(person);
            }
        }

    }
}

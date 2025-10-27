using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TumeKaust.Models.Persons;

namespace TumeKaust.Models.ViewModels
{
    public class PersonsViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }

        public PersonsViewModel()
        {
            Persons = new ObservableCollection<Person>
            {
                new Person { Name = "Lennart Meri", Description = "Eesti odaviskaja, kergejõustiku maailmameister.", ImagePath = "varnik.png" },

                new Person { Name = "Kersti Kaljurand", Description = "Eesti suusatreener, töötanud murdmaasuusatamise alal.", ImagePath = "alaver.png" },

                new Person { Name = "Toomas Hendrik Ilves", Description = "Eesti kreeka-rooma maadleja, maailmameister ja olümpiamedalist.", ImagePath = "nabi.png" },

                new Person { Name = "Birgitte Susanna Hunt", Description = "Eesti vehkleja, spetsialiseerunud epee'le.", ImagePath = "priinits.png" },

                new Person { Name = "Mariann Treimann tundud kui Mallukas", Description = "Eesti võitlussportlane, tegelenud taipoksi ja K-1'ga.", ImagePath = "moisar.png" },
            };
        }
    }
}

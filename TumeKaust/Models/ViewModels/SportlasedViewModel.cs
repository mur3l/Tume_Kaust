using System.Collections.ObjectModel;
using TumeKaust.Models;
using TumeKaust.Services;

namespace TumeKaust.ViewModels
{
    public class SportlasedViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }

        public SportlasedViewModel()
        {
            Persons = new ObservableCollection<Person>(PersonsServices.GetSportlased());
        }
    }
}

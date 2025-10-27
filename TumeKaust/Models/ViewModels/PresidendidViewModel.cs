using System.Collections.ObjectModel;
using TumeKaust.Models;
using TumeKaust.Services;

namespace TumeKaust.ViewModels
{
    public class PresidendidViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }

        public PresidendidViewModel()
        {
            Persons = new ObservableCollection<Person>(PersonsServices.GetPresidendid());
        }
    }
}

using System.Collections.ObjectModel;
using TumeKaust.Models;
using TumeKaust.Services;

namespace TumeKaust.ViewModels
{
    public class SuunamudijadViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }

        public SuunamudijadViewModel()
        {
            Persons = new ObservableCollection<Person>(PersonsServices.GetSuunamudijad());
        }
    }
}

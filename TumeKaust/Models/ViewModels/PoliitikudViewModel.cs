using System.Collections.ObjectModel;
using TumeKaust.Models;
using TumeKaust.Services;

namespace TumeKaust.ViewModels
{
    public class PoliitikudViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }

        public PoliitikudViewModel()
        {
            Persons = new ObservableCollection<Person>(PersonsServices.GetPoliitikud());
        }
    }
}

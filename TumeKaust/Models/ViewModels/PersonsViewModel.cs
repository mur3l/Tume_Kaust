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
                new Person { Name = "Lennart Meri", Description = "Kirjeldus", ImagePath = "meri1.png" }
            };
        }
    }
}

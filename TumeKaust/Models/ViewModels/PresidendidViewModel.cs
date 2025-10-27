using System.Collections.ObjectModel;
using TumeKaust.Models;

namespace TumeKaust.ViewModels
{
    public class PresidendidViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }

        public PresidendidViewModel()
        {
            Persons = new ObservableCollection<Person>
            {
                new Person 
                { 
                    Name = "Lennart Meri", 
                    Description = "Eesti kirjanik, filmitegija, diplomaat ja poliitik, kes oli Eesti Vabariigi president aastatel 1992–2001.",
                    ImagePath = "meri1.png",
                    Category = "Presidendid"
                },
                new Person 
                { 
                    Name = "Kersti Kaljulaid", 
                    Description = "Eesti poliitik ja majandusteadlane, kes oli Eesti Vabariigi president aastatel 2016–2021.",
                    ImagePath = "kaljulaid.png",
                    Category = "Presidendid"
                },
                new Person 
                { 
                    Name = "Toomas Hendrik Ilves", 
                    Description = "Eesti poliitik ja diplomaat, kes oli president aastatel 2006–2016.",
                    ImagePath = "ilves.png",
                    Category = "Presidendid"
                },
                new Person 
                { 
                    Name = "Arnold Rüütel", 
                    Description = "Eesti põllumajandusteadlane ja poliitik, kes oli Eesti Vabariigi president aastatel 2001–2006.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Presidendid"
                },
                new Person 
                { 
                    Name = "Alar Karis", 
                    Description = "Eesti bioloog ja poliitik, kes on Eesti Vabariigi president alates 2021. aastast.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Presidendid"
                }
            };
        }
    }
}

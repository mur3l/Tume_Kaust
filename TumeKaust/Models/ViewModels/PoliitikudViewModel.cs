using System.Collections.ObjectModel;
using TumeKaust.Models;

namespace TumeKaust.ViewModels
{
    public class PoliitikudViewModel
    {
        public ObservableCollection<Person> Persons { get; set; }

        public PoliitikudViewModel()
        {
            Persons = new ObservableCollection<Person>
            {
                new Person 
                { 
                    Name = "Kaja Kallas", 
                    Description = "Eesti poliitik ja jurist, Eesti Reformierakonna esimees ja Eesti Vabariigi peaminister alates 2021. aastast.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Poliitikud"
                },
                new Person 
                { 
                    Name = "Jüri Ratas", 
                    Description = "Eesti poliitik, Eesti Keskerakonna esimees ja Eesti Vabariigi peaminister aastatel 2016–2021.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Poliitikud"
                },
                new Person 
                { 
                    Name = "Taavi Rõivas", 
                    Description = "Eesti poliitik, Eesti Reformierakonna liige ja Eesti Vabariigi peaminister aastatel 2014–2016.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Poliitikud"
                },
                new Person 
                { 
                    Name = "Andrus Ansip", 
                    Description = "Eesti poliitik ja ärimees, Eesti Reformierakonna esimees ja Eesti Vabariigi peaminister aastatel 2005–2014.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Poliitikud"
                },
                new Person 
                { 
                    Name = "Edgar Savisaar", 
                    Description = "Eesti poliitik ja matemaatik, Eesti Keskerakonna asutaja ja esimees, Tallinna linnapea aastatel 2001–2004 ja 2007–2015.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Poliitikud"
                },
                new Person 
                { 
                    Name = "Mart Laar", 
                    Description = "Eesti ajaloolane ja poliitik, Eesti Isamaaliidu esimees ja Eesti Vabariigi peaminister aastatel 1992–1994 ja 1999–2002.",
                    ImagePath = "dotnet_bot.png",
                    Category = "Poliitikud"
                }
            };
        }
    }
}

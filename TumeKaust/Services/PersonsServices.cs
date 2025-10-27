using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TumeKaust.Models;

namespace TumeKaust.Services
{
    public static class PersonsServices
    {
        private static List<Person> GetPersons()
        { 
          return new List<Person>
          {
              new Person
              { 
                ImagePath = "meri1.png",
                Name = "Lennart Meri",
                Description = "Eesti kirjanik, filmitegija, diplomaat ja poliitik, kes oli Eesti Vabariigi president aastatel 1992–2001.",
                Category = "Presidendid"
              },

              new Person
              { 
                ImagePath = "kaljulaid.png",
                Name = "Kersti Kaljulaid",
                Description = "Eesti poliitik ja majandusteadlane, kes oli Eesti Vabariigi president aastatel 2016–2021.",
                Category = "Presidendid"
              },

              new Person
              { 
                ImagePath = "ilves.png",
                Name = "Toomas Hendrik Ilves",
                Description = "Eesti poliitik ja diplomaat, kes oli president aastatel 2006–2016.",
                Category = "Presidendid"
              },

              new Person
              { 
                ImagePath = "hunt.jpg",
                Name = "Brigitte Susanna Hunt",
                Description = "Eesti meediategelane, laulja ja saatejuht. Tuntud peamiselt oma tegevuse kaudu telesaadetes ja sotsiaalmeedias.",
                Category = "Suunamudijad"
              },

              new Person
              { 
                ImagePath = "mallukas.png",
                Name = "Mariann Treimann",
                Description = "Eesti ettevõtja, moelooja ja sotsiaalmeediategelane.",
                Category = "Suunamudijad"
              },

              new Person
              { 
                ImagePath = "",
                Name = "Kristina Pärtelpoeg",
                Description = "Eesti näitleja ja sisulooja. Tuntud rollide poolest nii teatrilaval kui ka teleseriaalides. Lisaks tegutseb ta sisuloojana sotsiaalmeedias.",
                Category = "Suunamudijad"
              },

              new Person
              {
                ImagePath = "",
                Name = "Ott Tänak",
                Description = "Eesti rallisõitja, 2019. aasta autoralli maailmameister (WRC). Esimene eestlane, kes on selle tiitli võitnud.",
                Category = "Sportlased"
              },

              new Person
              {
                ImagePath = "",
                Name = "Jüri Vips",
                Description = "Eesti autosportlane, kes on võistelnud vormelisarjades, sealhulgas Formula 2-s ja Red Bulli noorteprogrammis.",
                Category = "Sportlased"
              },

              new Person
              {
                ImagePath = "",
                Name = "Andrus Värnik",
                Description = "Eesti näitleja ja sisulooja. Tuntud rollide poolest nii teatrilaval kui ka teleseriaalides. Lisaks tegutseb ta sisuloojana sotsiaalmeedias.",
                Category = "Sportlased"
              },

              new Person
              {
                ImagePath = "",
                Name = "Jüri Ratas",
                Description = "Eesti näitleja ja sisulooja. Tuntud rollide poolest nii teatrilaval kui ka teleseriaalides. Lisaks tegutseb ta sisuloojana sotsiaalmeedias.",
                Category = "Poliitikud"
              },

              new Person
              {
                ImagePath = "",
                Name = "Taavi Rõivas",
                Description = "Eesti näitleja ja sisulooja. Tuntud rollide poolest nii teatrilaval kui ka teleseriaalides. Lisaks tegutseb ta sisuloojana sotsiaalmeedias.",
                Category = "Poliitikud"
              },

              new Person
              {
                ImagePath = "",
                Name = "Kaja Kallas",
                Description = "Eesti näitleja ja sisulooja. Tuntud rollide poolest nii teatrilaval kui ka teleseriaalides. Lisaks tegutseb ta sisuloojana sotsiaalmeedias.",
                Category = "Poliitikud"
              },

          };
        }
    }
}

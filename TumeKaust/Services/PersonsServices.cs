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
        public static List<Person> GetPersons()
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
                ImagePath = "partelpoeg.png",
                Name = "Kristina Pärtelpoeg",
                Description = "Eesti näitleja ja sisulooja. Tuntud rollide poolest nii teatrilaval kui ka teleseriaalides. Lisaks tegutseb ta sisuloojana sotsiaalmeedias.",
                Category = "Suunamudijad"
              },

              new Person
              {
                ImagePath = "tanak.png",
                Name = "Ott Tänak",
                Description = "Eesti rallisõitja, 2019. aasta autoralli maailmameister (WRC). Esimene eestlane, kes on selle tiitli võitnud.",
                Category = "Sportlased"
              },

              new Person
              {
                ImagePath = "vips.png",
                Name = "Jüri Vips",
                Description = "Eesti autosportlane, kes on võistelnud vormelisarjades, sealhulgas Formula 2-s ja Red Bulli noorteprogrammis.",
                Category = "Sportlased"
              },

              new Person
              {
                ImagePath = "varnik.png",
                Name = "Andrus Värnik",
                Description = "Eesti endine kergejõustiklane, odaviskaja. 2005. aasta maailmameister ja 2003. aasta maailmameistrivõistluste hõbemedalist.",
                Category = "Sportlased"
              },

              new Person
              {
                ImagePath = "ratas.png",
                Name = "Jüri Ratas",
                Description = "Eesti poliitik, Keskerakonna liige ja peaminister aastatel 2016–2021.",
                Category = "Poliitikud"
              },

              new Person
              {
                ImagePath = "roivas.png",
                Name = "Taavi Rõivas",
                Description = "Eesti poliitik, Reformierakonna liige ja peaminister aastatel 2014–2016.",
                Category = "Poliitikud"
              },

              new Person
              {
                ImagePath = "kallas.png",
                Name = "Kaja Kallas",
                Description = "Eesti poliitik, Reformierakonna esimees ja alates 2021. aastast Eesti Vabariigi peaminister.",
                Category = "Poliitikud"
              },

          };
        }

        public static List<Person> GetPersonsByCategory(string category)
        {
            return GetPersons().Where(p => p.Category == category).ToList();
        }

        public static List<Person> GetPresidendid()
        {
            return GetPersonsByCategory("Presidendid");
        }

        public static List<Person> GetPoliitikud()
        {
            return GetPersonsByCategory("Poliitikud");
        }

        public static List<Person> GetSuunamudijad()
        {
            return GetPersonsByCategory("Suunamudijad");
        }

        public static List<Person> GetSportlased()
        {
            return GetPersonsByCategory("Sportlased");
        }
    }
}

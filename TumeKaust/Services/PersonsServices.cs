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
                ImagePath = "Alaver.png",
                Name = "Mati Alaver",
                Description = "Endine suusatreener, mõisteti 2019 süüdi dopingu kallutamises (Seefeldi juhtum).",
                Category = "Suusatamine"
              },

              new Person
              { 
                ImagePath = "Veerpalu.png",
                Name = "Andreas Veerpalu",
                Description = "Seotud Seefeldi 2019 dopingujuhtumiga, määrati FISi keeld veredopingu eest.",
                Category = "Suustatamine"
              },

              new Person
              { 
                ImagePath = "Nabi.png",
                Name = "Heiki Nabi",
                Description = "Kahekordne maailmameister, 2021 dopinguproov letrosooliga – 2-aastane keeld.",
                Category = "Maadlus"
              },

              new Person
              { 
                ImagePath = "Priinits.png",
                Name = "Sten Priinits",
                Description = "Vehkleja, 2024 sai EADSE-lt 18-kuulise keelu asukohaandmete rikkumise eest.",
                Category = "Vehklemine"
              },

              new Person
              { 
                ImagePath = "Varnik.png",
                Name = "Andrus Värnik",
                Description = "2005 MM-kuld odaviskes; 2014 süüdi kehalises väärkohtlemises ja saadeti ravile.",
                Category = "Odaviskaja"
              },

          };
        }
    }
}

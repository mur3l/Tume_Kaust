using TumeKaust.Models;

namespace TumeKaust.Services
{
    public static class PersonService
    {
        private static List<Person> people = new()
        {
                new Person
                {
                    Name = "Lennart Meri",
                    Subtitle = "Eesti riigitegelane ja kirjanik",
                    HeroImage = "meri1.png",
                    Description = "Lennart Meri oli Eesti riigitegelane, diplomaat ja kirjanik. Tema elulugu sisaldab olulisi peatükke Eesti ajaloos.",
                    News = new() { "Uudis 1: Lennart Meri meenutuspäev", "Uudis 2: Tema kõned kogumikus", "Uudis 3: Dokumentaal ETV-s" },
                    AccentColorStart = Color.FromArgb("#353535"),
                    AccentColorEnd = Color.FromArgb("#8d9098")
                },

                            new Person
                {
                    Name = "Ene Ergma",
                    Subtitle = "Teadlane ja poliitik",
                    HeroImage = "eneergma.png",
                    Description = "Ene Ergma on astrofüüsik ja poliitik, kes on olnud Riigikogu esimees ja teaduse eestkõneleja.",
                    News = new() { "Uudis 2: Ergma uues teadusnõukogus", "Uudis 2: Esines Tartu Ülikoolis" },
                    AccentColorStart = Color.FromArgb("#6a329f"),
                    AccentColorEnd = Color.FromArgb("#ffd710")
                }
            };

        public static List<Person> GetAllPeople() => people;

        public static Person GetPersonByName(string name)
                => people.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    }
}

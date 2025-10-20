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
                    Subtitle = "Vabariigi President\r\n06.10.1992-08.10.2001",
                    HeroImage = "meri1.png",
                    Description = "Lennart Meri sündis 29. märtsil 1929 Tallinnas Eesti diplomaadi ja hilisema Shakespeare'i tõlkija Georg Meri perekonnas. " +
                    "Koos perekonnaga lahkus ta varakult Eestist ning pidi" +
                    "üheksa korda kooli ning neli korda keelt vahetama. " +
                    "Kõige soojemalt meenutas ta oma õpinguid Lycée Janson de Sailly's Pariisis..",
                    News = new() { "Uudis 1: https://www.ohtuleht.ee/melu/1088458/suur-draama-ajajoon-brigitte-susanne-hunt-versus-koik-teised-vaata-kuidas-rullus-avalikkuse-silme-ees-lahti-selle-suve-skandaalseim-tuli",
                                   "Uudis 2: https://kroonika.delfi.ee/artikkel/120407077/video-lase-tulla-brigitte-pogenes-kohtuistungi-jarel-ajakirjanike-eest-kuid-saatis-sonumi-mallukale" ,
                                   "Uudis 3: https://elu24.postimees.ee/8334256/brigitte-susanne-hunt-vabandab-oma-kaitumise-parast-kohtusaalis-ilmselgelt-olin-uliemotsionaalne-ja-ebaprofessionaalne", }

                },

                new Person
                {
                    Name = "Kersti Kaljurand",
                    Subtitle = "Vabariigi President\r\n10.10.2016-11.10.2021",
                    HeroImage = "meri1.png",
                    Description = "Ta omandas hariduse Tartu Ülikoolis: 1992. aastal lõpetas loodusteaduskonna geneetika erialal ning 2001. aastal " +
                    "majandusteaduskonna magistrantuuri.\r\n\r\nAastatel 1994–1999 töötas ta erinevates Eesti ettevõtetes: algul telefonikeskjaamade " +
                    "müügijuhina Eesti Telefonis, hiljem Hoiupank Marketsis ja Hansapank Marketsis.",
                    News = new() { "Uudis 1: https://www.ohtuleht.ee/melu/1088458/suur-draama-ajajoon-brigitte-susanne-hunt-versus-koik-teised-vaata-kuidas-rullus-avalikkuse-silme-ees-lahti-selle-suve-skandaalseim-tuli",
                                   "Uudis 2: https://kroonika.delfi.ee/artikkel/120407077/video-lase-tulla-brigitte-pogenes-kohtuistungi-jarel-ajakirjanike-eest-kuid-saatis-sonumi-mallukale" ,
                                   "Uudis 3: https://elu24.postimees.ee/8334256/brigitte-susanne-hunt-vabandab-oma-kaitumise-parast-kohtusaalis-ilmselgelt-olin-uliemotsionaalne-ja-ebaprofessionaalne", }

                },

                new Person
                {
                    Name = "Toomas Hendrik Ilves",
                    Subtitle = "Vabariigi President\r\n09.10.2006-10.10.2016",
                    HeroImage = "meri1.png",
                    Description = "President Toomas Hendrik Ilves on sündinud 26. detsembril 1953. aastal Rootsi pealinnas Stockholmis," +
                    " ta on pikemat aega elanud ja töötanud viies riigis.\r\n\r\nLapsepõlvekodust pärit eesti väärtushinnangud, " +
                    "USA ühe tippülikooli haridus, Eesti oleviku ja tulevikuga seotud töökohad viimase veerandsajandi vältel on kujundanud " +
                    "Toomas Hendrik Ilvest kui inimest ja 21. sajandi Euroopa väikeriigi presidenti.",

                    News = new() { "Uudis 1: https://elu24.postimees.ee/8314126/ieva-ilves-toomas-hendrik-ilvese-uuest-kaaslasest-teda-oli-naha-juba-meie-abielu-ajal",
                                   "Uudis 2: https://kroonika.delfi.ee/artikkel/120407077/video-lase-tulla-brigitte-pogenes-kohtuistungi-jarel-ajakirjanike-eest-kuid-saatis-sonumi-mallukale" ,
                                   "Uudis 3: https://elu24.postimees.ee/8334256/brigitte-susanne-hunt-vabandab-oma-kaitumise-parast-kohtusaalis-ilmselgelt-olin-uliemotsionaalne-ja-ebaprofessionaalne", }

                },

                new Person
                {
                    Name = "Brigitte Susanna Hunt",
                    Subtitle = "Ajakirjanik",
                    HeroImage = "hunt.jpg",
                    Description = "Brigitte Susanne Hunt on õppinud Audentese Erakoolis ja lõpetanud 2014. aastal Tallinna 21. Kooli." +
                    "2017. aastal lõpetas Tartu Ülikooli ajakirjanduse ja kommunikatsiooni erialal",
                    News = new() { "Uudis 1: https://www.ohtuleht.ee/melu/1088458/suur-draama-ajajoon-brigitte-susanne-hunt-versus-koik-teised-vaata-kuidas-rullus-avalikkuse-silme-ees-lahti-selle-suve-skandaalseim-tuli",
                                   "Uudis 2: https://kroonika.delfi.ee/artikkel/120407077/video-lase-tulla-brigitte-pogenes-kohtuistungi-jarel-ajakirjanike-eest-kuid-saatis-sonumi-mallukale" ,
                                   "Uudis 3: https://elu24.postimees.ee/8334256/brigitte-susanne-hunt-vabandab-oma-kaitumise-parast-kohtusaalis-ilmselgelt-olin-uliemotsionaalne-ja-ebaprofessionaalne", }

                },

                new Person
                {
                    Name = "Brigitte Susanna Hunt",
                    Subtitle = "Ajakirjanik",
                    HeroImage = "hunt.jpg",
                    Description = "Brigitte Susanne Hunt on õppinud Audentese Erakoolis ja lõpetanud 2014. aastal Tallinna 21. Kooli." +
                    "2017. aastal lõpetas Tartu Ülikooli ajakirjanduse ja kommunikatsiooni erialal",
                    News = new() { "Uudis 1: https://www.ohtuleht.ee/melu/1088458/suur-draama-ajajoon-brigitte-susanne-hunt-versus-koik-teised-vaata-kuidas-rullus-avalikkuse-silme-ees-lahti-selle-suve-skandaalseim-tuli",
                                   "Uudis 2: https://kroonika.delfi.ee/artikkel/120407077/video-lase-tulla-brigitte-pogenes-kohtuistungi-jarel-ajakirjanike-eest-kuid-saatis-sonumi-mallukale" ,
                                   "Uudis 3: https://elu24.postimees.ee/8334256/brigitte-susanne-hunt-vabandab-oma-kaitumise-parast-kohtusaalis-ilmselgelt-olin-uliemotsionaalne-ja-ebaprofessionaalne", }

                },

                new Person
                {
                    Name = "Mariann Treimann tuntud kui Mallukas",
                    Subtitle = "Blogija",
                    HeroImage = "hunt.jpg",
                    Description = "Brigitte Susanne Hunt on õppinud Audentese Erakoolis ja lõpetanud 2014. aastal Tallinna 21. Kooli." +
                    "2017. aastal lõpetas Tartu Ülikooli ajakirjanduse ja kommunikatsiooni erialal",
                    News = new() { "Uudis 1: https://mallukas.eu/",
                                   "Uudis 2: https://www.tv3.ee/3-portaal/seltskond/draama-ajajoon-skandaalne-vestlusohtu-ja-tulitsevad-naised-ehk-mis-laks-valesti/" ,
                                   "Uudis 3: https://kroonika.delfi.ee/artikkel/120386790/kogu-see-draama-on-naide-sellest-miks-mulle-meelis-voiks-mitte-meeldida-mallukas-avaldas-miks-ta-tuntud-blogijat-oma-pulma-ei-tahtnud", }

                },

                new Person
                {
                    Name = "Kristina Pärtelpoeg",
                    Subtitle = "Blogija",
                    HeroImage = "kristina.jpg",
                    Description = "Brigitte Susanne Hunt on õppinud Audentese Erakoolis ja lõpetanud 2014. aastal Tallinna 21. Kooli." +
                    "2017. aastal lõpetas Tartu Ülikooli ajakirjanduse ja kommunikatsiooni erialal",
                    News = new() { "Uudis 1: https://kroonika.delfi.ee/artikkel/120329733/mida-temaga-siis-tehti-kristina-partelpoeg-paljastas-viimase-iluoperatsiooni-tagamaad",
                                   "Uudis 2: https://www.ohtuleht.ee/melu/957105/jalle-draama-kristina-partelpoeg-suudistab-blogiauhindade-jagamise-korraldusmeeskonda-enese-alandamises" ,
                                   "Uudis 3: https://kroonika.delfi.ee/artikkel/120304765/vestlusohtu-draama-kogub-uusi-tuure-kristina-partelpoeg-katrin-lustist-see-tuleb-tema-mingist-v-uvihast-lust-see-on-kiusamine", }

                },


                new Person
                {
                    Name = "Ott Tänak",
                    Subtitle = "Rallisõitja",
                    HeroImage = "ott.webp",
                    Description = "Ott Tänak (sündinud 15. oktoobril 1987 Kärla vallas Saaremaal) on Eesti " +
                    "rallisõitja. Ta on mitmekordne Eesti meister autorallis ning 2019. aasta autoralli" +
                    "maailmameister.",
                    News = new() { "Uudis 1: https://sport.err.ee/952895/video-punktikatsel-esikoha-kaotanud-tanak-oli-finisis-aarmiselt-loodud",
                                   "Uudis 2: https://ralli.ee/lobus-video-ott-tanak-pani-tsiili-rallil-kohaliku-staari-karjuma/" ,
                                   "Uudis 3: https://kroonika.delfi.ee/artikkel/120304765/vestlusohtu-draama-kogub-uusi-tuure-kristina-partelpoeg-katrin-lustist-see-tuleb-tema-mingist-v-uvihast-lust-see-on-kiusamine", }

                },


                new Person
                {
                    Name = "Jüri Vips",
                    Subtitle = "Rallisõitja",
                    HeroImage = "Juri.jpg",
                    Description = "Brigitte Susanne Hunt on õppinud Audentese Erakoolis ja lõpetanud 2014. aastal Tallinna 21. Kooli." +
                    "2017. aastal lõpetas Tartu Ülikooli ajakirjanduse ja kommunikatsiooni erialal",
                    News = new() { "Uudis 1: https://www.ohtuleht.ee/sport/1091341/juri-vips-labis-rassismiskandaali-jarel-kaks-kursust-tahtsin-aru-saada-mis-on-solvav-mis-mitte-",
                                   "Uudis 2: https://www.ohtuleht.ee/melu/957105/jalle-draama-kristina-partelpoeg-suudistab-blogiauhindade-jagamise-korraldusmeeskonda-enese-alandamises" ,
                                   "Uudis 3: https://kroonika.delfi.ee/artikkel/120304765/vestlusohtu-draama-kogub-uusi-tuure-kristina-partelpoeg-katrin-lustist-see-tuleb-tema-mingist-v-uvihast-lust-see-on-kiusamine", }

                },


                new Person
                {
                    Name = "Kristina Pärtelpoeg",
                    Subtitle = "Blogija",
                    HeroImage = "kristina.jpg",
                    Description = "Brigitte Susanne Hunt on õppinud Audentese Erakoolis ja lõpetanud 2014. aastal Tallinna 21. Kooli." +
                    "2017. aastal lõpetas Tartu Ülikooli ajakirjanduse ja kommunikatsiooni erialal",
                    News = new() { "Uudis 1: https://kroonika.delfi.ee/artikkel/120329733/mida-temaga-siis-tehti-kristina-partelpoeg-paljastas-viimase-iluoperatsiooni-tagamaad",
                                   "Uudis 2: https://www.ohtuleht.ee/melu/957105/jalle-draama-kristina-partelpoeg-suudistab-blogiauhindade-jagamise-korraldusmeeskonda-enese-alandamises" ,
                                   "Uudis 3: https://kroonika.delfi.ee/artikkel/120304765/vestlusohtu-draama-kogub-uusi-tuure-kristina-partelpoeg-katrin-lustist-see-tuleb-tema-mingist-v-uvihast-lust-see-on-kiusamine", }

                },

                new Person
                {
                    Name = "Ott Tänak",
                    Subtitle = "Rallisõitja",
                    HeroImage = "ott.webp",
                    Description = "Ott Tänak (sündinud 15. oktoobril 1987 Kärla vallas Saaremaal) on Eesti " +
                    "rallisõitja. Ta on mitmekordne Eesti meister autorallis ning 2019. aasta autoralli" +
                    "maailmameister.",
                    News = new() { "Uudis 1: https://sport.err.ee/952895/video-punktikatsel-esikoha-kaotanud-tanak-oli-finisis-aarmiselt-loodud",
                                   "Uudis 2: https://ralli.ee/lobus-video-ott-tanak-pani-tsiili-rallil-kohaliku-staari-karjuma/" ,
                                   "Uudis 3: https://kroonika.delfi.ee/artikkel/120304765/vestlusohtu-draama-kogub-uusi-tuure-kristina-partelpoeg-katrin-lustist-see-tuleb-tema-mingist-v-uvihast-lust-see-on-kiusamine", }

                },

                new Person
                {
                    Name = "Ott Tänak",
                    Subtitle = "Rallisõitja",
                    HeroImage = "ott.webp",
                    Description = "Ott Tänak (sündinud 15. oktoobril 1987 Kärla vallas Saaremaal) on Eesti " +
                    "rallisõitja. Ta on mitmekordne Eesti meister autorallis ning 2019. aasta autoralli" +
                    "maailmameister.",
                    News = new() { "Uudis 1: https://sport.err.ee/952895/video-punktikatsel-esikoha-kaotanud-tanak-oli-finisis-aarmiselt-loodud",
                                   "Uudis 2: https://ralli.ee/lobus-video-ott-tanak-pani-tsiili-rallil-kohaliku-staari-karjuma/" ,
                                   "Uudis 3: https://kroonika.delfi.ee/artikkel/120304765/vestlusohtu-draama-kogub-uusi-tuure-kristina-partelpoeg-katrin-lustist-see-tuleb-tema-mingist-v-uvihast-lust-see-on-kiusamine", }

                },



                new Person
                {
                    Name = "Ott Tänak",
                    Subtitle = "Rallisõitja",
                    HeroImage = "ott.webp",
                    Description = "Ott Tänak (sündinud 15. oktoobril 1987 Kärla vallas Saaremaal) on Eesti " +
                    "rallisõitja. Ta on mitmekordne Eesti meister autorallis ning 2019. aasta autoralli" +
                    "maailmameister.",
                    News = new() { "Uudis 1: https://sport.err.ee/952895/video-punktikatsel-esikoha-kaotanud-tanak-oli-finisis-aarmiselt-loodud",
                                   "Uudis 2: https://ralli.ee/lobus-video-ott-tanak-pani-tsiili-rallil-kohaliku-staari-karjuma/" ,
                                   "Uudis 3: https://kroonika.delfi.ee/artikkel/120304765/vestlusohtu-draama-kogub-uusi-tuure-kristina-partelpoeg-katrin-lustist-see-tuleb-tema-mingist-v-uvihast-lust-see-on-kiusamine", }

                },


        };
        // sportlased, presidendi, suunamudijad, poliitikud 
        public static List<Person> GetAllPeople() => people;

        public static Person GetPersonByName(string name)
                => people.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    }
}

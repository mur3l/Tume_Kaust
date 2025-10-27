using TumeKaust.Models;

namespace TumeKaust.Services
{
    public static class PersonService
    {
        private static List<Person> people = new()
        {
            // sportlased, presidendid, suunamudijad, poliitikud 
            // \r - rea algus
                new Person
                {
                    Name = "Lennart Meri",
                    Subtitle = "Vabariigi President\r\n06.10.1992-08.10.2001",
                    HeroImage = "meri1.png",
                    Description = "Lennart Meri sündis 29. märtsil 1929 Tallinnas Eesti diplomaadi ja hilisema Shakespeare'i tõlkija Georg Meri perekonnas. " +
                    "Koos perekonnaga lahkus ta varakult Eestist ning pidi " +
                    "üheksa korda kooli ning neli korda keelt vahetama. " ,
                        News = new() {
                            "Lennart Meri vanemad olid Eesti diplomaat, hilisem William Shakespeare'i tõlkija Georg Meri ning Alice-Brigitta Engmann, kellel olid eestirootsi juured." +
                            "\r\n\r\nIsa diplomaadiameti tõttu käis Lennart Meri mitmes Saksamaa ja Prantsusmaa koolis ja omandas hea keelteoskuse. Ta valdas saksa, prantsuse, inglise," +
                            " soome ja vene keelt. Pärast Eesti okupeerimist küüditati Georg Meri perekond 1941. aastal Kirovi oblastisse.",
                            "Lennart Meri haridustee ja keelteoskus...",
                            "Lennart Meri poliitiline karjäär..."
                        },
                        NewsLinks = new() { // lisan URL 
                            "https://et.wikipedia.org/wiki/Lennart_Meri",
                            "https://www.example.com/uudis2",
                            "https://www.example.com/uudis3"
                        }

                },

                new Person
                {
                    Name = "Kersti Kaljulaid",
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
                    Name = "Andrus Värnik",
                    Subtitle = "Odaviskaja",
                    HeroImage = "kristina.jpg",
                    Description = "Andrus Värnik (sündinud 27. septembril 1977 Antslas) on endine Eesti kergejõustiklane (odaviskaja), kes 2005. aastal tuli odaviskes maailmameistriks." +
                    "\r\n\r\nIsiklik rekord: 87.83 (19. august 2003 Valga, kuni 2018. aastani Eesti rekord)",
                    News = new() { "Uudis 1: https://www.delfi.ee/artikkel/70183955/delfi-fotod-ja-video-tingimisi-vangi-moistetud-andrus-varnik-tuli-napsisena-kohtusaali",
                                   "Uudis 2: https://www.ohtuleht.ee/melu/957105/jalle-draama-kristina-partelpoeg-suudistab-blogiauhindade-jagamise-korraldusmeeskonda-enese-alandamises" ,
                                   "Uudis 3: https://www.err.ee/525477/kohus-pikendas-varniku-katseaega-ja-kohustas-minema-alkoholismiravilee", }

                },

                new Person
                {
                    Name = "Jüri Ratas",
                    Subtitle = "Poliitik",
                    HeroImage = "Ratas.webp",
                    Description = "Jüri Ratas (sündinud 2. juulil 1978 Tallinnas) on Eesti poliitik. Ta on olnud 2021–2023 Riigikogu esimees ja 2016–2021 Eesti Vabariigi peaminister. " +
                    "2024. aastast on ta Euroopa Parlamendi liige. Kuuludes aastatel 2000–2024[1] Eesti Keskerakonda,[2] oli ta 2005. aasta novembrist kuni 5. aprillini 2007 Tallinna linnapea " +
                    "ja 2. aprillist 2007 kuni 23. novembrini 2016 Riigikogu aseesimees.",
                    News = new() { "Uudis 1: https://ekspress.delfi.ee/artikkel/92251051/juri-ratas-paastis-tagasi-astudes-oma-poliitikunahka",
                                   "Uudis 2: https://online.le.ee/2017/12/14/skandaal-linnamae-peekoni-umber-juri-ratas-ei-otsi-kadri-simsonile-asendajat/" ,
                                   "Uudis 3: https://uueduudised.ee/postimees-jarjekordne-skandaal-ratase-valitsuses-ei-jarjekordne-skandaal-ajakirjanduses/", }

                },

                new Person
                {
                    Name = "Taavi Rõivas",
                    Subtitle = "Poliitik",
                    HeroImage = "Taavi.jpg",
                    Description = "Taavi Rõivas (sündinud 26. septembril 1979) on Eesti poliitik, Eesti Reformierakonna esimees (2014–2017) ja " +
                    "Eesti peaminister (2014–2016).\r\n\r\nAastatel 2012–2014 oli Rõivas Eesti sotsiaalminister. 14. märtsil 2014 tegi president Ilves Taavi Rõivale ülesandeks " +
                    "moodustada valitsus ja sama aasta 26. märtsil kinnitas president Rõiva Eesti peaministriks. 7. novembril 2016 tegid koalitsioonipartnerid IRL " +
                    "ja Sotsiaaldemokraatlik Erakond Rõivale ettepaneku tagasi astuda.[1] 9. novembril 2016 tegi Riigikogu Taavi Rõivale umbusaldusavalduse " +
                    "(umbusaldamise poolt hääletas 63 Riigikogu liiget, vaja oli 51 häält).",
                    News = new() { "Uudis 1: https://uueduudised.ee/eesti-endine-reformierakondlasest-peaminister-ja-tema-piinlikud-skandaalid/",
                                   "Uudis 2: https://www.ohtuleht.ee/1015050/kulmkapp-murtud-ninaluu-ja-oravad-amaris-taavi-roivase-suuremad-ja-vaiksemad-skandaalid-poliitikas" ,
                                   "Uudis 3: https://elu24.postimees.ee/7860541/ekspeaminister-taavi-roivas-ja-bsh-vupsasid-koos-wc-kabiini-luisa-jai-kurva-naoga-korvalt-vaatama", }

                },



                new Person
                {
                    Name = "Kaja Kallas",
                    Subtitle = "Euroopa Liidu välisasjade ja julgeolekupoliitika kõrge esindaja\r\n",
                    HeroImage = "ott.webp",
                    Description = "Kaja Kallas (aastatel 2002–2006 Kaja Leiger; sündinud 18. juunil 1977 Tallinnas) " +
                    "on Eesti poliitik ja jurist, kes oli aastatel 2021–2024 Eesti peaminister ja 2018–2024 " +
                    "Eesti Reformierakonna esimees. Alates 1. detsembrist 2024 on ta Euroopa Liidu välisasjade " +
                    "ja julgeolekupoliitika kõrge esindaja ja Euroopa Komisjoni asepresident. " +
                    "Kallas on Eesti esimene naispeaminister.",
                    News = new() { "Uudis 1: https://minuaeg.com/skandaal-kaja-kallase-ja-ametnike-nimed-ilmusid-venemaa-tagaotsitavate-nimekirja/",
                                   "Uudis 2: https://www.delfi.ee/artikkel/120307812/ulevaade-kaja-kallas-on-hoolimata-skandaalidest-ja-ulatuslikest-kriisidest-jaanud-silma-tugeva-valispoliitilise-kailakujuna" ,
                                   "Uudis 3: https://objektiiv.ee/jaak-madison-kaja-kallas-on-valelik-silmakirjalik-ja-kahepalgeline/", }

                },


        };
        public static List<Person> GetAllPeople() => people;

        public static Person GetPersonByName(string name)
                => people.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    }
}

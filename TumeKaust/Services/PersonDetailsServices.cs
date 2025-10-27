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
                    DetailsKey = "LennartMeri", 
                    Description = "Lennart Meri sündis 29. märtsil 1929 Tallinnas Eesti diplomaadi ja hilisema Shakespeare'i tõlkija Georg Meri perekonnas. " +
                    "Koos perekonnaga lahkus ta varakult Eestist ning pidi " +
                    "üheksa korda kooli ning neli korda keelt vahetama. " ,
                    News = new() {
                            "Uudis 1: Hoolimata sellest, et Lennart Meri on surelik ja valelik nagu enamik inimesi, on ta suutnud jätta endast mulje kui kõiketeadvast diplomaatilisest paipoisist. Lennart Meri on vaja tagandada, sest ta on Eesti riigikaitse kõrgeima juhina vastutav kaitseväes toimuva eest. Riigimehelikult käituv president oleks otseselt vastutava kindral Kerdi lahkumisavalduse rahuldanud.",
                            "Uudis 2: Ammu on liikunud kuulujutud, et Lennart Meri oli abikaasana äkiline ja vägivaldne. Kolm aastat tagasi paluti neid kuulujutte ümber lükata Lennarti eksnaisel, Regina Merel. Tema seda teha ei soovinud, naine ütles, et las need kuulujutud levida edasi. " ,
<<<<<<< Updated upstream
                            "Uudis 3: Kersti Kaljulaid rikub Eesti põhiseaduse mõtet - president ei ole peaministri ülemus ",
=======
                            "Uudis 3: Seega ei ole vähimatki kahtlust: president Meri teeb kõik selleks, et võim säiliks valitseva kolmikliidu käes ükskõik missuguse hinnaga. Ja tal on selleks väga isiklikku laadi põhjused.\r\n",
>>>>>>> Stashed changes
                        },
                        NewsLinks = new() { // lisan URL 
                            "https://www.ohtuleht.ee/57717/valetav-meri-maarib-eesti-mainet",
                            "https://epl.delfi.ee/artikkel/68627041/lp-arhiivist-regina-meri-jah-ma-olin-meie-abielus-uksi",
<<<<<<< Updated upstream
                            "https://www.example.com/uudis3"
=======
                            "https://vana.kesknadal.ee/web/html/uudised2770.html"
>>>>>>> Stashed changes
                        }

                },

                new Person
                {
                    Name = "Kersti Kaljulaid",
                    Subtitle = "Vabariigi President\r\n10.10.2016-11.10.2021",
                    HeroImage = "meri1.png",
                    DetailsKey = "KerstiKaljulaid",
                    Description = "Ta omandas hariduse Tartu Ülikoolis: 1992. aastal lõpetas loodusteaduskonna geneetika erialal ning 2001. aastal " +
                    "majandusteaduskonna magistrantuuri.\r\n\r\nAastatel 1994–1999 töötas ta erinevates Eesti ettevõtetes: algul telefonikeskjaamade " +
                    "müügijuhina Eesti Telefonis, hiljem Hoiupank Marketsis ja Hansapank Marketsis.",
                    News = new() { "Uudis 1: President Kersti Kaljulaid ütles Urmas Reinsalu umbusaldamist ja sellega seonduvat kommenteerides, et Eesti vajab rohkem lugupidavat suhtumist ja erinevate arusaamade aktsepteerimist.",
                                   "Uudis 2: Kallas märkis, et ajakirjandus võiks eri juhtumeid käsitledes säilitada poliitikute suhtes samad standardid ning et võrreldes tema abikaasa Arvo Halliku osalusega Venemaal äri teinud ettevõttes sai Kaljulaidi osalemine Alexela nõukogus proportsionaalselt väga vähe tähelepanu, kirjutab ERR.\r\n\r\n„Lihtsalt kui on ühed moraalsed nõudmised ühele, siis võiksid olla ka teistele. Hea näide on, kuidas Kersti Kaljulaidi asja ja mind käsitletakse,“ pahandas Kallas" ,
                                   "Uudis 3: Kersti Kaljulaid rikub Eesti põhiseaduse mõtet - president ei ole peaministri ülemus ", 
                     NewsLinks = new() {
                            "https://www.postimees.ee/4384851/kaljulaid-ojasoo-ja-reinsalu-skandaalist-vajame-rohkem-lugupidavat-suhtumist",
                            "https://www.ohtuleht.ee/1093247/kaja-kallas-ajakirjanikele-miks-te-kersti-kaljulaidi-samamoodi-ei-runda-kui-mind",
                            "https://ekspress.delfi.ee/artikkel/87209069/kersti-kaljulaid-rikub-eesti-pohiseaduse-motet-president-ei-ole-peaministri-ulemus"
                },

                new Person
                {
                    Name = "Toomas Hendrik Ilves",
                    Subtitle = "Vabariigi President\r\n09.10.2006-10.10.2016",
                    HeroImage = "meri1.png",
                    DetailsKey = "ToomasHendrikIlves",
                    Description = "President Toomas Hendrik Ilves on sündinud 26. detsembril 1953. aastal Rootsi pealinnas Stockholmis," +
                    " ta on pikemat aega elanud ja töötanud viies riigis.\r\n\r\nLapsepõlvekodust pärit eesti väärtushinnangud, " +
                    "USA ühe tippülikooli haridus, Eesti oleviku ja tulevikuga seotud töökohad viimase veerandsajandi vältel on kujundanud " +
                    "Toomas Hendrik Ilvest kui inimest ja 21. sajandi Euroopa väikeriigi presidenti.",

                    News = new() { "Uudis 1: «Teda oli näha juba meie abielu ajal,» tõdes Ieva Ilves Kroonikale, et Toomas Hendriku kaaslasena nähtud naine ei ole talle võõras.\r\n\r\n​President Toomas Hendrik Ilves tekitas tänavusel roosiaia vastuvõtul elevust, saabudes üritusele uue, seni tundmatu saatjaga. Ajakirjanduse andmetel on tegemist USA päritolu arsti dr Alicia Skarimbasega, kellega Ilvest seob väidetavalt aastatepikkune tutvus.",
                                   "Uudis 2: President Ilves nimetas intervjuus Venemaa-vastaste sanktsioonide lõdvendamist pooldavaid Kreekat, Itaaliat, Ungarit ja Küprost Venemaa presidendi Vladimir Putini „kasulikeks idiootideks“ ning süüdistas neid Euroopa Liidu ühtsuse lõhkumises." ,
                                   "Uudis 3: Ekspresident Toomas Hendrik Ilves on oma endisele abikaasale Evelin Ilvesele võlgu 55 000 eurot, näitab ekspresidendi huvide deklaratsioon. Kohustuse aluseks on deklaratsioonis märgitud \"lahutusest tulenevalt\".", 
                     NewsLinks = new() {
                            "https://elu24.postimees.ee/8314126/ieva-ilves-toomas-hendrik-ilvese-uuest-kaaslasest-teda-oli-naha-juba-meie-abielu-ajal",
                            "https://www.aripaev.ee/uudised/2015/04/09/president-toomas-hendrik-ilvese-uus-skandaal",
                            "https://www.ohtuleht.ee/809891/toomas-hendrik-ilves-on-evelinile-lahutuse-eest-55-000-eurot-volgu"
                },

                new Person
                {
                    Name = "Brigitte Susanna Hunt",
                    Subtitle = "Ajakirjanik",
                    HeroImage = "hunt.jpg",
                    DetailsKey = "BrigitteSusannaHunt",
                    Description = "Brigitte Susanne Hunt on õppinud Audentese Erakoolis ja lõpetanud 2014. aastal Tallinna 21. Kooli." +
                    "2017. aastal lõpetas Tartu Ülikooli ajakirjanduse ja kommunikatsiooni erialal",
                    News = new() { "Uudis 1: Viimastel päevadel on avalikkuse silme all vallandunud tõeline draamalaviin. Suunamudijate Brigitte Susanne Hundi ja Kristina Pärtelpoja vahel lahvatanud tüli on võtnud säärased mõõtmed, et naelutanud suure osa eestlastest hämmeldunud pilgul jälgima kõikide asjaosaliste sotsiaalmeedia kontosid. Sopaloopimine on võtnud aja jooksul sellise hoo, et kohati keeruline mõista, kus on selle skandaali ots ja äär. Õhtuleht koondas selle suve suurima tüli tähtsaimad arengud ja detailid ühele ajajoonele!",
                                   "Uudis 2: Päev pärast kohtuistungit Mallu Mariann Treimanniga tegi Hunt ühismeediasse postituse, kus tunnistas, et oli kohtusaalis liialt emotsionaalne. «Peaksin olema kiuslik, südametu ja mehelikus energias värdjas, et mul oleks fänne. Ei, ma oleks pigem vaene ja üksi,» kirjutab ta.",
                                   "Uudis 3: Desiree eitas, nagu oleks tema ja Taavi vahel midagi juhtunud. „Lisan veel selle, et Luisa ja Taavi on mu ammused tuttavad ja olime siiski suht palju ka kolmekesi,“ avaldas ta oma sotsiaalmeedias, et nende seltskonnas oli inimesi palju rohkem.\r\n„Oli tore õhtu ja no päriselt minu ja Taavi vahel ei juhtunud mitte midagi sündsusetut. All good ja fun (kõik on hästi ja tore-toim).“",
                    },
                        NewsLinks = new() { 
                            "https://www.ohtuleht.ee/melu/1088458/suur-draama-ajajoon-brigitte-susanne-hunt-versus-koik-teised-vaata-kuidas-rullus-avalikkuse-silme-ees-lahti-selle-suve-skandaalseim-tuli",
                            "https://elu24.postimees.ee/8334256/brigitte-susanne-hunt-vabandab-oma-kaitumise-parast-kohtusaalis-ilmselgelt-olin-uliemotsionaalne-ja-ebaprofessionaalne",
                            "https://www.tv3.ee/3-portaal/seltskond/draama-ajajoon-skandaale-rohkem-kui-nadalapaevi-ehk-mis-toimub-brigitte-susanne-hundiga/"
                        }
                },

                new Person
                {
                    Name = "Mariann Treimann tuntud kui Mallukas",
                    Subtitle = "Blogija",
                    HeroImage = "hunt.jpg",
                    DetailsKey = "Mallukas",
<<<<<<< Updated upstream
                    Description = "Brigitte Susanne Hunt on õppinud Audentese Erakoolis ja lõpetanud 2014. aastal Tallinna 21. Kooli." +
                    "2017. aastal lõpetas Tartu Ülikooli ajakirjanduse ja kommunikatsiooni erialal",
=======
                    Description = "Mariann Treimann, enamikule tuntud kui Mallukas – Eesti loetuima blogi autor ning nüüd ka päris enda saate staar –, on oma elu, pere, tööde ja tegemistega seotud seiku blogiveergudel jaganud juba pikki aastaid. ",
>>>>>>> Stashed changes
                    News = new() { "Uudis 1: Naljakas, kuidas mõned asjad kaugelt vaadates naljakad tunduvad. No näiteks loen iga päev Katerina blogi ja ta päris tihti räägib seal enda tinderikogemustest. Ja see on ausalt öeldes päris naljakas lugemine. Samas ma saan aru, et tal ilmselt pole väga naljakas, sest tegelikult ",
                                   "Uudis 2: Vägevat \"Salajuttude\" suvelaagrit promoti nii: \"Naudime head ilma, mõnusat talu, kaunist loodust ja kui see osa tehtud saab, siis istume maha, naudime head sööki ja jooki. Muidugi astuvad lavale Mallu ja Kristina, kes jagavad teile mahlakaid Salajutte, kõige kuumemat goss'i ja naljakaid seiku enda elust.\" " ,
                                   "Uudis 3: Suurt skandaali kommenteeris ka Hunt ise oma sotsiaalmeedias. „Kui mul on kunagi mees onju, praegu mul ei ole aega selle jaoks, sest mul on ülikool. Samas kui mingi väga hea miisu tuleb, siis leian aega. Aga kui mul on mees ja kui kellelgi on võimalik teda minu käest võtta, siis võtke. Ma tahan, et mu mees tahab ise olla mulle truu ja kui talle natuke meeldib keegi teine, siis ma ei võta seda isiklikult,“ jutustas Brigitte."
                      },
                        NewsLinks = new() {
                            "https://mallukas.eu/",
                            "https://elu24.postimees.ee/8334256/brigitte-susanne-hunt-vabandab-oma-kaitumise-parast-kohtusaalis-ilmselgelt-olin-uliemotsionaalne-ja-ebaprofessionaalne",
                            "https://www.tv3.ee/3-portaal/seltskond/draama-ajajoon-skandaale-rohkem-kui-nadalapaevi-ehk-mis-toimub-brigitte-susanne-hundiga/"
                        }
                },

                new Person
                {
                    Name = "Kristina Pärtelpoeg",
                    Subtitle = "Blogija",
                    HeroImage = "kristina.jpg",
                    DetailsKey = "KrisinaPärtelpoeg",
<<<<<<< Updated upstream
                    Description = "Brigitte Susanne Hunt on õppinud Audentese Erakoolis ja lõpetanud 2014. aastal Tallinna 21. Kooli." +
                    "2017. aastal lõpetas Tartu Ülikooli ajakirjanduse ja kommunikatsiooni erialal",
=======
                    Description = "Kristina Suuroja-Pärtelpoeg (sündinud 2. märtsil 1994) on eesti suunamudija ja saatejuht.Ta oli 2021. aasta augustist kuni 2022. aasta detsembrini raadio MyHits hommikuprogrammi saatejuht",
>>>>>>> Stashed changes
                    News = new() { "Uudis 1: Tõsielusaate „Mida Mallukat! värskest osast selgub, et 30-aastane sisulooja käis kuu aega tagasi rasvaimus. Samal päeval sama tohtri noa all operatsioonil käinud Mallukas soovis aga oma niigi saledat pihta veelgi ilusamaks saada üleliigse naha eemaldusega. „Me oleme nüüd peenemad kui kunagi varem,“ teatas blogija kaamerate ees.",
                                   "Uudis 2: Seepeale kirjutas Pärtelpoeg ise korraldajatele, et nad tema blogi võistlusest eemaldaks. „Ütlesin, et ma ei taha, et mul on eelmise aastaga väike trauma. Ja siis ta ütles: „Nojah, sa ei saagi osaleda.“,“ ütleb Pärtelpoeg videos. „Ma reaalselt ei viitsi enam selliste inimestega suhelda, ma ei taha blogiauhindadega enam kunagi tegemist teha.“ " ,
                                   "Uudis 3: „Ta käitumine ei ole normaalne. Ja kui te näete kõiki neid pealkirju viimasel ajal – see tuleb tema mingist v**uvihast ja ma ei saa aru, mis ta probleem on,“ räägib raadiohääl ja suunamudija Kristina Pärtelpoeg Katrin Lustist Instagrami close friends’idele (lähedastele sõpradele) mõeldud videoklipikeses. „See on kiusamine!“ ütleb „Kuuuurija“ saatejuht Katrin Lust Kroonikale.\r\n\r\n„Eks ma siis uurin välja, keda ei saa usaldada,“ alustab Pärtelpoeg oma Instagrami close friends’idele mõeldud videoklipikeses, mis hakkas inimeste seas levima.",
                      },
                        NewsLinks = new() {
                            "https://kroonika.delfi.ee/artikkel/120329733/mida-temaga-siis-tehti-kristina-partelpoeg-paljastas-viimase-iluoperatsiooni-tagamaad",
                            "https://www.ohtuleht.ee/melu/957105/jalle-draama-kristina-partelpoeg-suudistab-blogiauhindade-jagamise-korraldusmeeskonda-enese-alandamises",
                            "https://kroonika.delfi.ee/artikkel/120304765/vestlusohtu-draama-kogub-uusi-tuure-kristina-partelpoeg-katrin-lustist-see-tuleb-tema-mingist-v-uvihast-lust-see-on-kiusamine"
                        }
                },


                new Person
                {
                    Name = "Ott Tänak",
                    Subtitle = "Rallisõitja",
                    HeroImage = "ott.webp",
                    DetailsKey = "OttTänak",
                    Description = "Ott Tänak (sündinud 15. oktoobril 1987 Kärla vallas Saaremaal) on Eesti " +
                    "rallisõitja. Ta on mitmekordne Eesti meister autorallis ning 2019. aasta autoralli" +
                    "maailmameister.",
                    News = new() { "Uudis 1: Sardiinias oma juubelirallil hiilgavat sõitu näidanud Ott Tänak langes punktikatsega esimeselt kohalt viiendaks. Eestlase masinalt kadus katse alguses roolivõim.\r\n\r\nEnne Tänakut finišisse jõudnud hispaanlane Dani Sordo ütles intervjuud alustades, et Tänak on katsel seisma jäänud ja peatselt kinnitas seda ka otsepilt. Eestlane keeras rooli paremale, auto aga vasakule teepiirdesse, ehk masinast kadus roolivõim.",
                                   "Uudis 2: Nagu juba traditsiooniks on saanud, võtavad rallisõitjad iga MM-etapi eel toimuva testikaste ühel läbimisel oma kõrvalistmele ka mõne tuntud inimese." ,
                                   "Uudis 3: Pärast Rally Estoniat määrasid kohtunikud Ott Tänakule kopsaka rahatrahvi. Nimelt eksis eestlane reeglite täitmisel ning lisaks esitas kohtunikele valesid väiteid.\r\n\r\nPärast Rally Estoniat selgus, et kohtunikud on määranud kolmanda koha teeninud Tänakule 1000 eurot trahvi. Lisaks sellele on teda trahvitud tingimisi 3000 euroga, ent see läheb täimisele, kui ta eksib taas samade reeglite vastu. Mis aga juhtus?", 
                    },
                        NewsLinks = new() {
                            "https://sport.err.ee/952895/video-punktikatsel-esikoha-kaotanud-tanak-oli-finisis-aarmiselt-loodud",
                            "https://ralli.ee/lobus-video-ott-tanak-pani-tsiili-rallil-kohaliku-staari-karjuma/",
                            "https://minuaeg.com/skandaal-ott-tanak-valetas-ja-saab-1000-eurot-trahvi/"
                        }
                },


                new Person
                {
<<<<<<< Updated upstream
                    Name = "Jüri Vips",
                    Subtitle = "Rallisõitja",
                    HeroImage = "Juri.jpg",
                    DetailsKey = "JüriVips",
                    Description = "Brigitte Susanne Hunt on õppinud Audentese Erakoolis ja lõpetanud 2014. aastal Tallinna 21. Kooli." +
                    "2017. aastal lõpetas Tartu Ülikooli ajakirjanduse ja kommunikatsiooni erialal",
                    News = new() { "Uudis 1: Möödunud suvel Red Bulli süsteemist rassistliku keelekasutuse tõttu vallandatud vormelisõitja Jüri Vips (23) avaldas, et on skandaali järel läbinud kaks kursust eesmärgiga tõsta oma teadlikkust sel teemal.",
                                   "Uudis 2:  ",
                                   "Uudis 3:  ",
                     NewsLinks = new() {
                            "https://www.ohtuleht.ee/sport/1091341/juri-vips-labis-rassismiskandaali-jarel-kaks-kursust-tahtsin-aru-saada-mis-on-solvav-mis-mitte-",
                            "",
                            ""
=======
                    Name = "Mirkko Moisar",
                    Subtitle = "Kikkpoksija",
                    HeroImage = "Mirkko.png",
                    DetailsKey = "MirkkoMoisar",
                    Description = "Brigitte Susanne Hunt on õppinud Audentese Erakoolis ja lõpetanud 2014. aastal Tallinna 21. Kooli." +
                    "2017. aastal lõpetas Tartu Ülikooli ajakirjanduse ja kommunikatsiooni erialal",
                    News = new() { "Uudis 1: Tuntud kikkpoksija Mirkko Moisar sai esmaspäeval Harju maakohtus vägivallatsemise ja võõra dokumendi rikkumise eest rahalise karistuse.",
                                   "Uudis 2: Mirkko Moisar jäi politseile vahele 26. juunil ja tema hingeõhus oli alkoholi 0,68 mg/l (1,56 promilli), vahendas Delfi. Moisar selgitas, et oli söögi kõrvale joonud ühe õlle. Oma tegu ta kahetses. ",
                                   "Uudis 3:  Harju maakohtu Tallinna kohtumajas arutati nädal aega tagasi Mirkko Moisari kaebust PPA Põhja prefektuuri Lääne-Harju politseijaoskonna menetlustalituse väärteootsuse kohta, millega sooviti temalt juhtimisõigust pooleks aastaks ära võtta.",
                     NewsLinks = new() {
                            "https://sport.postimees.ee/6896494/eesti-tipp-poksija-sai-vagivallatsemise-eest-rahalise-karistuse",
                            "https://www.ohtuleht.ee/1142132/purjuspai-autoroolis-kikkpoksija-mirkko-moisar-jai-viieks-kuuks-juhiloast-ilma",
                            "https://sport.delfi.ee/artikkel/120412029/mirkko-moisar-voeti-vahi-alla-valjapressimises-kahtlustatuna"
>>>>>>> Stashed changes

                },


                new Person
                {
                    Name = "Andrus Värnik",
                    Subtitle = "Odaviskaja",
<<<<<<< Updated upstream
                    HeroImage = "kristina.jpg",
=======
                    HeroImage = "andrusvarnik.jpg",
>>>>>>> Stashed changes
                    DetailsKey = "AndrusVärnik",
                    Description = "Andrus Värnik (sündinud 27. septembril 1977 Antslas) on endine Eesti kergejõustiklane (odaviskaja), kes 2005. aastal tuli odaviskes maailmameistriks." +
                    "\r\n\r\nIsiklik rekord: 87.83 (19. august 2003 Valga, kuni 2018. aastani Eesti rekord)",
                    News = new() { "Uudis 1: Harju maakohtus toimus täna istung tingimisi vangi mõistetud odaviske maailmameistri Andrus Värniku üle, kuna mees rikkus kohtu poolt määratud tingimusi.\r\n\r\nKuna Värnikul puudus kaitsja, siis otsustati tänasel istungil talle kaitsja määrata ja lükata tema asja arutamine edasi 25. novembrile. Maailmameister oli juba kohtusaalist välja sammumas, kui kohtunik tundis Värnikul järsku alkoholihaisu ja kutsus politsei, et joovet kontrollida.",
                                   "Uudis 2: Harju maakohus pikendas täna odaviske eksmaailmameistrile Andrus Värnikule mõistetud tingimisi vangistuse katseaega, kuna ta rikkus talle pandud kriminaalhooldusnõudeid, ühtlasi kohustas kohus teda minema alkoholismiravile.\r\n\r\nKohus pikendas Värniku katseaega ühe kuu võrra, mis lõppeb 2017. aasta 26. märtsil, ütles maakohtu pressiesindaja Kristina Ots ERR-i uudisteportaalile." ,
                                   "Uudis 3: Naise peksmise eest tingimisi vangistatud Andrus Värnikust on sündinud uus mees", 
                    NewsLinks = new() {
                            "https://www.delfi.ee/artikkel/70183955/delfi-fotod-ja-video-tingimisi-vangi-moistetud-andrus-varnik-tuli-napsisena-kohtusaali",
                            "https://www.err.ee/525477/kohus-pikendas-varniku-katseaega-ja-kohustas-minema-alkoholismiravile",
                            "https://elu24.postimees.ee/4256881/naise-peksmise-eest-tingimisi-vangistatud-andrus-varnikust-on-sundinud-uus-mees"
                    }
                },

                new Person
                {
                    Name = "Jüri Ratas",
                    Subtitle = "Poliitik",
                    HeroImage = "Ratas.webp",
                    DetailsKey = "JüriRatas",
                    Description = "Jüri Ratas (sündinud 2. juulil 1978 Tallinnas) on Eesti poliitik. Ta on olnud 2021–2023 Riigikogu esimees ja 2016–2021 Eesti Vabariigi peaminister. " +
                    "2024. aastast on ta Euroopa Parlamendi liige. Kuuludes aastatel 2000–2024[1] Eesti Keskerakonda,[2] oli ta 2005. aasta novembrist kuni 5. aprillini 2007 Tallinna linnapea " +
                    "ja 2. aprillist 2007 kuni 23. novembrini 2016 Riigikogu aseesimees.",
                    News = new() { "Uudis 1: Suur korruptsioon on Keskerakonna kirstunael. Esiteks, Jüri Ratase tuumväide on olnud, et tema Keskerakond on hoopis midagi muud, kui Savisaare oma. Ja et kõik jamad, mis erakonna rahastamisega ilmnevad, on karma, hoop selga minevikust.",
                                   "Uudis 2: Prokuratuur kahtlustab Simsoni eukaaslast, ettevõtte HKScan eksjuhti Teet Soormi omastamises ja rahapesus.\r\n\r\nPostimees kirjutas, et Linnamäe Peekoni juhid võisid pöörata poliitilise siseinfo rahaks, kui mullu sügisel võtsid jõudluskontrollis arvele 584 emist." ,
                                   "Uudis 3: Postimees kirjutab sellest, et peaminister Jüri Ratas olevat esmaspäeva hommikul kohtumisel EKRE poliitikutega nõudnud minister Marti Kuusiku kandidatuuri tagasivõtmist, “kuna levivad kuuldused…”. ERR-ile antud intervjuus ütleb peaminister paraku, et sellist ettepanekut ta ei teinud.\r\n\r\nMarti Kuusiku pihta suunatud loo allosas aga on selgelt öeldud: “Postimees võttis eelmisel nädalal ühendust väidetava ohvriga, kes ütles, et see info ei vasta tõele. «See väide on absurdne. Marti Kuusik on väga hea isa, me saame väga hästi läbi ja ta sobib ministriks suurepäraselt. Toetan teda täielikult,» kommenteeris ta.”", 
                    NewsLinks = new() {
                            "https://ekspress.delfi.ee/artikkel/92251051/juri-ratas-paastis-tagasi-astudes-oma-poliitikunahka",
                            "https://online.le.ee/2017/12/14/skandaal-linnamae-peekoni-umber-juri-ratas-ei-otsi-kadri-simsonile-asendajat/",
                            "https://uueduudised.ee/postimees-jarjekordne-skandaal-ratase-valitsuses-ei-jarjekordne-skandaal-ajakirjanduses/"
                },

                new Person
                {
                    Name = "Taavi Rõivas",
                    Subtitle = "Poliitik",
                    HeroImage = "Taavi.jpg",
                    DetailsKey = "TaaviRõivas",
                    Description = "Taavi Rõivas (sündinud 26. septembril 1979) on Eesti poliitik, Eesti Reformierakonna esimees (2014–2017) ja " +
                    "Eesti peaminister (2014–2016).\r\n\r\nAastatel 2012–2014 oli Rõivas Eesti sotsiaalminister. 14. märtsil 2014 tegi president Ilves Taavi Rõivale ülesandeks " +
                    "moodustada valitsus ja sama aasta 26. märtsil kinnitas president Rõiva Eesti peaministriks. 7. novembril 2016 tegid koalitsioonipartnerid IRL " +
                    "ja Sotsiaaldemokraatlik Erakond Rõivale ettepaneku tagasi astuda.[1] 9. novembril 2016 tegi Riigikogu Taavi Rõivale umbusaldusavalduse " +
                    "(umbusaldamise poolt hääletas 63 Riigikogu liiget, vaja oli 51 häält).",
                    News = new() { "Uudis 1: Reformierakondlasest endine peaminister Taavi Rõivas näib olevat krooniline maniakk, kes nii poliitikuna kui ka abielumehena pidevalt amoraalselt avalikkuse ees käitub.\r\n\r\nKülmkapi-Taavina meelde jäänud endise esiorava viimane perversne skandaal rullus lahti läinud aasta sügisel, kui ta koos kellegi Brigitte Susanne Hundiga Lillepaviljoni peldikusse suundus ja end sinna kümneks minutiks lukustanud. See, et kohal oli ka Rõivase abikaasa Luisa, teda muidugi ei morjendanud.",
                                   "Uudis 2: Ühel hetkel läksid eemale, sosistasid ja sahistasid, käsi tagumiku peal,» väidab neljapäeva õhtul TV3 sügispeol viibinud isik. Olgugi et Taavi Rõivas oli peole saabunud koos abikaasaga, veetis ta intiimselt aega nii Brigitte Susanne Hundi kui Desiree Mummiga." ,
                                   "Uudis 3: ",
                         NewsLinks = new() {
                                "https://uueduudised.ee/eesti-endine-reformierakondlasest-peaminister-ja-tema-piinlikud-skandaalid/",
                                "https://elu24.postimees.ee/7860541/ekspeaminister-taavi-roivas-ja-bsh-vupsasid-koos-wc-kabiini-luisa-jai-kurva-naoga-korvalt-vaatama",
                                ""
                },



                new Person
                {
                    Name = "Kaja Kallas",
                    Subtitle = "Euroopa Liidu välisasjade ja julgeolekupoliitika kõrge esindaja\r\n",
                    HeroImage = "ott.webp",
                    DetailsKey = "KajaKallas",
                    Description = "Kaja Kallas (aastatel 2002–2006 Kaja Leiger; sündinud 18. juunil 1977 Tallinnas) " +
                    "on Eesti poliitik ja jurist, kes oli aastatel 2021–2024 Eesti peaminister ja 2018–2024 " +
                    "Eesti Reformierakonna esimees. Alates 1. detsembrist 2024 on ta Euroopa Liidu välisasjade " +
                    "ja julgeolekupoliitika kõrge esindaja ja Euroopa Komisjoni asepresident. " +
                    "Kallas on Eesti esimene naispeaminister.",
                    News = new() { "Uudis 1: Venemaa siseministeeriumi tagaotsitavate andmebaasis on ilmunud Eesti peaministri Kaja Kallase ja riigisekretär Taimar Peterkopi nimed. Kuigi andmebaasis ei ole välja toodud, millise paragrahvi alusel Kallast ja Peterkopi tagaotsitakse, tekitab see siiski rahvusvahelist tähelepanu. Varasemalt andis Venemaa uurimiskomitee esimees Aleksandr Bastrõkin korralduse kontrollida Eesti võimude tegevust seoses tankimonumendi eemaldamisega Narvas.",
                                   "Uudis 2: Politoloog Tõnis Leht asetab Kaja Kallase samale skaalale president Lennart Meri ja Toomas Hendrik Ilvesega. „Ta on neist isegi kraadi võrra nähtavam, kuuldavam ja mõjukam olnud,“ märgib Leht.\r\n\r\nEile andis Kaja Kallas president Alar Karisele üle tagasiastumisavalduse. Täna tegi president peaministrikandidaat Kristen Michalile ettepaneku moodustada uus valitsus.\r\n\r\nSee tähendab, et Eesti ühe välispoliitiliselt enim silma paistnud peaministri kolme ja poole aastane ametiaeg on läbi saanud. Sellesse aega on mahtunud nii koroonaaeg, energiakriis ja Venemaa täiemahuline sõda Ukraina vastu kui ka riigisisesed skandaalid ja tülid.\r\nOled juba tellija?\r\nMis on Delfi Kogupakett?\r\nTellijana saad lugeda ka neid artikleid:\r\nSotsid tahavad homme alustada Tallinna võimukõnelusi, Isamaa keeldub kohtumisel osalemast\r\nSotsid tahavad homme alustada Tallinna võimukõnelusi, Isamaa keeldub kohtumisel osalemast (288)\r\nTapa vallavalitsuse liige ja sotsiaalosakonna juht veab samal ajal edukat sotsiaalteenuste MTÜ-d. Politsei asus uurima võimalikku korruptsiooni\r\nTapa vallavalitsuse liige ja sotsiaalosakonna juht veab samal ajal edukat sotsiaalteenuste MTÜ-d. Politsei asus uurima võimalikku korruptsiooni (118)\r\nKairi Kuusemaa võib vanglast enne tähtaja lõppu vabaneda\r\nKairi Kuusemaa võib vanglast enne tähtaja lõppu vabaneda (122)\r\nSamal teemal\r\n15.07.2024\r\nFOTOD JA VIDEO | Kaja Kallas andis presidendile üle tagasiastumisavalduse (775)\r\n16.07.2024\r\nFOTOD | President Karis näitas Michalile rohelist tuld valitsuse moodustamiseks (322)\r\nKommenteeri Loe kommentaare (526)\r\n\r\n" ,
                                   "Uudis 3: Euroopa Parlamendi saadik Jaak Madison (EKRE) kirjutab sotsiaalmeedias, et Kaja Kallas on puhkenud skandaali kontekstis käitunud valelikult, silmakirjalikult ja kahepalgeliselt, nõudes kõikidelt ettevõtjatelt Venemaa suunas äritegevuse lõpetamist, samal ajal kui tema abikaasa teenib mõnusat tulu Venemaa ärist. Ühtlasi kutsub ta rahvast meeleavaldusele Eesti mainet kahjustanud peaministri vastu.",
                         NewsLinks = new() {
                                "https://minuaeg.com/skandaal-kaja-kallase-ja-ametnike-nimed-ilmusid-venemaa-tagaotsitavate-nimekirja/",
                                "https://www.delfi.ee/artikkel/120307812/ulevaade-kaja-kallas-on-hoolimata-skandaalidest-ja-ulatuslikest-kriisidest-jaanud-silma-tugeva-valispoliitilise-kailakujuna",
                                "https://objektiiv.ee/jaak-madison-kaja-kallas-on-valelik-silmakirjalik-ja-kahepalgeline/taavi rõiva "
                }
<<<<<<< Updated upstream
        }
=======
        };
>>>>>>> Stashed changes

                         


        
       

        public static List<Person> GetAllPeople() => people;

        public static Person GetPersonByName(string name)
                => people.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

    }
}

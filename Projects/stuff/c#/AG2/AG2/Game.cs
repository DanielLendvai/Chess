using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace AG2
{
    /// <summary>
    /// A harc tipusa
    /// </summary>
    public enum HarcTipus
    {
        /// <summary>
        /// Nincs harc
        /// </summary>
        Bekes,

        /// <summary>
        /// Harcolni kell a továbblépés előtt
        /// </summary>
        Harcos,

        /// <summary>
        /// Választhatsz, harcolsz, vagy visszavonulsz
        /// </summary>
        Valaszthato
    }

    /// <summary>
    /// A játék egy szintje
    /// </summary>
    public class Fejezet
    {
        /// <summary>
        /// A fejezet sorszáma
        /// </summary>
        public int Szam;

        /// <summary>
        /// Az fejezet neve
        /// </summary>
        public string Nev;

        /// <summary>
        /// Mit kell benne csinálni
        /// </summary>
        public HarcTipus Tipus;

        /// <summary>
        /// Szöveges leírás
        /// </summary>
        public string Szoveg;

        /// <summary>
        /// Harc vagy választás esetén az a pontszám, aminél nagyobb vagy egyenlőt dobva továbbjuthatsz
        /// </summary>
        public int NyeroDobas;

        /// <summary>
        /// Szöveg, ha nyertél
        /// </summary>
        public string NyertelSzoveg;

        /// <summary>
        /// Szöveg, ha vesztettél
        /// </summary>
        public string VesztettelSzoveg;

        /// <summary>
        /// Szöveg, ha úgy választottál
        /// </summary>
        public string ValasztottalSzoveg;

        /// <summary>
        /// Ugrás fejezetre, ha nyertél vagy békés fejezet esetén
        /// </summary>
        public int Kovetkezo;

        /// <summary>
        /// Ugrás fejezetre, ha vesztettel
        /// </summary>
        public int Elozo;

/*        /// <summary>
        /// Ugrás fejezetre, ha úgy választottál
        /// </summary>
        public int Valasztas;
*/

        /// <summary>
        /// Hova mehetek tovább?
        /// </summary>
        public int[] Hivatkozasok;
    }

    /// <summary>
    /// Egy karakter neme
    /// </summary>
    public enum CharacterGender
    { 
        /// <summary>
        /// Férfi
        /// </summary>
        Male,

        /// <summary>
        /// Nő
        /// </summary>
        Female, 

        /// <summary>
        /// Ismeretlen
        /// </summary>
        Unknown
    }

    /// <summary>
    /// Karakter kasztja
    /// </summary>
    public enum CharacterClass { Warrior, Hunter, Mage, Paladin, Rouge };


    /// <summary>
    /// Egy (futó) játék aktuális állapota
    /// </summary>      
    public class Profile
    {
        /// <summary>
        /// Character name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Karakter kasztja
        /// </summary>
        public CharacterClass Class { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        public CharacterGender Gender { get; set; }

        /// <summary>
        /// Az aktuális fejezet
        /// </summary>
        public int Fejezet;

        /// <summary>
        /// Az elért pontszam
        /// </summary>
        public int Pontszam;
    }

    /// <summary>
    /// Játékok kezelője
    /// </summary>
    /// <remarks>
    /// Tartalmazza a játékhoz szükséges betöltött adatokat, mint például a fejezeteket és a mentett játékokat is.
    /// </remarks>
    public class Game
    {
        /// <summary>
        /// A játék szintjei
        /// </summary>
        public Fejezet[] Fejezetek;

        private List<Profile> _profiles = new List<Profile>();

        public Profile Profile;

        private const string FejezetekFileName = ".fejezetek.json";

        private const string ProfilesFileName = ".profiles.json";

        public void Save()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { Formatting = Formatting.Indented };

//            string text = JsonConvert.SerializeObject(Fejezetek, settings);
//            File.WriteAllText(FejezetekFileName, text);
            string text = JsonConvert.SerializeObject(_profiles, settings);
            File.WriteAllText(ProfilesFileName, text);

        }

        public void Load()
        {
            if(Fejezetek == null && File.Exists(FejezetekFileName))
            {
                JsonSerializerSettings settings = new JsonSerializerSettings {};
                Fejezetek = JsonConvert.DeserializeObject<Fejezet[]>(File.ReadAllText(FejezetekFileName), settings);
            }

            if(File.Exists(ProfilesFileName))
            {
                JsonSerializerSettings settings = new JsonSerializerSettings {};
                _profiles = JsonConvert.DeserializeObject<List<Profile>>(File.ReadAllText(ProfilesFileName), settings);
            }

        }

        /// <summary>
        /// List of user profiles
        /// </summary>
        public List<Profile> Profiles => _profiles;

        /// <summary>
        /// Csak egy lehet a játék kezelőből
        /// </summary>
        private Game()
        {
        }

        private static Game __game;

        /// <summary>
        /// The actual game
        /// </summary>
        public static Game Current
        {   
            get
            {
                if(__game == null)
                    __game = new Game();
                return __game;
            }
        }
    }
}

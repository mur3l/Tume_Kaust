using TumeKaust.Services;
using System.IO;

namespace TumeKaust
{
    public partial class App : Application
    {
        // Põhiandmebaas (nt muud andmed)
        private static DatabaseService _database;
        public static DatabaseService Database
        {
            get
            {
                if (_database == null)
                {
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "tume.db3");
                    _database = new DatabaseService(dbPath);
                }
                return _database;
            }
        }

        // ✅ Lisa teise andmebaasi jaoks eraldi property teise nimega
        private static HintDatabase _hintDatabase;
        public static HintDatabase HintDatabase
        {
            get
            {
                if (_hintDatabase == null)
                {
                    var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "hints.db3");
                    _hintDatabase = new HintDatabase(dbPath);
                }
                return _hintDatabase;
            }
        }

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new AppShell());
        }
    }
}

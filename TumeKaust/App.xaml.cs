using TumeKaust.Services;

namespace TumeKaust
{


    public partial class App : Application
    {
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

        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
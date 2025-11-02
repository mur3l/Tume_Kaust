using SQLite;
using TumeKaust.Models;

namespace TumeKaust.Services
{
    public class HintDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public HintDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Hint>().Wait();
        }

        public Task<int> SaveHintAsync(Hint hint)
        {
            return _database.InsertAsync(hint);
        }

        public Task<List<Hint>> GetHintsAsync()
        {
            return _database.Table<Hint>().ToListAsync();
        }
    }
}

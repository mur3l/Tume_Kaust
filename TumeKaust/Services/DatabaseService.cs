using SQLite;
using TumeKaust.Models;

namespace TumeKaust.Services
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;

        public DatabaseService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<MainPageCategoryGrid>().Wait();
        }

        public Task<List<MainPageCategoryGrid>> GetCategoriesAsync()
        {
            return _database.Table<MainPageCategoryGrid>().ToListAsync();
        }

        public Task<int> SaveCategoryAsync(MainPageCategoryGrid category)
        {
            if (category.CategoryId != 0)
                return _database.UpdateAsync(category);
            else
                return _database.InsertAsync(category);
        }

        public Task<int> DeleteCategoryAsync(MainPageCategoryGrid category)
        {
            return _database.DeleteAsync(category);
        }
    }
}

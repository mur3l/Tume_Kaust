using TumeKaust.Models;

namespace TumeKaust.Services
{
    // Kategooriate nimekiri
    public static class CategoryService
    {
        public static List<MainPageCategoryGrid> GetCategories() => new() //Koostab nimekirja, mida kuvada gridis
        {
            new MainPageCategoryGrid {Name = "Presidendid", Image = "meri1.png"}
        };
    }
}

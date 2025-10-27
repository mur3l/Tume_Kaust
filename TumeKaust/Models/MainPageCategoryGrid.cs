using SQLite;

namespace TumeKaust.Models
{ //Mainpage Kategooriate gridi mudel
    public class MainPageCategoryGrid
    {
        public int CategoryId { get; set; }
        public string? Name { get; set; }
        public string Image {  get; set; } = string.Empty;
    }
}

namespace TumeKaust.Models
    //G: Tegin selle, sest vaja kuvada hiljuti uuendatud isikud
{
    public class PersonalDetailsGrid
    {
        public int PersonalDetailsId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Age { get; set; } = 0;
        public int CategoryId { get; set; } //seos kategooriaga
        public string? Scandal { get; set; }
        public string? Image { get; set; }
        public DateTime? UpdatedAt { get; set; } //hiljutiste sortimiseks vajalik
        public DateTime CreatedAt { get; set; }
    }
}

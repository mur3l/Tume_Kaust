namespace TumeKaust.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Subtitle { get; set; }       
        public string HeroImage { get; set; }    
        public string Description { get; set; }   
        public List<string> News { get; set; }
        public List<string> NewsLinks { get; set; }
        public string Category { get; set; }

        public string? ImagePath { get; set; }

    }
}

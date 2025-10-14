using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TumeKaust.Models
    //Gervin: Tegin selle, sest vaja kuvada hiljuti uuendatud isikud
{
    public class PersonalDetailsGrid
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int Age { get; set; } = 0;
        public string? Category { get; set; } //seos kategooriaga
        public string? Scandal { get; set; }
        public string? Image { get; set; }
        public DateTime? UpdatedAt { get; set; } //hiljutiste sortimiseks vajalik
        public DateTime CreatedAt { get; set; }
    }
}

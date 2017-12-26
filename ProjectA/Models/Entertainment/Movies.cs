using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectA.Models.Entertainment
{


    public class Movie
    {
        [Key]
        [MaxLength(40)]
        public string MovieName { get; set; }
        public string Genre { get; set; }
        public string State { get; set; }
        public string Director { get; set; }
        public int Duration { get; set; }
        public int Release { get; set; }

        public List<Actor> Actors { get; set; }
    }
}

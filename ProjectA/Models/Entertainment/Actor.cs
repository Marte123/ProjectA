using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectA.Models.Entertainment
{
    public class Actor
    {
       
        public int ActorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Born { get; set; }
        public string KnownFor { get; set; }
        public string PersonalDetails { get; set; }


        public string MovieName { get; set; }
        public Movie Movie { get; set; }

    }
}

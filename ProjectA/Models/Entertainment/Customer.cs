using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectA.Models.Entertainment
{

        public class Customers
        {
            [Key]
            [MaxLength(50)]
            public int CustomerID { get; set; }
            public string CustomerName { get; set; }
            public string MembershipType { get; set; }
            public string State { get; set; }


            public List<Movie> Movies { get; set; }
        }
}
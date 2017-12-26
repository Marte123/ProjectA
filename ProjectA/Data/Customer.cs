using ProjectA.Models.Entertainment;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectA.Data
{
    public class Customer
    { 
            [Key]
            [MaxLength(40)]
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
            public string MembershipType { get; set; }
            public string State { get; set; }


            public List<Movie> Movies { get; set; }
        }
}
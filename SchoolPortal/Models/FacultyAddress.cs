using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SchoolPortal.Models
{
    [Table("FacultyAddresses")]
    public class FacultyAddress
    {
        public int Id { get; set; }

        public string HouseNumber { get; set; }

        public string Street { get; set; }

        public string Barangay { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public int Zipcode { get; set; }
    }
}
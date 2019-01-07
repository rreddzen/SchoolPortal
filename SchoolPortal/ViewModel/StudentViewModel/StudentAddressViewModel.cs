using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolPortal.ViewModel.Students
{
    public class StudentAddressViewModel
    {
        [Display(Name = "House Number")]
        public string HouseNumber { get; set; }

        [Display(Name = "Street")]
        public string Street { get; set; }

        [Display(Name = "Barangay")]
        public string Barangay { get; set; }

        [Display(Name = "City")]
        public string City { get; set; }

        [Display(Name = "Province")]
        public string Province { get; set; }

        [Display(Name = "Zipcode")]
        public int Zipcode { get; set; }
    }
}
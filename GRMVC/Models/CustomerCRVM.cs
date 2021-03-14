using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GRMVC.Models
{
    public class CustomerCRVM
    {
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }
        public string Address { get; set; }
        [DisplayName("Zip Code")]
        //[Range(4,6, ErrorMessage = "Zip code must have 5 digits")]
        public int ZipCode { get; set; }
    }
}

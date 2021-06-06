using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User
    {
        public int UserID { get; set; }

        [Required(ErrorMessage = "Please enter User Firstname.")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter User Lastname.")]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter address.")]
        [Display(Name = "Address")]
        public string Address { get; set; }
        public int CityID { get; set; }
        public int CountryID { get; set; }


        public City City { get; set; }
        public Country Country { get; set; }

    }
}

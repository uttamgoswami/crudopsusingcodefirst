using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
    }
}

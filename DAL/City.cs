using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    public class City
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
    }
}

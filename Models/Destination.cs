using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace AjaxDemo.Models
{
    [Table("Destinations")]
    public class Destination
    {
        [Key]
        public int Id { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        
        public Destination(string city, string country, int Id)
        {
            City = city;
            Country = country;
            Id = 0;
        }
        public Destination() { }
    }
}

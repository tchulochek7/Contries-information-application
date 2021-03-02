using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CountriesInformationAPI.Models
{
    public class Region
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
    }
}

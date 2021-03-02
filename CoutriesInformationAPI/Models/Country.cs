using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CountriesInformationAPI.Models
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Code { get; set; }

        public int? CapitalId { get; set; }

        public City Capital { get; set; }

        public double Area { get; set; }

        public int Population { get; set; }

        public int? RegionId { get; set; }

        public Region Region { get; set; }
    }
}

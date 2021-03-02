using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CountiesInformationClient.Models
{
    public class Country
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Code { get; set; }

        public int? CapitalId { get; set; }

        public City Capital { get; set; }

        public double Area { get; set; }

        public int Population { get; set; }

        public int? RegionId { get; set; }

        public Region Region { get; set; }
    }
}

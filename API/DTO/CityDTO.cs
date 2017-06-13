using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.DTO
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Fk_countryId { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.Address
{
    public class CreateAddressRequest
    {
        public required double Latitude { get; set; }
        public required double Longitude { get; set; }
        public required string Name { get; set; }
    }
}

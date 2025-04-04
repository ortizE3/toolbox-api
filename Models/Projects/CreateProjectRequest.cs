using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.Projects
{
    public class CreateProjectRequest
    {
        public required string UserId { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required double Longitude { get; set; }
        public required double Latitude { get; set; }
        public required string Address { get; set; }
    }
}

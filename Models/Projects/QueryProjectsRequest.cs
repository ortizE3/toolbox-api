using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.Projects
{
    public class QueryProjectsRequest
    {
        public double radius { get; set; }
        public double userLatitude { get; set; }
        public double userLongitude { get; set; }
    }
}

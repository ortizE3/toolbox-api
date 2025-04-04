using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.Users
{
    public class CreateUserRequest
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}

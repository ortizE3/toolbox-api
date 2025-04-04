using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.Address
{
    [Table("address")]
    public class Address
    {
        [Column("latitude")]
        public required double Latitude { get; set; }
        [Column("longitude")]
        public required double Longitude { get; set; }
        [Column("name")]
        public required string Name { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("addressId")]
        public Guid AddressId { get; set; }
    }
}

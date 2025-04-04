
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace models.Users
{
    [Table("user")]
    public class User
    {
        [Key]
        [Column("id")]
        public required string Id { get; set; }

        [Column("email")]
        public required string Email { get; set; }

        [Column("name")]
        public required string Name { get; set; }
        [Column("addressId")]
        public Guid? AddressId { get; set; }
        public models.Address.Address? Address { get; set; }
    }
}

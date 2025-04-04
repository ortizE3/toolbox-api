using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace models.Projects
{
    [Table("project")]
    public class Project
    {
        [Column("userId")]
        public required string UserId { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("projectId")]
        public Guid ProjectId { get; set; }
        [Column("title")]
        public required string Title { get; set; }
        [Column("description")]
        public required string Description { get; set; }
        [Column("latitude")]
        public required double Latitude { get; set; }
        [Column("longitude")]
        public required double Longitude { get; set; }
        [Column("Address")]
        public required string Address { get; set; }
    }
}

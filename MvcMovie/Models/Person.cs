using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public string PersonId { get; set; }

        [MaxLength(200)]
        public string FullName { get; set; }

        [MaxLength(300)]
        public string Address { get; set; }
        public int? Age { get; set; }
    }
}

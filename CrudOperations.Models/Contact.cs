using System.ComponentModel.DataAnnotations;

namespace CrudOperations.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(10)]
        public string Phone { get; set; }
        [Required]
        [StringLength(100)]
        public string Address { get; set; }
    }
}
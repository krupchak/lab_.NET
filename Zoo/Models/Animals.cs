using System.ComponentModel.DataAnnotations;

namespace Zoo.Models
{
    public class Animals
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [MaxLength(30)]
        public string? Owner { get; set; }

        [MaxLength(30)]
        [Required]
        public string AnimalType { get; set; }
    }
}
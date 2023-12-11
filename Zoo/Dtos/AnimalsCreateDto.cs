using System.ComponentModel.DataAnnotations;

namespace Zoo.Dtos
{
    public class AnimalsCreateDto
    {
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
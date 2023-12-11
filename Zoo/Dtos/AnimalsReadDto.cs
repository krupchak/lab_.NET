namespace Zoo.Dtos 
{
    public class AnimalsReadDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime BirthDate { get; set; }

        public string? Owner { get; set; }

        public string AnimalType { get; set; }
    }
}
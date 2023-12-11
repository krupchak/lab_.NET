using AutoMapper;
using Zoo.Models;
using Zoo.Dtos;

 namespace Zoo.Profiles
 {
    public class AnimalsProfile : Profile
    {
        public AnimalsProfile()
        {
            // Source -> Target
            CreateMap<Animals, AnimalsReadDto>();
            CreateMap<AnimalsCreateDto, Animals>();
        }
    }
 }
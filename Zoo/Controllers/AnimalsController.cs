using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Zoo.Data;
using Zoo.Dtos;

namespace Zoo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private readonly IAnimalsRepo _repository;
        private readonly IMapper _mapper;

        public AnimalsController(IAnimalsRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AnimalsReadDto>> GetAnimals()
        {
            Console.WriteLine("--> Getting Animals...");

            var animalItem = _repository.GetAllAnimals();

            return Ok(_mapper.Map<IEnumerable<AnimalsReadDto>>(animalItem));
        }
    }
}
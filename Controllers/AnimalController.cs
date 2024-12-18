using HerenciaInterface.EjemplodeHerencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HerenciaInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {
        [HttpGet]
        public string GetAnimal()
        {
            //Animal animal = new Animal();
            //animal.Nombre = "Bolt";
            //animal.Especie = "Ovejero Alemán";
            //return animal.Nombre;


            //Leon leon = new Leon();
            //leon.Nombre = "Simba";

            //return leon.Nombre;

            Perro perro = new Perro();
            perro.EmitirSonido();

            return perro.EmitirSonido();




        }
        
    }
}

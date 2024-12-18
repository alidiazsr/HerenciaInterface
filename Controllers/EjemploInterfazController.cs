using HerenciaInterface.EjemplodeInterfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HerenciaInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploInterfazController : ControllerBase
    {
        [HttpGet]

        public string EjemploInterfaz()
        {
            //Moto moto = new Moto();
            //return moto.Frenar();

            Perro perro = new Perro();
            return perro.EmitirSonido();
        }
    }
}

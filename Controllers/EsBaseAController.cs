using HerenciaInterface.EjemplodeInterfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HerenciaInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EsBaseAController : ControllerBase
    {
        [HttpGet]
        public string EsBaseAInterfaz()
        {
            EjemplodeInterfaz.EsBaseA esBaseA = new EsBaseA();
            Perro perro = new Perro();
            return esBaseA.Comer(perro);
        }

    }
}

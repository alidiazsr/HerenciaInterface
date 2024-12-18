using Microsoft.AspNetCore.Http;
using HerenciaInterface.EjemplodeInterfaz;
using Microsoft.AspNetCore.Mvc;

namespace HerenciaInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EjemploDosInterfaz_Controller : ControllerBase
    {
         [HttpGet]
         public string EjemploDosInterfaz()
        {
            EjemplodeInterfaz.EsBase esBase = new EsBase();
            Auto auto = new Auto();
            return esBase.Acelerar(auto);
        }
        


    }
}

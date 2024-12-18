using HerenciaInterface.EjemplodeHerencia;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HerenciaInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HerenciaController : ControllerBase
    {
        [HttpGet]
        public string GetVehiculo()
        {
            //Vehiculo vehiculo = new Vehiculo("Rojo");
            //vehiculo.Marca = "Toyota";
            //vehiculo.Modelo = "Corolla";
            ////return vehiculo.Modelo;

            //return vehiculo.devolverColor();

            Moto moto = new Moto();

            moto.TipodeMoto = "Cross";
            moto.Marca = "Honda";

            moto.Acelerar();

            return moto.Marca;
        }
    }
}

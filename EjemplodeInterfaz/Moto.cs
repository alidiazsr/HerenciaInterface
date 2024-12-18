namespace HerenciaInterface.EjemplodeInterfaz
{
    public class Moto : IVehiculo
    {
        public string Acelerar()
        {
            return "La Moto esta acelerando";
        }

        public string Frenar()
        {
            return "La Moto esta frenando";
        }
    }
  
}

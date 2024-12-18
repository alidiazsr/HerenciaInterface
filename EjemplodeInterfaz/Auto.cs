namespace HerenciaInterface.EjemplodeInterfaz
{
    public class Auto : IVehiculo
    {
        public string Acelerar()
        {
            return "El Auto esta acelerando";
        }

        public string Frenar()
        {
            return "El Auto esta frenando";
        }
    }
}

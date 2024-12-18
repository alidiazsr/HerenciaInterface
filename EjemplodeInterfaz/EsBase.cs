namespace HerenciaInterface.EjemplodeInterfaz
{
    public class EsBase
    {
        public string Acelerar(IVehiculo vehiculo)
        {
            return vehiculo.Acelerar();
        }
    }
}

namespace HerenciaInterface.EjemplodeInterfaz
{
    public class EsBaseA
    {
        public string Comer(IAnimal animal)
        {
            return animal.Comer();
        }
    }
}

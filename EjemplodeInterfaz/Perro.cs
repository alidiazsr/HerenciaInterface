namespace HerenciaInterface.EjemplodeInterfaz
{
    public class Perro : IAnimal
    {
        public string EmitirSonido()
        {
            return "El Perro esta emitiendo un sonido";
        }

        public string Comer()
        {
            return "El Perro esta comiendo";
        }
    }
}

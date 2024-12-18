namespace HerenciaInterface.EjemplodeHerencia
{
    public class Perro : Animal
    {
        public string Raza { get; set; }

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

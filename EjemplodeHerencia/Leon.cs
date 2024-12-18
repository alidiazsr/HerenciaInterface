namespace HerenciaInterface.EjemplodeHerencia
{
    public class Leon : Animal
    {
        public string Habitat { get; set; }

        public override string EmitirSonido()
        {
            return "El León esta emitiendo un sonido";
        }

        public override string Comer()
        {
            return "El León esta comiendo";
        }
    }
}

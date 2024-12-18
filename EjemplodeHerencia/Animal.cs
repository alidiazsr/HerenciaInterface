namespace HerenciaInterface.EjemplodeHerencia
{
    public class Animal
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }

        public  Animal()
            {

            //this.Nombre = nombre;
            //this.Especie = especie;

        }

        public virtual string EmitirSonido()
        {
            return "El animal esta emitiendo un sonido";
        }

        public virtual string Comer()
        {
            return "El animal esta comiendo";
        }

    }
}

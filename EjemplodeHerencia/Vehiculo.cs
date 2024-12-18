namespace HerenciaInterface.EjemplodeHerencia
{
    public class Vehiculo
    {
        // Propiedades
        // si pongo private no se puede acceder desde afuera
        // si puedo acceder desde la misma clase en un metodo

        //private string Color { get; set; }

        //Una clase puede tener varios constructores
        // tambien puedo no tener constructores
        // o desde un constructor
        // Si no se pone nada es privado
        // Si sabemos que el valor del condtructor no va a cambiar
        // se puede setear

        //Pasa a la clase hija protected para que pueda acceder
        // a la clase hija pero no desde afuera 
        //protected string Marca { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Vehiculo()
        {
            //this.Color = "Rojo";
            //this.Color = color;
            //this.Marca = marca;

        }
        //public string devolverMarca()
        //{

        //    return this.Marca;
        //}


        // Metodos funcionalidad
        public virtual string Acelerar()
        {
            
            return "El vehiculo esta acelerando";
        }

        public virtual string Frenar()
        {
            return "El vehiculo esta frenando";
        }
        //public string devolverColor()
        //{
        //    return this.Color;
        //}

    }
}

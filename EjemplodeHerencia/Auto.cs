namespace HerenciaInterface.EjemplodeHerencia
{

    //La clase Auto hereda de la clase Vehiculo
    //La clase Auto hereda todos los atributos y metodos de la clase Vehiculo

    public class Auto : Vehiculo
    {
        public string NroChasis { get; set; }

        public override string Acelerar()
        {

            return "El Auto esta acelerando";
        }

        public override string Frenar()
        {
            //throw new System.NotImplementedException();
            return "El Auto esta frenando";
        }
    }
}



namespace HerenciaInterface.EjemplodeHerencia
{

    //La clase Moto hereda de la clase Vehiculo
    //La clase Moto hereda todos los atributos y metodos de la clase Vehiculo

    public class Moto : Vehiculo
    {
        //Atributos de la clase Moto
        //Encapsulamiento

        public string TipodeMoto { get; set; }

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

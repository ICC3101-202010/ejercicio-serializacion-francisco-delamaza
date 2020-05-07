using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Serializacion_Francisco_De_la_Maza
{
    [Serializable]
    public class Person
    {
        public string nombre;
        public string apellido;
        public int edad;

        
        public Person(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }
    }
}

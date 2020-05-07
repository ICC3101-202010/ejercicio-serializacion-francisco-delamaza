using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serializacion_Francisco_De_la_Maza
{
    class Program
    {
        static void Main(string[] args)
        {

            List < Person > personas = new List<Person>();
            bool b = true;
            while (b == true)
            {
            

           
                Console.WriteLine("1) Crear Persona");
                Console.WriteLine("2) Ver Personas ");
                Console.WriteLine("3) Cargar Personas");
                Console.WriteLine("4) Guardar Personas");
                Console.WriteLine("5) Salir");

                string x = Console.ReadLine();
                if (x == "1")
                {

                    Console.WriteLine("nombre:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Apellido:");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("edad:");
                    string edad = Console.ReadLine();
                    int e = Convert.ToInt32(edad);

                    Person p = new Person(nombre, apellido, e);
                    personas.Add(p);
                    Console.WriteLine();
                    
                }
                if(x=="2")
                {
                    foreach(Person i in personas)
                    {
                        Console.WriteLine($"{i.nombre} {i.apellido} {i.edad}");
                    }
                }
                if (x == "3")
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
                    List<Person> personas2 = (List<Person>)formatter.Deserialize(stream);
                    stream.Close();
                    foreach (Person i in personas2)
                    {
                        personas.Add(i);
                    }
                }
                if (x == "4")
                {
                    IFormatter formatter = new BinaryFormatter();
                    Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                    formatter.Serialize(stream, personas);
                    stream.Close();
                }
                if (x == "5")
                {
                    b = false;
                }
            }
        


          





        }
    }
}

using AdminPersonasModel.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersona
{
    public partial class Program
    {
        static void MostrarPersona()
        {
            List<Persona> personas = new PersonasDAL().ObtenerPersonas();
            for (int i = 0; i < personas.Count(); i++)
            {
                Persona actual = personas[i];
                Console.WriteLine("{0} : Nombre: {1} y Peso: {2}", i, actual.Nombre, actual.Peso);
            }
        }
        static void BuscarPersona()
        {
            Console.WriteLine("Ingrese nombre a buscar");
            List<Persona> filtradas = new PersonasDAL().FiltrarPersonas(Console.ReadLine().Trim());

            filtradas.ForEach(p => Console.WriteLine("Nombre: {0} y Peso: {1}", p.Nombre, p.Peso));
            
        }
        static void IngresarPersona()
        {
            string nombre;
            uint telefono;
            double peso;
            double estatura;

            Console.WriteLine("Bienvenido al programa ultradistinto");

            bool esValido;

            do
            {
                Console.WriteLine("Ingrese telefono");
                esValido = UInt32.TryParse(Console.ReadLine().Trim(), out telefono);
            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese peso");
                esValido = Double.TryParse(Console.ReadLine().Trim(), out peso);

            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese estatura");
                esValido = Double.TryParse(Console.ReadLine().Trim(), out estatura);

            } while (!esValido);

            do
            {
                Console.WriteLine("Ingrese nombre");
                nombre = Console.ReadLine().Trim();
            } while (nombre == string.Empty);

            Persona p = new Persona()
            { Nombre = nombre, Estatura= estatura, Peso= peso, Telefono= telefono};
            /*p.Nombre = nombre;
            p.Estatura = estatura;
            p.Peso = peso;
            p.Telefono = telefono;*/

            new PersonasDAL().AgregarPersonas(p);

            Console.WriteLine("Nombre : {0}", p.Nombre);
            Console.WriteLine("Telefono : {0}", p.Telefono);
            Console.WriteLine("Peso : {0}", p.Peso);
            Console.WriteLine("Estatura : {0}", p.Estatura);
            Console.WriteLine("IMC : {0}", peso / (estatura * estatura));
            Console.ReadKey();

        }
    }
}

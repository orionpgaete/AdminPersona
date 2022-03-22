﻿using System;
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

        }
        static void BuscarPersona()
        {

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

            Persona p = new Persona();
            p.Nombre = nombre;

            Console.WriteLine("Nombre : {0}", nombre);
            Console.WriteLine("Telefono : {0}", telefono);
            Console.WriteLine("Peso : {0}", peso);
            Console.WriteLine("Estatura : {0}", estatura);
            Console.WriteLine("IMC : {0}", peso / (estatura * estatura));
            Console.ReadKey();

        }
    }
}

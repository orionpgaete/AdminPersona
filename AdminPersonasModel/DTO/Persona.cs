using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersona
{
    public class Persona
    {
        private string nombre;
        private uint telefono;
        private double peso;
        private double estatura;
        private IMC imc;


        public string Nombre { get => nombre; set => nombre = value; }
        public uint Telefono { get => telefono; set => telefono = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Estatura { get => estatura; set => estatura = value; }

        public void calcularIMC()
        {
            double valor = Peso / (Estatura * Estatura);
            this.imc = new IMC() { Valor = valor };
        }

        public IMC IMC
        {
            get
            {
                return this.imc;
            }
        }

        public override string ToString()
        {
            return Nombre + " " + IMC.Texto;
        }
    }
}

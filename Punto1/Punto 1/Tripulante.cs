using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    abstract class Tripulante
    {
        private int NumeroCarnet;
        private int Edad;
        private int TiempoEnEmpresa;
        private string Nombre;
        private string Telefono;
        private char Sexo;

        protected Tripulante(int numeroCarnet, int edad, int tiempoEnEmpresa, string nombre, string telefono, char sexo)
        {
            NumeroCarnet = numeroCarnet;
            Edad = edad;
            TiempoEnEmpresa = tiempoEnEmpresa;
            Nombre = nombre;
            Telefono = telefono;
            Sexo = sexo;
        }

        public int NumeroCarnet1 { get => NumeroCarnet; set => NumeroCarnet = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
        public int TiempoEnEmpresa1 { get => TiempoEnEmpresa; set => TiempoEnEmpresa = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public char Sexo1 { get => Sexo; set => Sexo = value; }

        public abstract float Sueldo();
        public abstract void MostrarDatos();
    }
}

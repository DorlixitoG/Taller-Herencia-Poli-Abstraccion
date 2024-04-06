using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    class Barco
    {
        private string Nombre;
        private string Tipo;
        private int CapacidadPasajeros;
        private int CapacidadCarga;

        public Barco(string nombre, string tipo, int capacidadPasajeros, int capacidadCarga)
        {
            Nombre = nombre;
            Tipo = tipo;
            CapacidadPasajeros = capacidadPasajeros;
            CapacidadCarga = capacidadCarga;
        }

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public string Tipo1 { get => Tipo; set => Tipo = value; }
        public int CapacidadPasajeros1 { get => CapacidadPasajeros; set => CapacidadPasajeros = value; }
        public int CapacidadCarga1 { get => CapacidadCarga; set => CapacidadCarga = value; }

        public void MostrarDatos()
        {
            Console.WriteLine($"Nombre: {Nombre1}, Tipo: {Tipo1}, Capacidad de Pasajeros: {CapacidadPasajeros1}, Capacidad de Carga: {CapacidadCarga1}");
        }
    }
}

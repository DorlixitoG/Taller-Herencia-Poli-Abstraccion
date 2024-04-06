using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Punto_1
{
     class Marinero: Tripulante
    {
        private int pesoTotalPescado;
        private float sueldoBase = 90000;
        private float bono;

        public Marinero(int pesoTotalPescado, float sueldoBase, float bono, int NumeroCarnet, int Edad, int TiempoEnEmpresa, string Nombre, string Telefono, char Sexo)
            : base(NumeroCarnet, Edad, TiempoEnEmpresa, Nombre, Telefono, Sexo)
        {
            this.pesoTotalPescado = pesoTotalPescado;
            this.sueldoBase = sueldoBase;
            this.bono = bono;
        }

        public int PesoTotalPescado { get => pesoTotalPescado; set => pesoTotalPescado = value; }

        public float SueldoBase => sueldoBase;

        public float Bono { get => bono; set => bono = value; }

        public override float Sueldo()
        {
            Bono = PesoTotalPescado >= 1 ? 0.25f : 0;
            return SueldoBase + Bono;
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($"Número de Carnet: {NumeroCarnet1}, Nombre: {Nombre1}, Sueldo: {Sueldo()}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Punto_1
{
    class Capitan : Tripulante
    {
        private int HorasExperencia;
        private float SueldoBase = 4500000;
        private float Bono;

        public int HorasExperencia1 { get => HorasExperencia; set => HorasExperencia = value; }
        public float SueldoBase1 { get => SueldoBase; set => SueldoBase = value; }
        public float Bono1 { get => Bono; set => Bono = value; }

        public Capitan(int horasExperticia, float sueldoBase, float bono, int NumeroCarnet, int Edad, int TiempoEnEmpresa, string Nombre, string Telefono, char Sexo)
            : base(NumeroCarnet, Edad, TiempoEnEmpresa, Nombre, Telefono, Sexo)
        {
            HorasExperencia1 = horasExperticia;
            SueldoBase1 = sueldoBase;
            Bono1 = bono;
        }
   
        public override float Sueldo()
        {
            if (HorasExperencia1 >= 5000 && HorasExperencia1 < 150000)
                Bono1 = 0.2f;
            else if (HorasExperencia1 >= 150000 && HorasExperencia1 < 300000)
                Bono1 = 0.4f;
            else if (HorasExperencia1 >= 300000)
                Bono1 = 0.75f;

            return SueldoBase1 * (1 + Bono1);
        }
        public override void MostrarDatos()
        {
            Console.WriteLine($"Número de Carnet: {NumeroCarnet1}, Nombre: {Nombre1}, Sueldo: {Sueldo()}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Punto_1
{
     class JefeDeFlota: Tripulante
    {
        private int PesoPescado;
        private int PesoMariscos;
        private float SueldoBase = 350000000;
        private float BonoPescado;
        private float BonoMariscos;

        public JefeDeFlota(int pesoPescado, int pesoMariscos, float sueldoBase, float bonoPescado, float bonoMariscos, int NumeroCarnet, int Edad, int TiempoEnEmpresa, string Nombre, string Telefono, char Sexo)
            : base(NumeroCarnet, Edad, TiempoEnEmpresa, Nombre, Telefono, Sexo)
        {
            PesoPescado = pesoPescado;
            PesoMariscos = pesoMariscos;
            SueldoBase = sueldoBase;
            BonoPescado = bonoPescado;
            BonoMariscos = bonoMariscos;
        }

        public int PesoPescado1 { get => PesoPescado; set => PesoPescado = value; }
        public int PesoMariscos1 { get => PesoMariscos; set => PesoMariscos = value; }
        public float SueldoBase1 { get => SueldoBase; set => SueldoBase = value; }
        public float BonoPescado1 { get => BonoPescado; set => BonoPescado = value; }
        public float BonoMariscos1 { get => BonoMariscos; set => BonoMariscos = value; }
        public override float Sueldo()
        {
            return SueldoBase + BonoPescado + (BonoMariscos * 2);
        }

        public override void MostrarDatos()
        {
            Console.WriteLine($"Número de Carnet: {NumeroCarnet1}, Nombre: {Nombre1}, Sueldo: {Sueldo()}");
        }

    }

}

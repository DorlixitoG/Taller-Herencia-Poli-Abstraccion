using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1
{
    class GPS
    {
        private int CoordenadaX;
        private int CoordenadaY;
        private string FechaHora;
        private int DiasTripulado;

        public GPS(int coordenadaX, int coordenadaY, string fechaHora, int diasTripulado)
        {
            CoordenadaX = coordenadaX;
            CoordenadaY = coordenadaY;
            FechaHora = fechaHora;
            DiasTripulado = diasTripulado;
        }

        public int CoordenadaX1 { get => CoordenadaX; set => CoordenadaX = value; }
        public int CoordenadaY1 { get => CoordenadaY; set => CoordenadaY = value; }
        public string FechaHora1 { get => FechaHora; set => FechaHora = value; }
        public int DiasTripulado1 { get => DiasTripulado; set => DiasTripulado = value; }
        public void MostrarDatos()
        {
            Console.WriteLine($"Coordenadas: ({CoordenadaX}, {CoordenadaY}), Fecha y Hora: {FechaHora}, Días Tripulado: {DiasTripulado}");
        }
    }
}

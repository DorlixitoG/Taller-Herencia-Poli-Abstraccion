using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Punto_1
{
    internal class Program
    {
        class Principal
        {
            static void Main(string[] args)
            {
                Barco barco = new Barco("Titanic", "Transatlántico", 2000, 5000);
                Capitan capitan = new Capitan(200000, 199, 19, 1, 23, 23, "Awo", "23232", 'M');
                JefeDeFlota jefeDeFlota = new JefeDeFlota(1000, 500, 1234, 40, 5, 221, 21, 121212, "Juan", "123456789", 'M');
                GPS gps = new GPS(10, 20, "2024-04-04 12:00:00", 5);
                Marinero[] marineros = new Marinero[7];
                marineros[0] = new Marinero(10, 1, 30, 5,23,1000,"carrion","2121",'M');
                marineros[1] = new Marinero(0, 2, 25, 3,21,211, "Maria", "987654321", 'F');
                marineros[2] = new Marinero(5, 3, 28, 4, 24, 3000, "Carlos", "3333", 'M');
                marineros[3] = new Marinero(3, 4, 35, 6, 25, 4000, "Ana", "4444", 'F');
                marineros[4] = new Marinero(7, 5, 32, 2, 26, 5000, "Pedro", "5555", 'M');
                marineros[5] = new Marinero(2, 6, 29, 1, 27, 6000, "Laura", "6666", 'F');
                marineros[6] = new Marinero(8, 7, 26, 7, 28, 7000, "Diego", "7777", 'M');


                gps.MostrarDatos();
                Console.WriteLine("Datos del Barco:");
                barco.MostrarDatos();

                Console.WriteLine("\nDatos de los Marineros:");
                foreach (var marinero in marineros)
                {
                    marinero.MostrarDatos();
                }

            }
        }
    }
}

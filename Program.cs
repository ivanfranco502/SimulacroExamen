using System;

namespace SimulacroExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1 cotizacionDolar = new Ejercicio1();
            cotizacionDolar.CalculoPrecioPesos();
            System.Console.ReadLine();

            Ejercicio2 matriz = new Ejercicio2();
            matriz.InformarMayorElemento();
            System.Console.ReadLine();

            Ejercicio3 figura = new Ejercicio3();
            figura.ObtenerInformacionFigura();
        }
    }
}

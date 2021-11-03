using System;

namespace manejoExcepcionesClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creando Fracción");
            Fraccion nuevaFraccion = new Fraccion(10, 5); // 10/5

            Console.WriteLine("Resultado Fracción {0}", nuevaFraccion.GetResultado());
            Console.WriteLine($"Resultado Fracción {nuevaFraccion.GetResultado()}");
            Console.WriteLine("Vista de fracción: {0}", nuevaFraccion.GetVista());

            Fraccion otraFraccion = new Fraccion(20, 0);
            Console.WriteLine("Resultado Fracción {0}", otraFraccion.GetResultado());



            //Lanzar Nueva Excepción, por lanzarla, por que necesito lanzar una excepción
            throw new DivideByZeroException();
        }
    }
}

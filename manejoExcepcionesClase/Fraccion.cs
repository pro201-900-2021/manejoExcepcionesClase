using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manejoExcepcionesClase
{
    class Fraccion
    {
        int numerador;
        int denominador;

        public Fraccion(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }

        public int GetNumerador()
        {
            return numerador;
        }

        public void SetNumerador(int value)
        {
            numerador = value;
        }

        public int GetDenominador()
        {
            return denominador;
        }

        public void SetDenominador(int value)
        {
            denominador = value;
        }

        public double GetResultado()
        {
            double resultado;//solamente declaré la variable
            try
            {
                resultado = numerador / denominador; //Excepción

            }catch(DivideByZeroException ex)
            {
                Console.WriteLine("La división por cero no está definida.");
                Console.WriteLine("Mensaje de error: "+ex.Message);
                resultado = 0;
            }catch(Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error, contacte al área correspondiente(AA-00)");
                resultado = 0;
            }

            return resultado;
        }

        public string GetVista()
        {
            //{N(entero)}
            string vista = String.Format("{0}/{1}", numerador, denominador);
            return vista;
        }
    }
}

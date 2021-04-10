using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio35
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 35. Solicitar el ingreso de un número al usuario, repitiendo la operación
            (presentado un mensaje de error hasta que el ingreso sea válido); */
            ValidarIngresoNumero();
            Console.WriteLine("--------------------------------");
            /* 36. Solicitar el ingreso de una fecha al usuario, repitiendo la operación
           (presentado un mensaje de error hasta que el ingreso sea válido); */
            ValidarIngresoFecha();
            Console.ReadKey();
        }

        private static void ValidarIngresoNumero()
        {
            string numero;
            double salidaNum;
            bool flag = false;
            do
            {
                Console.WriteLine("Ingrese un número");
                numero = Console.ReadLine();
                if (!double.TryParse(numero, out salidaNum))
                {
                    Console.WriteLine("Por favor, ingrese un valor numérico");
                }
                else
                {
                    flag = true;
                    Console.WriteLine($"Usted ha ingresado correctamente un número, que es {salidaNum}");
                    Console.WriteLine("Presione una tecla para salir");
                }
            } while (flag == false);
            Console.ReadKey();
        }

        private static void ValidarIngresoFecha()
        {
            string fecha;
            DateTime salidaFecha;
            bool flag = false;
            do
            {
                Console.WriteLine("Ingrese una fecha");
                fecha = Console.ReadLine();
                if (!DateTime.TryParse(fecha, out salidaFecha))
                {
                    Console.WriteLine("Usted no ha ingresado una fecha");
                }
                else
                {
                    flag = true;
                    Console.WriteLine($"La fecha ingresada es {salidaFecha}");
                    Console.WriteLine("Presione una tecla para salir");
                }
            } while (flag == false) ;
            Console.ReadKey();
        }
    }
}

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
            } while (flag==false);
            Console.ReadKey();
        }
    }
}

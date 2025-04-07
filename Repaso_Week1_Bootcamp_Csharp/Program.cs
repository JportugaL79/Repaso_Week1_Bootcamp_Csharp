using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Week1_Bootcamp_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================");
            Console.WriteLine("DIAS DE LA SEMANA");
            String diaSemana = "Domingo";

            switch (diaSemana)
            {
                case "Lunes":
                    Console.WriteLine("El día es Lunes");
                    break;
                case "Martes":
                    Console.WriteLine("El día es Martes");
                    break;
                case "Miercoles":
                    Console.WriteLine("El día es Miercoles");
                    break;
                case "Jueves":
                    Console.WriteLine("El día es Jueves");
                    break;
                case "Viernes":
                    Console.WriteLine("El día es Viernes");
                    break;
                case "Sabado":
                    Console.WriteLine("El día es Sabado");
                    break;
                default: //"Domingo":
                    Console.WriteLine("El día es Domingo");
                    break;
            }

            Console.WriteLine("Saliendo de la Aplicación");
            Console.WriteLine("====================");

            //Comprobar si un numero es PAR o IMPAR
            int numComprobar;
            Console.WriteLine("===============================");
            Console.WriteLine("Ingresa el valor a comprobar");
            numComprobar = Convert.ToInt32(Console.ReadLine());

            if (numComprobar % 2 == 0)
            {
                Console.WriteLine("El numero es PAR");
            }
            else
            {
                Console.WriteLine("El numero es IMPAR");
            }
        }

    }
}

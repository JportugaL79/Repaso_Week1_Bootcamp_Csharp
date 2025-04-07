using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            /*int numComprobar;
            Console.WriteLine("===============================");
            Console.WriteLine("Ingresa el valor a comprobar");
            Console.WriteLine("===============================");
            numComprobar = Convert.ToInt32(Console.ReadLine());

            if (numComprobar % 2 == 0)
            {
                Console.WriteLine("El numero es PAR");
            }
            else
            {
                Console.WriteLine("El numero es IMPAR");
            }*/

            //Cuál es el número mayor de 3 números
            int primerNumero;
            int segundoNumero;
            int tercerNumero;
            Console.WriteLine("");
            Console.WriteLine("===============================");
            Console.WriteLine("Cuál es el número mayor de 3 números");
            Console.WriteLine("===============================");
            Console.WriteLine("");
            Console.WriteLine("Escribe el 1er número");
            primerNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el 2do número");
            segundoNumero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe el 3er número");
            tercerNumero = Convert.ToInt32(Console.ReadLine());
            if (primerNumero > segundoNumero) 
            {
                if (primerNumero > tercerNumero)
                {
                    Console.WriteLine("El número mayor es el 1er ");
                }
                else 
                {
                    Console.WriteLine("El número mayor es el 3er ");
                }
            }
            else if (segundoNumero > tercerNumero) 
            {
                Console.WriteLine("El número mayor es el 2do ");
            }
            else 
            {
                Console.WriteLine("El número mayor es el 3er ");
            }

                // Obtener área del Circulo y Rectangulo
                String primerArea;
            double Pi = 3.14;
            double radioCirculo;
            double areaCirculo;
            double basee;
            double altura;
            double areaRectangulo;
            Console.WriteLine("");
            Console.WriteLine("===============================");
            Console.WriteLine("Calculando Areas");
            Console.WriteLine("===============================");
            Console.WriteLine("");
            Console.WriteLine("Ingrese el área a trabajar");
            primerArea = Console.ReadLine();
            //segundoArea = Convert.ToInt32(Console.ReadLine());
            //tercerNumero = Convert.ToInt32(Console.ReadLine());
            switch (primerArea)
            {
                case "1": //Círculo
                    Console.WriteLine("Ingrese rádio del Círculo");
                    radioCirculo = Convert.ToInt32(Console.ReadLine());
                    areaCirculo = radioCirculo * Pi;
                    Console.WriteLine("El área del Círculo es: " + areaCirculo);
                    break;
                default: //"Réctangulo":
                    Console.WriteLine("Ingrese Base del Réctangulo");
                    basee = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese Altura del Réctangulo");
                    altura = Convert.ToInt32(Console.ReadLine());
                    areaRectangulo = basee * altura;
                    Console.WriteLine("El área del Réctangulo es: " + areaRectangulo);
                    break;
            }

        }
    }
}
 
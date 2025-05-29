using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Ana María es abuela de 4 niñas de diferentes edades: Ana Paula, Lucía, Milena y Jazmín.
//Desea otorgarles una mensualidad proporcional a las edades de las niñas. El monto total mensual que desea otorgarles depende de sus ingresos.
//Cree una aplicación que tenga el siguiente menú:
//1 - Iniciar Monto a repartir
//2- Solicitar Edad Por niña
//3- Mostrar monto y porcentajes que corresponde a cada niña


namespace Ejercicio_2
{
    class Program
    {
        static int edad1;
        static int edad2;
        static int edad3;
        static int edad4;
        static double montoARepartir;
        static double porcentaje1;
        static double porcentaje2;
        static double porcentaje3;
        static double porcentaje4;
        static double monto1;
        static double monto2;
        static double monto3;
        static double monto4;

        static double RegistrarMontoARepartir(double monto)
        {
            montoARepartir = monto;
            return montoARepartir;
        }

        static int RegistrarEdad(int edad, int niña)
        {
            switch (niña)
            {
                case 1:
                    edad1 = edad;
                    break;
                case 2:
                    edad2 = edad;
                    break;
                case 3:
                    edad3 = edad;
                    break;
                case 4:
                    edad4 = edad;
                    break;
                default:
                    Console.WriteLine("Número de niña inválido.");
                    break;
            }
            return edad;
        }

        static void CalcularMontosYPorcentajePorNiña()
        {
            int sumaEdades = edad1 + edad2 + edad3 + edad4;
            porcentaje1 = (edad1 / (double)(sumaEdades)) * 100;
            porcentaje2 = (edad2 / (double)(sumaEdades)) * 100;
            porcentaje3 = (edad3 / (double)(sumaEdades)) * 100;
            porcentaje4 = (edad4 / (double)(sumaEdades)) * 100;

            monto1 = (porcentaje1 / 100) * montoARepartir;
            monto2 = (porcentaje2 / 100) * montoARepartir;
            monto3 = (porcentaje3 / 100) * montoARepartir;
            monto4 = (porcentaje4 / 100) * montoARepartir;
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opción del menú: \n\n");
            Console.WriteLine("1 - Iniciar Monto a repartir");
            Console.WriteLine("2 - Solicitar Edad Por niña");
            Console.WriteLine("3 - Mostrar monto y porcentajes que corresponde a cada niña");
            Console.WriteLine("0 - Salir");

            int op = Convert.ToInt32(Console.ReadLine());

            return op;
        }

        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.WriteLine("Ingrese el monto total a repartir: \n\n");
            montoARepartir = Convert.ToDouble(Console.ReadLine());
            RegistrarMontoARepartir(montoARepartir);

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            Console.WriteLine("Edades de las niñas: \n\n");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Ingrese la edad de la niña {i + 1}: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                RegistrarEdad(edad, i + 1);
            }
            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            CalcularMontosYPorcentajePorNiña();
            Console.Clear();
            Console.WriteLine("Monto y porcentajes que corresponde a cada niña: \n\n");
            Console.WriteLine($"Ana Paula: {monto1:C} ({porcentaje1:F2}%)");
            Console.WriteLine($"Lucía: {monto2:C} ({porcentaje2:F2}%)");
            Console.WriteLine($"Milena: {monto3:C} ({porcentaje3:F2}%)");
            Console.WriteLine($"Jazmín: {monto4:C} ({porcentaje4:F2}%)");
            Console.WriteLine("\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int op = MostrarPantallaSolicitarOpcionMenu();

            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarMontoARepartir();
                        break;
                    case 2:
                        MostrarPantallaSolicitarEdadesNiñas();
                        break;
                    case 3:
                        MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }
                op = MostrarPantallaSolicitarOpcionMenu();
            }
         
        }

    }
}
 

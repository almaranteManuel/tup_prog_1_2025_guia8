using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dada una serie de números ingresados por el usuario. Implemente una aplicación tal que tenga el siguiente menú:

//1 - Procesar un solo número
//2- Procesar varios números
//3- Mostrar máximo y mínimo.
//4- Mostrar promedio.
//5- Mostrar cantidad de números ingresados.
//6- Reiniciar variables.


namespace Ejercicio_1
{
    class Program
    {
        static int acumulado;
        static int contador;
        static int maximo;
        static int minimo;

        static void RegistrarValor(int valor)
        {
            acumulado = valor;
            contador++;

            if (contador == 1 || valor > maximo)
            {
                maximo = valor;
            }
            if (contador == 1 || valor < minimo)
            {
                minimo = valor;
            }
        }

        static double CalcularPromedio()
        {
            double promedio = 0;
            if (contador > 0)
                promedio = 1.0 * acumulado / contador;
            return promedio;
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opción del menú:");
            Console.WriteLine("1 - Procesar un solo número");
            Console.WriteLine("2 - Procesar varios números");
            Console.WriteLine("3 - Mostrar máximo y mínimo");
            Console.WriteLine("4 - Mostrar promedio");
            Console.WriteLine("5 - Mostrar cantidad de números ingresados");
            Console.WriteLine("6 - Reiniciar variables");
            Console.WriteLine("0 - Salir");

            int op = Convert.ToInt32(Console.ReadLine());

            return op;
        }

        static void MostrarPantallaIniciarVariables()
        {
            Console.Clear();
            Console.WriteLine("Reiniciando las variables\n\n");
            acumulado = 0;
            contador = 0;
            Console.WriteLine("Presione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaSolicitarNumero()
        {
            Console.Clear();
            Console.WriteLine("Ingrese un número:");
            int numero = Convert.ToInt32(Console.ReadLine());
            RegistrarValor(numero);
            Console.WriteLine("Número registrado. Presione una tecla para continuar.");
            Console.ReadKey();
        }

        static void MostrarPantallaSolicitarVariosNumeros()
        {
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de números que quiere ingresar:\n\n ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < cantidad; i++)
            {
                MostrarPantallaSolicitarNumero();
            }
        }

        static void MostrarPantallaMaximoYMinimo()
        {
            Console.Clear();
            Console.WriteLine("Maximo y Minimo:\n\n ");

            Console.WriteLine("Máximo: " + maximo);
            Console.WriteLine("Mínimo: " + minimo);

            Console.WriteLine("Presione una tecla para continuar.");
            Console.ReadKey();
        }

        static void MostrarPantallaCalcularYMostrarPromedio()
        {
            Console.Clear();

            Console.WriteLine("Pantalla de promedio\n\n");

            if (contador > 0)
            {
                Console.WriteLine("Promedio: " + CalcularPromedio());
            }
            else
            {
                Console.WriteLine("Promedio: No se han ingresado números");
            }

            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();
        }
        static void MostrarPantallaCantidad()
        {
            Console.Clear();

            Console.WriteLine("Pantalla de cantidad de valores procesados\n\n");

            if (contador > 0)
            {
                Console.WriteLine("Cantidad: " + contador);
            }
            else
            {
                Console.WriteLine("Cantidad: No se han ingresado números");
            }

            Console.WriteLine("Presione una tecla para volver al menú principal");
            Console.ReadKey();
        }



        static void Main(string[] args)
        {
            MostrarPantallaIniciarVariables();

            int op = MostrarPantallaSolicitarOpcionMenu();

            while (op != 0)
            {
                switch (op)
                {
                    case 1:
                        MostrarPantallaSolicitarNumero();
                        break;
                    case 2:
                        MostrarPantallaSolicitarVariosNumeros();
                        break;
                    case 3:
                        MostrarPantallaMaximoYMinimo();
                        break;
                    case 4:
                        MostrarPantallaCalcularYMostrarPromedio();
                        break;
                    case 5:
                        MostrarPantallaCantidad();
                        break;
                    case 6:
                        MostrarPantallaIniciarVariables();
                        break;
                    default:
                        op = 0;
                        break;
                }
                if (op != 0)
                    op = MostrarPantallaSolicitarOpcionMenu();
            }
        }
    }
}

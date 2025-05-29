using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se ingresa el nombre y Número de libreta de 3 alumnos. Muestre la lista ordenada por Número de libreta de menor a mayor.

//Realice la aplicación de consola con el siguiente menú:
//1 - Registrar las notas de los tres alumnos";
//2- Mostrar lista ordenada";


namespace Ejercicio_3
{
    class Program
    {
        static string nombre0;
        static int nroLibreta0;
        static string nombre1;
        static int nroLibreta1;
        static string nombre2;
        static int nroLibreta2;
        static int orden = 0;

        static void RegistrarNombreYNumeroLibreta(string nombre, int numeroLibreta)
        {
            if (orden == 0)
            {
                nombre0 = nombre;
                nroLibreta0 = numeroLibreta;
            }
            else if (orden == 1)
            {
                if (numeroLibreta < nroLibreta0)
                {
                    nombre1 = nombre0;
                    nroLibreta1 = nroLibreta0;
                    nombre0 = nombre;
                    nroLibreta0 = numeroLibreta;
                }
                else
                {
                    nombre1 = nombre;
                    nroLibreta1 = numeroLibreta;
                }
            }
            else if (orden == 2)
            {
                if (numeroLibreta < nroLibreta0)
                {
                    nombre2 = nombre1;
                    nroLibreta2 = nroLibreta1;
                    nombre1 = nombre0;
                    nroLibreta1 = nroLibreta0;
                    nombre0 = nombre;
                    nroLibreta0 = numeroLibreta;
                }
                if (numeroLibreta < nroLibreta1)
                {
                    nombre2 = nombre1;
                    nroLibreta2 = nroLibreta1;
                    nombre1 = nombre;
                    nroLibreta1 = numeroLibreta;
                }
                else
                {
                    nombre2 = nombre;
                    nroLibreta2 = numeroLibreta;
                }
            }
            orden++;
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Seleccione una opción del menú: \n\n");
            Console.WriteLine("1 - Registrar nombre y número de libreta de los alumnos");
            Console.WriteLine("2 - Mostrar lista ordenada por número de libreta");
            Console.WriteLine("0 - Salir");

            int op = Convert.ToInt32(Console.ReadLine());
            return op;
        }

        static void MostrarPantallaSolicitarAlumnos()
        {
            Console.Clear();
            Console.WriteLine("Ingrese los nombres de alumnos y el numero de libreta de cada uno \n\n");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el nombre del alumno: " + (i + 1) + "\n");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el número de libreta del alumno:");
                int numeroLibreta = Convert.ToInt32(Console.ReadLine());
                RegistrarNombreYNumeroLibreta(nombre, numeroLibreta);
            }

            Console.WriteLine("\n\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }

        static void MostrarPantallaMostrarListaOrdenada()
        {
            Console.Clear();
            Console.WriteLine("Lista de alumnos ordenada por número de libreta: \n\n");
            Console.WriteLine("Alumno 1: " + nombre0 + " - Número de libreta: " + nroLibreta0);
            Console.WriteLine("Alumno 2: " + nombre1 + " - Número de libreta: " + nroLibreta1);
            Console.WriteLine("Alumno 3: " + nombre2 + " - Número de libreta: " + nroLibreta2);
            Console.WriteLine("\n\nPresione una tecla para continuar");
            Console.ReadKey();
        }

        static void Main(string[] args)
        {

            int op = MostrarPantallaSolicitarOpcionMenu();

            while (op != 0)
            {
                switch(op)
                {
                    case 1:
                        MostrarPantallaSolicitarAlumnos();
                        break;
                    case 2:
                        MostrarPantallaMostrarListaOrdenada();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        Console.ReadKey();
                        break;
                }

                op = MostrarPantallaSolicitarOpcionMenu();
            }
        }
    }
}

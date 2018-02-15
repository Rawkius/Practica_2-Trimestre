using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*********************************
Autor: Raúl Vázquez Ramos
Fecha creación:      13/02/2018
Última modificación: 13/02/2018
Versión: 0.04.3
***********************************/

namespace Problema_1
{
    class Program
    {
        static int posX = 0, posY = 0;
        static string nMenu = string.Empty;

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.SetWindowSize(65, 20);
            do
            {
                WriteFrameAt(10, 2, 50, 11, true);
                WriteAt("=== GESTIÓN DE ORDENADORES ===", 16, 3);
                WriteAt("1 - Aulas/Salas del centro.", 12, 5);
                WriteAt("2 - Ordenadores.", 12, 6);
                WriteAt("3 - Búsquedas.", 12, 7);
                WriteAt("4 - Listados.", 12, 8);
                WriteAt("5 - Configuración.", 12, 9);
                WriteAt("----------------------------", 12, 10);
                WriteAt("0 - Salir.", 12, 11);
                WriteAt("Ir a: ", 12, 14);
                nMenu = Console.ReadLine();
                Console.Clear();
            } while (nMenu != "0" && nMenu != "1" && nMenu != "2" && nMenu != "3" && nMenu != "4" && nMenu != "5");
            switch (nMenu)
            {
                case "1":
                    MenuAula();
                    break;
                case "2":
                    MenuOrdenadores();
                    break;
                case "3":
                    MenuBusquedas();
                    break;
                case "4":
                    MenuListados();
                    break;
                case "5":
                    MenuConfiguracion();
                    break;
                default:
                    Exit();
                    break;
            }
        }

        static void MenuAula()
        {
            Console.SetWindowSize(65, 20);
            do
            {
                WriteFrameAt(10, 2, 50, 10, true);
                WriteAt("=== AULAS ===", 24, 3);
                WriteAt("1 - Ver aulas.", 12, 5);
                WriteAt("2 - Añadir aula.", 12, 6);
                WriteAt("3 - Borrar aula.", 12, 7);
                WriteAt("4 - Modificar aula.", 12, 8);
                WriteAt("------------------------------", 12, 9);
                WriteAt("0 - Volver al menú principal.", 12, 10);
                WriteAt("Ir a: ", 12, 13);
                nMenu = Console.ReadLine();
                Console.Clear();
            } while (nMenu != "0" && nMenu != "1" && nMenu != "2" && nMenu != "3" && nMenu != "4");
            switch (nMenu)
            {
                case "1":
                    //();
                    break;
                case "2":
                    //();
                    break;
                case "3":
                    //();
                    break;
                case "4":
                    //();
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void MenuOrdenadores()
        {
            Console.SetWindowSize(65, 20);
            do
            {
                WriteFrameAt(10, 2, 50, 11, true);
                WriteAt("=== ORDENADORES ===", 20, 3);
                WriteAt("1 - Ver lista de ordenadores.", 12, 5);
                WriteAt("2 - Añadir ordenador.", 12, 6);
                WriteAt("3 - Borrar ordenador.", 12, 7);
                WriteAt("4 - Cambiar ordenador de aula.", 12, 8);
                WriteAt("5 - Modificar ordenador.", 12, 9);
                WriteAt("-------------------------------", 12, 10);
                WriteAt("0 - Volver al menú principal.", 12, 11);
                WriteAt("Ir a: ", 12, 14);
                nMenu = Console.ReadLine();
                Console.Clear();
            } while (nMenu != "0" && nMenu != "1" && nMenu != "2" && nMenu != "3" && nMenu != "4" && nMenu != "5");
            switch (nMenu)
            {
                case "1":
                    MenuAula();
                    break;
                case "2":
                    //();
                    break;
                case "3":
                    //();
                    break;
                case "4":
                    //();
                    break;
                case "5":
                    //();
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void MenuBusquedas()
        {
            // Apartado avanzado donde se implementarán búsquedas según mi imaginación.
            Console.SetWindowSize(65, 20);
            do
            {
                WriteFrameAt(10, 2, 50, 7, true);
                WriteAt("=== BÚSQUEDAS ===", 22, 3);
                WriteAt("En construcción...", 12, 5);
                WriteAt("-------------------------------", 12, 6);
                WriteAt("0 - Volver al menú principal.", 12, 7);
                WriteAt("Ir a: ", 12, 10);
                nMenu = Console.ReadLine();
                Console.Clear();
            } while (nMenu != "0");
            switch (nMenu)
            {
                case "1":
                    //();
                    break;
                case "2":
                    //();
                    break;
                case "3":
                    //();
                    break;
                case "4":
                    //();
                    break;
                case "5":
                    //();
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void MenuListados()
        {
            Console.SetWindowSize(92, 20);
            do
            {
                WriteFrameAt(10, 2, 80, 10, true);
                WriteAt("=== Listados ===", 35, 3);
                WriteAt("1 - Nº de ordenadores por aula.", 12, 5);
                WriteAt("2 - Lista de ordenadores ordenados por aula e identificador.", 12, 6);
                WriteAt("3 - Aplicaciones instaladas por cada ordenador.", 12, 7);
                WriteAt("4 - Características de cada ordenador.", 12, 8);
                WriteAt("-------------------------------------------------------------", 12, 9);
                WriteAt("0 - Volver al menú principal.", 12, 10);
                WriteAt("Ir a: ", 12, 13);
                nMenu = Console.ReadLine();
                Console.Clear();
            } while (nMenu != "0" && nMenu != "1" && nMenu != "2" && nMenu != "3" && nMenu != "4");
            switch (nMenu)
            {
                case "1":
                    //();
                    break;
                case "2":
                    //();
                    break;
                case "3":
                    //();
                    break;
                case "4":
                    //();
                    break;
                default:
                    Menu();
                    break;
            }
        }

        static void MenuConfiguracion()
        {
            Console.SetWindowSize(75, 20);
            do
            {
                WriteFrameAt(10, 2, 60, 9, true);
                WriteAt("=== Listados ===", 27, 3);
                WriteAt("1 - Número máximo de aulas.", 12, 5);
                WriteAt("2 - Número máximo de ordenadores por aula.", 12, 6);
                WriteAt("3 - Inicialización automática para pruebas.", 12, 7);
                WriteAt("--------------------------------------------", 12, 8);
                WriteAt("0 - Volver al menú principal.", 12, 9);
                WriteAt("Ir a: ", 12, 12);
                nMenu = Console.ReadLine();
                Console.Clear();
            } while (nMenu != "0" && nMenu != "1" && nMenu != "2" && nMenu != "3");
            switch (nMenu)
            {
                case "1":
                    //();
                    break;
                case "2":
                    //();
                    break;
                case "3":
                    //();
                    break;
                default:
                    Menu();
                    break;
            }
        }

        // Funciones Básicas

        /// <summary>
        /// Función usada para señalar donde se posicionará en cursor.
        /// </summary>
        /// <param name="s">Parámetro que recibirá un string a escribir una vez se posicione el cursor</param>
        /// <param name="x">Posición X (columna) donde se posicionará el cursor</param>
        /// <param name="y">Posición Y (fila) donde se posicionará el cursor</param>
        static void WriteAt(string s, int x, int y)
        {
            Console.SetCursorPosition(posX + x, posY + y);
            Console.Write(s);
        }

        /// <summary>
        /// Función que dibuja un cuadro con los limites que pongamos.
        /// </summary>
        /// <param name="Ix">Inicio de la columna donde va a ir el cuadro</param>
        /// <param name="Iy">Inicio de la fila donde va a ir el cuadro</param>
        /// <param name="Lx">Limite de columnas hasta donde va a llegar el cuadro</param>
        /// <param name="Ly">Limite de filas hasta donde va a llegar el cuadro</param>
        /// <param name="CC">Boleeano que determina si se ejecuta un Console.Clear() antes de escribir el cuadro</param>
        static void WriteFrameAt(int Ix, int Iy, int Lx, int Ly, bool CC)
        {
            if (CC == true)
                Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            WriteAt("╔", Ix, Iy);
            for (int i = (Ix + 1); i < Lx; i++)
                WriteAt("═╗", i, Iy);
            for (int i = (Iy + 1); i < (Ly + 1); i++)
            {
                WriteAt("║", Ix, i); WriteAt("║", Lx, i);
            }
            for (int i = (Ix + 1); i < Lx; i++)
                WriteAt("═╝", i, (Ly + 1));
            WriteAt("╚", Ix, (Ly + 1));
            Console.ForegroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// Función que convierte un numero en string a int si se puede.
        /// </summary>
        /// <param name="x">Posición X (columna) donde se posicionará el cursor</param>
        /// <param name="y">Posición Y (fila) donde se posicionará el cursor</param>
        /// <returns></returns>
        static int LeerStoI(int x, int y)
        {
            int Num = 0;
            do
            {
                try
                {
                    WriteAt(string.Empty, x, y); Num = int.Parse(Console.ReadLine());
                    break;
                }
                catch // Si lo introducido no es un número en su totalidad, se borra y se vuelve a pedir que se escriba un número.
                {
                    WriteAt("          ", x, y); WriteAt(string.Empty, x, y);
                }
            } while (Num < 0 || Num >= 0);
            return Num;
        }

        /// <summary>
        /// Funcion que convierte un numero en string a float si se puede.
        /// </summary>
        /// <param name="x">Posición X (columna) donde se posicionará el cursor</param>
        /// <param name="y">Posición Y (fila) donde se posicionará el cursor</param>
        /// <returns></returns>
        static float LeerStoF(int x, int y)
        {
            float Num = 0;
            do
            {
                try
                {
                    WriteAt(string.Empty, x, y); Num = float.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    WriteAt("          ", x, y); WriteAt(string.Empty, x, y); // Si lo introducido no es un número en su totalidad, se borra y se vuelve a pedir que se escriba un número.
                }
            } while (Num < 0 || Num >= 0);
            return Num;
        }

        static void Exit()
        {
            WriteAt("Adioooooooooos", 12, 3);
        }
    }
}

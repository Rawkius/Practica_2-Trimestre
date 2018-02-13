using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*********************************
Autor: Raúl Vázquez Ramos
Fecha creación:      13/02/2018
Última modificación: 13/02/2018
Versión: x.xx
***********************************/

namespace Problema_1
{
    class Program
    {
        static int posX = 0, posY = 0;

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            string nMenu = string.Empty;
            do
            {
                WriteFrameAt(10, 2, 70, 11, true);
                WriteAt("=== GESTIÓN DE ORDENADORES ===", 27, 3);
                WriteAt("1 - Aulas/Salas del centro.", 12, 5);
                WriteAt("2 - Ordenadores.", 12, 6);
                WriteAt("3 - Búsquedas.", 12, 7);
                WriteAt("4 - Listados.", 12, 8);
                WriteAt("5 - Configuración.", 12, 9);
                WriteAt("-----------------------------", 12, 10);
                WriteAt("0 - Salir.", 12, 11);
                WriteAt("Ir a:", 12, 14);
            } while (nMenu != "0" && nMenu != "1" && nMenu != "2" && nMenu != "3" && nMenu != "4" && nMenu != "5");
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
                    //();
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
    }
}

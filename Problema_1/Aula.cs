using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*********************************
Autor: Raúl Vázquez Ramos
Fecha creación:      13/02/2018
Última modificación: 13/02/2018
Versión: 0.02.0
***********************************/

namespace Problema_1
{
    class Aula
    {
        int Id; // Número que identifíca al aula.
        string Nombre; // Nombre del aula.


        public int sId
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }

        public string sNombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }
    }
}

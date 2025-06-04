using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Loteria
{
    public class VentaMensual : Venta
    {
        public int Posicion { get; set; }

        public VentaMensual(string nombre, int posicion)
        {
            NombreCliente = nombre;
            Posicion = posicion;
        }
    }
}

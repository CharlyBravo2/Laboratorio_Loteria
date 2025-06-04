using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Loteria
{
    public class VentaMensual : Venta
    {
        public int Posicion { get; private set; }

        public VentaMensual(string nombre, int posicion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del cliente no puede estar vacío.");

            NombreCliente = nombre;
            Posicion = posicion;
        }
    }
}

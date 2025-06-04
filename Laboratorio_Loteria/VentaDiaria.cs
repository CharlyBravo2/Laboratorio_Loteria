using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Loteria
{
    public class VentaDiaria : Venta
    {
        public int[] Numeros { get; private set; }

        public VentaDiaria(string nombre, int[] numeros)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                throw new ArgumentException("El nombre del cliente no puede estar vacío.");

            NombreCliente = nombre;
            Numeros = numeros ?? throw new ArgumentNullException(nameof(numeros));
        }
    }
}

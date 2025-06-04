using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Loteria
{
    public class VentaDiaria : Venta
    {
        public int[] Numeros { get; set; } = new int[5];

        public VentaDiaria(string nombre, int[] numeros)
        {
            if (numeros.Length != 5)
                throw new ArgumentException("Deben ser exactamente 5 números");

            NombreCliente = nombre;
            Numeros = numeros;
        }
    }
}

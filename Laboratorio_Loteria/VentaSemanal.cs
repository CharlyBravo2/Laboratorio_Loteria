using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Loteria
{
    public class VentaSemanal : Venta
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }

        public VentaSemanal(string nombre, int num1, int num2)
        {
            NombreCliente = nombre;
            Numero1 = num1;
            Numero2 = num2;
        }
    }
}

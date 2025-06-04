using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Loteria
{
    public class JuegoSemanal
    {
        private List<VentaSemanal> ventas = new List<VentaSemanal>();
        private HashSet<string> clientesRegistrados = new HashSet<string>();

        public void AgregarVenta(VentaSemanal venta)
        {
            if (clientesRegistrados.Contains(venta.NombreCliente.ToLower()))
            {
                throw new ArgumentException($"El cliente {venta.NombreCliente} ya tiene una venta registrada.");
            }
            ventas.Add(venta);
            clientesRegistrados.Add(venta.NombreCliente.ToLower());
        }

        public List<(string nombre, decimal premio)> RealizarSorteo()
        {
            Random rnd = new Random();
            int numero1 = rnd.Next(0, 101);
            int numero2 = rnd.Next(0, 101);

            var ganadores = new List<(string, decimal)>();

            foreach (var venta in ventas)
            {
                bool ganoPrimero = venta.Numero1 == numero1;
                bool ganoSegundo = venta.Numero2 == numero2;
                decimal premio = 0;

                if (ganoPrimero && ganoSegundo) premio = 100000;
                else if (ganoPrimero) premio = 10000;
                else if (ganoSegundo) premio = 1000;

                if (premio > 0)
                {
                    ganadores.Add((venta.NombreCliente, premio));
                }
            }

            return ganadores;
        }
    }
}

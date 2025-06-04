using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Loteria
{
    public class JuegoDiario
    {
        private List<VentaDiaria> ventas = new List<VentaDiaria>();
        private HashSet<string> clientesRegistrados = new HashSet<string>();

        public void AgregarVenta(VentaDiaria venta)
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
            int[] numerosGanadores = new int[5];
            for (int i = 0; i < 5; i++)
            {
                numerosGanadores[i] = rnd.Next(0, 101);
            }

            var ganadores = new List<(string, decimal)>();

            foreach (var venta in ventas)
            {
                int coincidencias = 0;
                foreach (var num in venta.Numeros)
                {
                    if (Array.IndexOf(numerosGanadores, num) >= 0)
                    {
                        coincidencias++;
                    }
                }

                decimal premio = 0;
                if (coincidencias == 3) premio = 5000;
                else if (coincidencias == 4) premio = 10000;
                else if (coincidencias == 5) premio = 100000;

                if (premio > 0)
                {
                    ganadores.Add((venta.NombreCliente, premio));
                }
            }

            return ganadores;
        }
    }
}

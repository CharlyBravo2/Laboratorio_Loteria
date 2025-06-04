using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_Loteria
{
    public class JuegoMensual
    {
        private Dictionary<int, VentaMensual> ventas = new Dictionary<int, VentaMensual>();
        private HashSet<string> clientesRegistrados = new HashSet<string>();

        public void AgregarVenta(VentaMensual venta)
        {
            if (ventas.ContainsKey(venta.Posicion))
            {
                throw new ArgumentException("Esta posición ya está ocupada");
            }
            if (clientesRegistrados.Contains(venta.NombreCliente.ToLower()))
            {
                throw new ArgumentException($"El cliente {venta.NombreCliente} ya tiene una venta registrada.");
            }
            ventas.Add(venta.Posicion, venta);
            clientesRegistrados.Add(venta.NombreCliente.ToLower());
        }

        public List<(string nombre, decimal premio)> RealizarSorteo()
        {
            Random rnd = new Random();
            int numeroGanador = rnd.Next(0, 101);

            var ganadores = new List<(string, decimal)>();

            if (ventas.TryGetValue(numeroGanador, out VentaMensual venta))
            {
                ganadores.Add((venta.NombreCliente, 10000));
            }

            return ganadores;
        }
    }
}


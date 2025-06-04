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

        public void AgregarVenta(VentaMensual venta)
        {
            if (ventas.ContainsKey(venta.Posicion))
            {
                throw new ArgumentException("Esta posición ya está ocupada");
            }
            ventas.Add(venta.Posicion, venta);
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


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_Loteria
{
    public partial class Form1 : Form
    {
        private JuegoDiario juegoDiario = new JuegoDiario();
        private JuegoSemanal juegoSemanal = new JuegoSemanal();
        private JuegoMensual juegoMensual = new JuegoMensual();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnVenderDiario_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreDiario.Text.Trim();
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Por favor ingrese el nombre del cliente.");
                    return;
                }

                List<int> numeros = new List<int>();
                if (!int.TryParse(txtNumero1Diario.Text, out int num1) || num1 < 0 || num1 > 100)
                {
                    MessageBox.Show("Número 1 inválido. Debe ser entre 0 y 100.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("El nombre solo puede contener letras.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombreDiario.Focus();
                    return;
                }
                numeros.Add(num1);

                if (!int.TryParse(txtNumero2Diario.Text, out int num2) || num2 < 0 || num2 > 100)
                {
                    MessageBox.Show("Número 2 inválido. Debe ser entre 0 y 100.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                numeros.Add(num2);

                if (!int.TryParse(txtNumero3Diario.Text, out int num3) || num3 < 0 || num3 > 100)
                {
                    MessageBox.Show("Número 3 inválido. Debe ser entre 0 y 100.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                numeros.Add(num3);

                if (!int.TryParse(txtNumero4Diario.Text, out int num4) || num4 < 0 || num4 > 100)
                {
                    MessageBox.Show("Número 4 inválido. Debe ser entre 0 y 100.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                numeros.Add(num4);

                if (!int.TryParse(txtNumero5Diario.Text, out int num5) || num5 < 0 || num5 > 100)
                {
                    MessageBox.Show("Número 5 inválido. Debe ser entre 0 y 100.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                numeros.Add(num5);

               
                HashSet<int> numerosUnicos = new HashSet<int>(numeros);
                if (numerosUnicos.Count < 5)
                {
                    MessageBox.Show("No se permiten números repetidos en la misma venta.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                VentaDiaria venta = new VentaDiaria(nombre, numeros.ToArray());
                juegoDiario.AgregarVenta(venta);

                MessageBox.Show("Venta diaria registrada con éxito!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControlesDiario();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnVenderSemanal_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreSemanal.Text.Trim();
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Por favor ingrese el nombre del cliente.");
                    return;
                }


                if (!System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("El nombre solo puede contener letras.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombreSemanal.Focus();
                    return;
                }

                    if (!int.TryParse(txtNumero1Semanal.Text, out int num1) || num1 < 0 || num1 > 100)
                {
                    MessageBox.Show("Número 1 inválido. Debe ser entre 0 y 100.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!int.TryParse(txtNumero2Semanal.Text, out int num2) || num2 < 0 || num2 > 100)
                {
                    MessageBox.Show("Número 2 inválido. Debe ser entre 0 y 100.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (num1 == num2)
                {
                    MessageBox.Show("Los números no pueden ser iguales.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                VentaSemanal venta = new VentaSemanal(nombre, num1, num2);
                juegoSemanal.AgregarVenta(venta);

                MessageBox.Show("Venta semanal registrada con éxito!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControlesSemanal();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnVenderMensual_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombreMensual.Text.Trim();
                if (string.IsNullOrEmpty(nombre))
                {
                    MessageBox.Show("Por favor ingrese el nombre del cliente.");
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("El nombre solo puede contener letras.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNombreMensual.Focus();
                    return;
                }

                    if (!int.TryParse(txtNumeroMensual.Text, out int numero) || numero < 0 || numero > 100)
                {
                    MessageBox.Show("Número inválido. Debe ser entre 0 y 100.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                VentaMensual venta = new VentaMensual(nombre, numero);
                juegoMensual.AgregarVenta(venta);

                MessageBox.Show("Venta mensual registrada con éxito!", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarControlesMensual();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnJugarDiario_Click(object sender, EventArgs e)
        {
            try
            {
                lstGanadoresDiario.Items.Clear();
                var ganadores = juegoDiario.RealizarSorteo();

                if (ganadores.Count == 0)
                {
                    MessageBox.Show("No hubo ganadores en esta ronda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lstGanadoresDiario.Items.Add("No hubo ganadores en esta ronda.");
                    return;
                }

                foreach (var ganador in ganadores)
                {
                    lstGanadoresDiario.Items.Add($"{ganador.nombre} - Premio: L.{ganador.premio:N2}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnJugarSemanal_Click(object sender, EventArgs e)
        {
            try
            {
                lstGanadoresSemanal.Items.Clear();
                var ganadores = juegoSemanal.RealizarSorteo();

                if (ganadores.Count == 0)
                {
                    MessageBox.Show("No hubo ganadores en esta ronda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lstGanadoresSemanal.Items.Add("No hubo ganadores en esta ronda.");
                    return;
                }

                foreach (var ganador in ganadores)
                {
                    lstGanadoresSemanal.Items.Add($"{ganador.nombre} - Premio: L.{ganador.premio:N2}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnJugarMensual_Click(object sender, EventArgs e)
        {
            try
            {
                lstGanadoresMensual.Items.Clear();
                var ganadores = juegoMensual.RealizarSorteo();

                if (ganadores.Count == 0)
                {
                    MessageBox.Show("No hubo ganadores en esta ronda.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lstGanadoresMensual.Items.Add("No hubo ganadores en esta ronda.");
                    return;
                }

                foreach (var ganador in ganadores)
                {
                    lstGanadoresMensual.Items.Add($"{ganador.nombre} - Premio: L.{ganador.premio:N2}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LimpiarControlesDiario()
        {
            txtNombreDiario.Clear();
            txtNumero1Diario.Clear();
            txtNumero2Diario.Clear();
            txtNumero3Diario.Clear();
            txtNumero4Diario.Clear();
            txtNumero5Diario.Clear();
        }

        private void LimpiarControlesSemanal()
        {
            txtNombreSemanal.Clear();
            txtNumero1Semanal.Clear();
            txtNumero2Semanal.Clear();
        }

        private void LimpiarControlesMensual()
        {
            txtNombreMensual.Clear();
            txtNumeroMensual.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

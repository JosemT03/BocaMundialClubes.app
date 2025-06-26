using BocaMundialClubesForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace BocaMundialClubesForms
{
    public partial class FormComprarEntrada : Form
    {
        private readonly Partido _partido;
        private readonly HttpClient _client;
        private List<Entrada> _entradasDelPartido;

        public FormComprarEntrada(Partido partido)
        {
            InitializeComponent();
            _partido = partido;

            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7060/api/");
            this.Load += FormComprarEntrada_Load;
        }

        private void FormComprarEntrada_Load(object sender, EventArgs e)
        {
            
            _entradasDelPartido = new List<Entrada>
            {
                new Entrada { Id = 1, PartidoId = _partido.Id, Tipo = "General", Precio = 5000 },
                new Entrada { Id = 2, PartidoId = _partido.Id, Tipo = "Platea", Precio = 9000 },
                new Entrada { Id = 3, PartidoId = _partido.Id, Tipo = "VIP", Precio = 15000 },
                new Entrada { Id = 4, PartidoId = _partido.Id, Tipo = "Popular", Precio = 4000 }
            };

            cmbTipoEntrada.DataSource = _entradasDelPartido;
            cmbTipoEntrada.DisplayMember = "Tipo";
            cmbTipoEntrada.ValueMember = "Id";
            dgvPrecios.AutoGenerateColumns = true;
            dgvPrecios.DataSource = _entradasDelPartido;
        }

        private async void btnComprar_Click(object sender, EventArgs e)
        {
            var entradaSeleccionada = cmbTipoEntrada.SelectedItem as Entrada;
            if (entradaSeleccionada == null)
            {
                MessageBox.Show("Seleccioná un tipo de entrada.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingresá tu nombre.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text) || !long.TryParse(txtTelefono.Text, out _))
            {
                MessageBox.Show("Ingresá un número de teléfono válido.");
                return;
            }

            var venta = new
            {
                PartidoId = _partido.Id,
                TipoEntrada = entradaSeleccionada.Tipo,
                NombreComprador = txtNombre.Text,
                TelefonoComprador = txtTelefono.Text,
                Precio = entradaSeleccionada.Precio
            };

            try
            {
                var response = await _client.PostAsJsonAsync("ventas", venta);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Compra registrada con éxito.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar la venta.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message);
            }
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;

namespace BocaMundialClubesForms
{
    public partial class FormInformeVentas : Form
    {
        private readonly HttpClient _client;
        private BindingList<Venta> _ventas;

        public FormInformeVentas()
        {
            InitializeComponent();

            
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7060/api/");

            
            this.Load += FormInformeVentas_Load;
        }

        private async void FormInformeVentas_Load(object sender, EventArgs e)
        {
            
            foreach (DataGridViewColumn col in dgvVentas.Columns)
            {
                if (col.Name == "NombreComprador" || col.Name == "TelefonoComprador")
                    col.ReadOnly = false;
                else
                    col.ReadOnly = true;
            }

            try
            {


                var lista = await _client.GetFromJsonAsync<List<Venta>>("ventas");
                _ventas = new BindingList<Venta>(lista);
                dgvVentas.DataSource = _ventas;
                dgvVentas.AutoGenerateColumns = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el informe de ventas: " + ex.Message);
            }
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow?.DataBoundItem is Venta ventaEditada)
            {
                try
                {
                    var response = await _client.PutAsJsonAsync($"ventas/{ventaEditada.Id}", ventaEditada);
                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Venta actualizada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la venta.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }

        private  async void btnBorrar_Click(object sender, EventArgs e)
        {
            if (dgvVentas.CurrentRow?.DataBoundItem is Venta ventaSeleccionada)
            {
                var confirmar = MessageBox.Show("¿Estás seguro de borrar esta venta?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirmar == DialogResult.Yes)
                {
                    try
                    {
                        var response = await _client.DeleteAsync($"ventas/{ventaSeleccionada.Id}");
                        if (response.IsSuccessStatusCode)
                        {
                            _ventas.Remove(ventaSeleccionada);

                            MessageBox.Show("Venta eliminada.");
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar la venta.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
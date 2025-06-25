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

        public FormInformeVentas()
        {
            InitializeComponent();

            // Crear cliente y base de API
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7060/api/");

            // Conectar el evento Load correctamente
            this.Load += FormInformeVentas_Load;
        }

        private async void FormInformeVentas_Load(object sender, EventArgs e)
        {
            try
            {
                // Obtener ventas desde la API
                List<Venta> ventas = await _client.GetFromJsonAsync<List<Venta>>("ventas");

                // Mostrar en la grilla
                dgvVentas.AutoGenerateColumns = true;
                dgvVentas.DataSource = ventas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el informe de ventas: " + ex.Message);
            }
        }
    }
}
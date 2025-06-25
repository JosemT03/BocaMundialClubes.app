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
using BocaMundialClubesForms.Models;
using System.Net.Http.Json;

namespace BocaMundialClubesForms
{
    public partial class FormEntradasDisponibles : Form
    {
        private List<Partido> _partidos;
        private readonly HttpClient _client;

        public FormEntradasDisponibles()
        {
            InitializeComponent();
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:7060/api/");
            this.Load += FormEntradasDisponibles_Load;
            dgvEntradas.SelectionChanged += dgvEntradas_SelectionChanged;
        }

        private async void FormEntradasDisponibles_Load(object sender, EventArgs e)
        {
            try
            {
                _partidos = await _client.GetFromJsonAsync<List<Partido>>("partidos");
                dgvEntradas.AutoGenerateColumns = true;
                dgvEntradas.DataSource = _partidos;

                btnComprarEntrada.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los partidos: " + ex.Message);
            }
        }

        private void dgvEntradas_SelectionChanged(object sender, EventArgs e)
        {
            btnComprarEntrada.Enabled = dgvEntradas.SelectedRows.Count > 0;
        }

        private void btnComprarEntrada_Click(object sender, EventArgs e)
        {
            if (dgvEntradas.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccioná un partido para continuar.");
                return;
            }

            var partidoSeleccionado = (Partido)dgvEntradas.SelectedRows[0].DataBoundItem;
            var form = new FormComprarEntrada(partidoSeleccionado);
            form.ShowDialog();
        }

        private void btnInformeVentas_Click(object sender, EventArgs e)
        {
            var form = new FormInformeVentas();
            form.ShowDialog();
        }
    }
}



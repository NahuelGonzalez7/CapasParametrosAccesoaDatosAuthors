using Datos.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsPubs
{
    public partial class frmPublisher : Form
    {
        public frmPublisher()
        {
            InitializeComponent();
        }

        private void frmPublisher_Load(object sender, EventArgs e)
        {
            mostrarPublishers();
        }

        private void mostrarPublishers()
        {
            gridListPublishers.DataSource = AdminPublisher.listarPublishers();
        }

        private void btnTraerPorCiudad_Click(object sender, EventArgs e)
        {
            string cityBusqueda = txtCity.Text;
            gridListPublishers.DataSource = AdminPublisher.listarPublishers(cityBusqueda);
        }

        private void btnTraerPorCiudadyEstado_Click(object sender, EventArgs e)
        {
            string stateBusqueda = txtCityState.Text;
            gridListPublishers.DataSource = AdminPublisher.listarPublishers(txtCity.Text, stateBusqueda);
        }

        private void btnTraerPorCiudadEstadoPais_Click(object sender, EventArgs e)
        {
            string countryBusqueda = txtCityStateCountry.Text;
            gridListPublishers.DataSource = AdminPublisher.listarPublishers(txtCity.Text, txtCityState.Text, countryBusqueda);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            mostrarPublishers();
        }
    }
}

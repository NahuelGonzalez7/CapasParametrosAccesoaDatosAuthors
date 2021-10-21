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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarAuthors();
        }

        private void mostrarAuthors()
        {
            gridListAuthor.DataSource = AdmAuthor.listarAuthors();
        }

        private void btnTraerPorCiudad_Click(object sender, EventArgs e)
        {
            string cityBusqueda = txtTraerPorCiudad.Text;
            gridListAuthor.DataSource = AdmAuthor.listarAuthors(cityBusqueda);
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            mostrarAuthors();
        }

        private void btnTraerCityState_Click(object sender, EventArgs e)
        {
            string cityBusqueda = txtBusquedaCityState.Text;
            string stateBusqueda = txtBusquedaStateCity.Text;

            gridListAuthor.DataSource = AdmAuthor.listarAuthors(cityBusqueda, stateBusqueda);
        }
    }
}

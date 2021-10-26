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
            llenarComboCategoria();
        }

        private void llenarComboCategoria()
        {
            DataTable author = AdmAuthor.listarSoloCiudades();

            cbCiudad.DataSource = author;
            cbCiudad.DisplayMember = author.Columns["city"].ToString();
            cbCiudad.ValueMember = author.Columns["city"].ToString();

            // Agregar una fila al DataTable "Author" en memoria

            DataRow fila = author.NewRow();
            fila["city"] = 0;
            fila["city"] = "TODAS";
            author.Rows.Add(fila);
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

        private void cbCiudad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // El selectedValueCaptura la ciudad de "ValueMember"

            string city = Convert.ToString(cbCiudad.SelectedValue);

            if (city == "TODAS")
            {
                mostrarAuthors();
            }
            else
            {
                gridListAuthor.DataSource = AdmAuthor.listarDataTable(city);
            }
        }

    }
}

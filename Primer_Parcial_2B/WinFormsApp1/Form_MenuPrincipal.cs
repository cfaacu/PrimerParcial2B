using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Form_MenuPrincipal : Form
    {
        public Form_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ABM_Productos form_Productos = new Form_ABM_Productos("alta");
            form_Productos.ShowDialog();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Listado form_Listado = new Form_Listado("productos");
            form_Listado.ShowDialog();
        }

        private void bajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ABM_Productos form_Productos = new Form_ABM_Productos("baja");
            form_Productos.ShowDialog();
        }

        private void modificacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ABM_Productos form_Productos = new Form_ABM_Productos("modificar");
            form_Productos.ShowDialog();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_ABM_Clientes form_Clientes = new Form_ABM_Clientes("alta");
            form_Clientes.ShowDialog();
        }

        private void bajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_ABM_Clientes form_Clientes = new Form_ABM_Clientes("baja");
            form_Clientes.ShowDialog();
        }

        private void modificacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_ABM_Clientes form_Clientes = new Form_ABM_Clientes("modificar");
            form_Clientes.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Listado form_Listado = new Form_Listado("clientes");
            form_Listado.ShowDialog();
        }

        private void generarVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Ventas form_Ventas = new Form_Ventas();
            form_Ventas.ShowDialog();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AltaReparacion form_AltaReparacion = new Form_AltaReparacion();
            form_AltaReparacion.ShowDialog();
        }

        private void listarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Listado form_Listado = new Form_Listado("reparacion");
            form_Listado.ShowDialog();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ModificarReparacion form_modificarReparacion = new Form_ModificarReparacion();
            form_modificarReparacion.ShowDialog();
        }
    }
}

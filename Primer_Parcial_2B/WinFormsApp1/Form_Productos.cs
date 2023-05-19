using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class Form_Productos : Form
    {
        public Form_Productos()
        {
            InitializeComponent();
        }

        private void Form_Productos_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
        }

        private void LlenarDataGridView()
        {
            foreach (Producto producto in Sistema.listaProductos)
            {
                int n = dtg_ListadoProductos.Rows.Add();

                dtg_ListadoProductos.Rows[n].Cells[0].Value = producto.Codigo;
                dtg_ListadoProductos.Rows[n].Cells[1].Value = producto.Nombre;
                dtg_ListadoProductos.Rows[n].Cells[2].Value = producto.Categoria;
                dtg_ListadoProductos.Rows[n].Cells[3].Value = producto.Cantidad;
                dtg_ListadoProductos.Rows[n].Cells[4].Value = producto.PrecioVenta;
                dtg_ListadoProductos.Rows[n].Cells[5].Value = producto.PrecioCompra;
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Form_AMProducto form_Modificar = new Form_AMProducto(null, "Alta");
            form_Modificar.ShowDialog();
            dtg_ListadoProductos.Rows.Clear();
            LlenarDataGridView();
        }

        private void dtg_ListadoProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string? codigo = this.dtg_ListadoProductos.CurrentRow.Cells["Codigo"].Value.ToString();
            if (dtg_ListadoProductos.Columns[e.ColumnIndex].Name == "Modificar")
            {
                Form_AMProducto form_Modificar = new Form_AMProducto(codigo, "Modificar");
                form_Modificar.ShowDialog();
            }
            if (dtg_ListadoProductos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult dg = MessageBox.Show("Desea eliminar el producto?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dg == DialogResult.Yes)
                {
                    Sistema.EliminarProducto(codigo);
                }
            }
            dtg_ListadoProductos.Rows.Clear();
            LlenarDataGridView();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

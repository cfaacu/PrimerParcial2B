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
using Entidades.Archivos;

namespace Formularios
{
    public partial class Form_Productos : Form
    {
        ProductoDB dbProductoService;
        Producto producto;
        List<Producto> productos;
        ArchivoTexto archivo;
        public Form_Productos()
        {
            InitializeComponent();
            dbProductoService = new ProductoDB();
            productos = new List<Producto>();
            archivo = new ArchivoTexto();
        }

        private void Form_Productos_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
        }

        private void LlenarDataGridView()
        {
            try
            {
                productos = dbProductoService.TraerTodo();
                productos.Sort((p1, p2) => string.Compare(p1.Codigo, p2.Codigo));
                foreach (Producto producto in productos)
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
            catch (Exception ex)
            {
                archivo.LogErrores(ex);
                MessageBox.Show("Error al traer los productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Form_AMProducto form_Modificar = new Form_AMProducto(null, "Alta");
            form_Modificar.Pasaje += (producto) => { producto.Agregar(); };
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
                form_Modificar.Pasaje += (producto) => { producto.Modificar(producto); };
                form_Modificar.ShowDialog();
            }
            if (dtg_ListadoProductos.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult dg = MessageBox.Show("Desea eliminar el producto?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        producto = dbProductoService.Traer(codigo);
                        producto.Borrar();
                    }
                    catch (Exception ex)
                    {
                        archivo.LogErrores(ex);
                        MessageBox.Show("Error al eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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

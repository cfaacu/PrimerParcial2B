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
using Entidades.DB_SQL;

namespace Formularios
{
    public partial class Form_DetalleVenta : Form
    {
        VentaDB dbVentaService;
        Venta venta;
        ArchivoTexto archivo;
        public Form_DetalleVenta(Venta venta)
        {
            InitializeComponent();
            dbVentaService = new VentaDB();
            this.venta = venta;
            archivo = new ArchivoTexto();
        }

        private void Form_DetalleVenta_Load(object sender, EventArgs e)
        {
            this.lbl_NumeroVenta.Text = venta.IdVenta.ToString();

            LlenarDataGrid();
        }

        private void LlenarDataGrid()
        {
            dtg_Listado.Columns.Add("Codigo", "CODIGO");
            dtg_Listado.Columns.Add("Nombre", "NOMBRE");
            dtg_Listado.Columns.Add("Cantidad", "CANTIDAD");
            dtg_Listado.Columns.Add("PrecioVenta", "PRECIO DE VENTA");
            dtg_Listado.Columns.Add("PrecioCompra", "PRECIO DE COMPRA");
            dtg_Listado.Columns.Add("Ganancia", "GANANCIA");

            try
            {
                foreach (ProductoVenta detalle in venta.Detalle)
                {
                    int n = dtg_Listado.Rows.Add();

                    dtg_Listado.Rows[n].Cells[0].Value = detalle.Producto.Codigo;
                    dtg_Listado.Rows[n].Cells[1].Value = detalle.Producto.Nombre;
                    dtg_Listado.Rows[n].Cells[2].Value = detalle.Producto.Cantidad;
                    dtg_Listado.Rows[n].Cells[3].Value = detalle.Producto.PrecioVenta;
                    dtg_Listado.Rows[n].Cells[4].Value = detalle.Producto.PrecioCompra;
                    dtg_Listado.Rows[n].Cells[5].Value = Math.Round((detalle.Producto.PrecioVenta) - (detalle.Producto.PrecioCompra),2);
                }
            }
            catch (Exception ex)
            {
                archivo.LogErrores(ex);
                MessageBox.Show("ERROR al cargar las VENTAS", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

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
    public partial class Form_Ventas : Form
    {
        private Stack<Producto> carrito;
        private double precioTotal = 0;
        Cliente cliente;
        public Form_Ventas()
        {
            InitializeComponent();
            carrito = new Stack<Producto>();
        }

        private void Form_Ventas_Load(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {  
            Producto producto = Sistema.BuscarProducto(this.txt_Codigo.Text);
            if (producto != null)
            {
                int n = dtg_Productos.Rows.Add();
                if (Sistema.RestarStock(producto, this.txt_Cantidad.Text))
                {
                    dtg_Productos.Rows[n].Cells[0].Value = producto.Codigo;
                    dtg_Productos.Rows[n].Cells[1].Value = producto.Nombre;
                    dtg_Productos.Rows[n].Cells[2].Value = this.txt_Cantidad.Text;
                    dtg_Productos.Rows[n].Cells[3].Value = producto.PrecioVenta;
                    carrito.Push(producto);
                    if (CalcularPrecioTotal(producto, this.txt_Cantidad.Text))
                    {
                        this.Lbl_PrecioTotal.Text = $" ${this.precioTotal.ToString()}";
                    }
                }
                else
                {
                    dtg_Productos.Rows.RemoveAt(n);
                    MessageBox.Show("Error sin stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error codigo invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.txt_Cantidad.Text = string.Empty;
            this.txt_Codigo.Text = string.Empty;
        }
        private bool CalcularPrecioTotal(Producto producto, string cantidad)
        {
            double precio = 0;
            if (int.TryParse(cantidad, out int cantidadInt))
            {
                precio = producto.PrecioVenta * cantidadInt;
                this.precioTotal = precioTotal + precio;
                return true;
            }
            return false;
        }
        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (cliente != null)
            {
                Venta venta = new Venta(this.cliente, this.carrito, this.precioTotal);
                Sistema.listaVentas.Add(venta);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error ingrese un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Listar_Click(object sender, EventArgs e)
        {
            Form_Clientes form_Clientes = new Form_Clientes();
            form_Clientes.ShowDialog();
        }

        private void btn_Buscar_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txt_DNI.Text))
            {
                cliente = Sistema.BuscarCliente(this.txt_DNI.Text);
                if (cliente != null)
                {
                    this.txt_Nombre.Text = cliente.Nombre;
                }
                else
                {
                    MessageBox.Show("Error DNI invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error ingrese un DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ListarProducto_Click(object sender, EventArgs e)
        {
            Form_Productos form_Productos = new Form_Productos();
            form_Productos.ShowDialog();
        }
    }
}

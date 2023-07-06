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
    public partial class Form_Ventas : Form
    {
        private Stack<ProductoVenta> carrito;
        private double precioTotal = 0;
        Cliente cliente;
        Venta venta;
        VentaDB ventasService;
        Producto prod;
        ArchivoTexto archivo;
        ClienteDB clienteService;
        public Form_Ventas()
        {
            InitializeComponent();
            carrito = new Stack<ProductoVenta>();
            venta = new Venta();
            clienteService = new ClienteDB();
            ventasService = new VentaDB();
            prod = new Producto();
            cliente = new Cliente();
            archivo = new ArchivoTexto();
        }

        private void Form_Ventas_Load(object sender, EventArgs e)
        {
            venta.TicketGenerado += (() =>
            {
                MessageBox.Show("Ticket Generado Con Exito!");
            });
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                var productito = new ProductoVenta
                {
                    Cantidad = int.Parse(this.txt_Cantidad.Text),
                    Producto = prod.BuscarProducto(this.txt_Codigo.Text)
                };

                if (productito.Producto != null)
                {
                    int n = dtg_Productos.Rows.Add();
                    if (Validaciones.ValidarProducto(productito))
                    {
                        dtg_Productos.Rows[n].Cells[0].Value = productito.Producto.Codigo;
                        dtg_Productos.Rows[n].Cells[1].Value = productito.Producto.Nombre;
                        dtg_Productos.Rows[n].Cells[2].Value = productito.Cantidad;
                        dtg_Productos.Rows[n].Cells[3].Value = productito.Producto.PrecioVenta;
                        carrito.Push(productito);
                        if (CalcularPrecioTotal(productito.Producto, this.txt_Cantidad.Text))
                        {
                            this.Lbl_PrecioTotal.Text = $" ${this.precioTotal}";
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
            catch (Exception ex)
            {
                archivo.LogErrores(ex);
                MessageBox.Show("Error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
        private async void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.carrito.Count <= 0)
                {
                    MessageBox.Show("ERROR venta vacia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult resultado = MessageBox.Show("¿Desea confirmar la venta?", "Confirmación de venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        this.venta.IdVenta = Guid.NewGuid();
                        this.venta.Detalle = this.carrito.ToList();
                        this.venta.Cliente = clienteService.Traer(this.txt_DNI.Text);
                        this.venta.Fecha = DateTime.Now;
                        this.venta.PrecioTotal = this.precioTotal;
                        await ventasService.Agregar(venta);
                        venta.GenerarTicket();
                        this.Close();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                archivo.LogErrores(ex);
                MessageBox.Show("Error al generar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cliente = cliente.BuscarCliente(this.txt_DNI.Text);
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

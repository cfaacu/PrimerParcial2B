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
using Google.Protobuf.Collections;

namespace Formularios
{
    public partial class Form_Listado : Form
    {
        private string modo;
        static ProductoDB dbProdService;
        static ClienteDB dbClientService;
        static VentaDB dbVentaService;
        static ReparacionesDB dbReparacionService;
        static EmpleadoDB dbEmpleadoService;
        private Venta venta;
        private ArchivoTexto archivo;
        public Form_Listado(string modo)
        {
            InitializeComponent();
            this.modo = modo;
            dbProdService = new ProductoDB();
            dbClientService = new ClienteDB();
            dbVentaService = new VentaDB();
            dbEmpleadoService = new EmpleadoDB();
            dbReparacionService = new ReparacionesDB();
            venta = new Venta();
            archivo = new ArchivoTexto();
        }

        private void Form_Listado_Load(object sender, EventArgs e)
        {
            if (this.modo == "productos")
            {
                //dtg_Listado.DataSource = Sistema.listaProductos;
                dtg_Listado.Columns.Add("Codigo", "Codigo");
                dtg_Listado.Columns.Add("Nombre", "Nombre");
                dtg_Listado.Columns.Add("Categoria", "Categoria");
                dtg_Listado.Columns.Add("Cantidad", "Cantidad");
                dtg_Listado.Columns.Add("PrecioVenta", "Precio De Venta");
                dtg_Listado.Columns.Add("PrecioCompra", "Precio Compra");
            }
            if (this.modo == "clientes")
            {
                dtg_Listado.Columns.Add("DNI", "DNI");
                dtg_Listado.Columns.Add("Nombre", "Nombre");
                dtg_Listado.Columns.Add("Apellido", "Apellido");
                dtg_Listado.Columns.Add("Direccion", "Direccion");
                dtg_Listado.Columns.Add("Telefono", "Telefono");
                //dtg_Listado.DataSource = Sistema.listaClientes;
            }
            if (modo == "reparacion")
            {
                dtg_Listado.Columns.Add("Serie", "SERIE");
                dtg_Listado.Columns.Add("Cliente", "CLIENTE");
                dtg_Listado.Columns.Add("Tipo", "TIPO");
                dtg_Listado.Columns.Add("Falla", "FALLA");
                dtg_Listado.Columns.Add("Estado", "ESTADO");
                dtg_Listado.Columns.Add("Presupuesto", "PRESUPUESTO");
                dtg_Listado.Columns.Add("Precio", "PRESUPUESTO");
            }
            if (modo == "ventas")
            {
                dtg_Listado.Columns.Add("IdVenta", "ID VENTA");
                dtg_Listado.Columns.Add("Cliente", "CLIENTE");
                dtg_Listado.Columns.Add("Total", "PRECIO TOTAL");
            }
            LlenarDataGrid();
        }

        private void LlenarDataGrid()
        {
            if (this.modo == "productos")
            {
                try
                {
                    List<Producto> lista = dbProdService.TraerTodo();

                    foreach (Producto producto in lista)
                    {
                        int n = dtg_Listado.Rows.Add();

                        dtg_Listado.Rows[n].Cells[0].Value = producto.Codigo;
                        dtg_Listado.Rows[n].Cells[1].Value = producto.Nombre;
                        dtg_Listado.Rows[n].Cells[2].Value = producto.Categoria;
                        dtg_Listado.Rows[n].Cells[3].Value = producto.Cantidad;
                        dtg_Listado.Rows[n].Cells[4].Value = producto.PrecioVenta;
                        dtg_Listado.Rows[n].Cells[5].Value = producto.PrecioCompra;
                    }
                }
                catch (Exception ex)
                {
                    archivo.LogErrores(ex);
                    MessageBox.Show("ERROR al cargar los productos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                if (this.modo == "clientes")
                {
                    try
                    {
                        List<Cliente> lista = dbClientService.TraerTodo();
                        foreach (Cliente cliente in lista)
                        {
                            int n = dtg_Listado.Rows.Add();

                            dtg_Listado.Rows[n].Cells[0].Value = cliente.Dni;
                            dtg_Listado.Rows[n].Cells[1].Value = cliente.Nombre;
                            dtg_Listado.Rows[n].Cells[2].Value = cliente.Apellido;
                            dtg_Listado.Rows[n].Cells[3].Value = cliente.Direccion;
                            dtg_Listado.Rows[n].Cells[4].Value = cliente.Telefono;
                        }
                    }
                    catch (Exception ex)
                    {
                        archivo.LogErrores(ex);
                        MessageBox.Show("ERROR al cargar los clientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    if (this.modo == "reparacion")
                    {
                        try
                        {
                            List<Reparacion> lista = dbReparacionService.TraerTodo();
                            foreach (Reparacion reparacion in lista)
                            {
                                int n = dtg_Listado.Rows.Add();

                                dtg_Listado.Rows[n].Cells[0].Value = reparacion.NumeroSerie;
                                dtg_Listado.Rows[n].Cells[1].Value = reparacion.Cliente.Nombre;
                                dtg_Listado.Rows[n].Cells[2].Value = reparacion.TipoDeReparacion;
                                dtg_Listado.Rows[n].Cells[3].Value = reparacion.Falla;
                                dtg_Listado.Rows[n].Cells[4].Value = reparacion.Estado;
                                dtg_Listado.Rows[n].Cells[5].Value = reparacion.Presupuesto;
                                dtg_Listado.Rows[n].Cells[6].Value = reparacion.Precio;
                            }
                        }
                        catch (Exception ex)
                        {
                            archivo.LogErrores(ex);
                            MessageBox.Show("ERROR al cargar las reparaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    else
                    {
                        if (this.modo == "ventas")
                        {
                            try
                            {
                                List<Venta> lista = dbVentaService.TraerTodo();
                                foreach (Venta venta in lista)
                                {
                                    int n = dtg_Listado.Rows.Add();

                                    dtg_Listado.Rows[n].Cells[0].Value = venta.IdVenta;
                                    dtg_Listado.Rows[n].Cells[1].Value = venta.Cliente.Nombre;
                                    dtg_Listado.Rows[n].Cells[2].Value = venta.CalcularPrecioTotal();
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
            }
        }

        private void dtg_Listado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string? data = this.dtg_Listado.CurrentRow.Cells[0].Value.ToString();
                Venta ventaAux;
                if (data != null)
                {
                    ventaAux = dbVentaService.Traer(data);
                    Form_DetalleVenta form_Detalle = new Form_DetalleVenta(ventaAux);
                    form_Detalle.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                archivo.LogErrores(ex);
                MessageBox.Show("ERROR al cargar los datos de la VENTA", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

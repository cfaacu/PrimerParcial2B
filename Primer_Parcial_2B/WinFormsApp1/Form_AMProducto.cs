using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using static Entidades.Enumerado;

namespace Formularios
{
    public partial class Form_AMProducto : Form
    {
        private string modo;
        private string codigo;
        Producto producto;
        Enumerado.ECategoria enumerado;
        ProductoDB dbProductoService;
        public Form_AMProducto()
        {
            InitializeComponent();
            dbProductoService = new ProductoDB();
        }
        public Form_AMProducto(string codigo, string modo) : this()
        {
            this.modo = modo;
            this.codigo = codigo;
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_AMProducto_Load(object sender, EventArgs e)
        {
            cmb_Categoria.SelectedIndex = 0;
            string[] valores = Enum.GetNames(typeof(Enumerado.ECategoria));
            cmb_Categoria.Items.AddRange(valores);

            if (this.modo == "Modificar")
            {
                try
                {
                    producto = Sistema.BuscarProducto(this.codigo);

                    this.txt_Cantidad.Text = producto.Cantidad.ToString();
                    this.txt_Codigo.Text = producto.Codigo;
                    this.txt_Nombre.Text = producto.Nombre;
                    this.txt_PrecioCompra.Text = producto.PrecioCompra.ToString();
                    this.txt_PrecioVenta.Text = producto.PrecioVenta.ToString();
                    this.txt_Codigo.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al buscar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (this.modo == "Alta")
            {
                this.btn_Modificar.Text = "CREAR";
                this.lbl_Titulo.Text = "CREAR PRODUCTO";
            }
        }

        private void cmb_Categoria_MouseClick(object sender, MouseEventArgs e)
        {
            this.cmb_Categoria.Items.Remove("CATEGORIA");
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                enumerado = (Enumerado.ECategoria)this.cmb_Categoria.SelectedIndex;
                Validaciones.ValidarCampos(this.txt_Codigo.Text, this.txt_Nombre.Text, enumerado.ToString(), this.txt_PrecioVenta.Text, this.txt_PrecioCompra.Text, this.txt_Cantidad.Text);
                Producto productoAux = new Producto(this.txt_Codigo.Text, this.txt_Nombre.Text, enumerado, double.Parse(this.txt_PrecioVenta.Text), double.Parse(this.txt_PrecioCompra.Text), int.Parse(this.txt_Cantidad.Text));
                if (productoAux != null)
                {
                    if(modo == "Modificar")
                    {
                        producto.Modificar(productoAux);
                    }
                    if(modo == "Alta")
                    {
                        productoAux.Agregar();
                    }
                    this.Close();
                }
            }
            catch(DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al ingresar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}

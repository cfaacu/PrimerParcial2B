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
    public partial class Form_ABM_Productos : Form
    {
        string modo;
        Enumerado.ECategoria enumerado;
        public Form_ABM_Productos(string modo)
        {
            this.modo = modo;
            InitializeComponent();
        }
        private void Form_ABM_Productos_Load(object sender, EventArgs e)
        {
            string[] valores = Enum.GetNames(typeof(Enumerado.ECategoria));
            cmb_Categoria.Items.AddRange(valores);
            this.btn_Buscar.Visible = false;

            if (this.modo == "baja" || this.modo == "modificar")
            {
                this.txt_Nombre.Enabled = false;
                this.cmb_Categoria.Enabled = false;
                this.txt_PrecioCompra.Enabled = false;
                this.txt_PrecioVenta.Enabled = false;
                this.txt_Cantidad.Enabled = false;

                if (this.modo == "modificar")
                {
                    this.btn_Buscar.Visible = true;
                }
            }
        }
        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            if (modo == "alta")
            {
                if (Validaciones.ValidarCampos(this.txt_Codigo.Text, this.txt_Nombre.Text, (string)this.cmb_Categoria.SelectedItem, this.txt_PrecioVenta.Text, this.txt_PrecioCompra.Text, this.txt_Cantidad.Text))
                {
                    enumerado = (Enumerado.ECategoria)this.cmb_Categoria.SelectedIndex;
                    Producto producto = new Producto(this.txt_Codigo.Text, this.txt_Nombre.Text, enumerado, int.Parse(this.txt_PrecioVenta.Text), int.Parse(this.txt_PrecioCompra.Text), int.Parse(this.txt_Cantidad.Text));
                    if (Sistema.Agregar(producto))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el producto a la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error Datos Invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (modo == "baja")
            {
                if (!String.IsNullOrEmpty(this.txt_Codigo.Text))
                {
                    if (Sistema.EliminarProducto(this.txt_Codigo.Text))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (modo == "modificar")
            {
                Sistema.EliminarProducto(this.txt_Codigo.Text);
                enumerado = (Enumerado.ECategoria)this.cmb_Categoria.SelectedIndex;
                Producto productoAux = new Producto(this.txt_Codigo.Text, this.txt_Nombre.Text, enumerado, int.Parse(this.txt_PrecioVenta.Text), int.Parse(this.txt_PrecioCompra.Text), int.Parse(this.txt_Cantidad.Text));
                if (Sistema.Agregar(productoAux))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al modificar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txt_Codigo.Text))
            {
                Producto producto = Sistema.BuscarProducto(this.txt_Codigo.Text);
                if (producto != null)
                {
                    this.txt_Codigo.Text = producto.Codigo;
                    this.txt_Nombre.Text = producto.Nombre;
                    this.cmb_Categoria.SelectedIndex = (int)producto.Categoria;
                    this.txt_PrecioCompra.Text = producto.PrecioCompra.ToString();
                    this.txt_PrecioVenta.Text = producto.PrecioVenta.ToString();
                    this.txt_Cantidad.Text = producto.Cantidad.ToString();

                    this.txt_Nombre.Enabled = true;
                    this.cmb_Categoria.Enabled = true;
                    this.txt_PrecioCompra.Enabled = true;
                    this.txt_PrecioVenta.Enabled = true;
                    this.txt_Cantidad.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Codigo Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

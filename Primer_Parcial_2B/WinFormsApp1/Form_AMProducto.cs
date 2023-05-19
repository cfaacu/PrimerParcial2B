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
        public Form_AMProducto()
        {
            InitializeComponent();
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
                producto = Sistema.BuscarProducto(this.codigo);

                this.txt_Cantidad.Text = producto.Cantidad.ToString();
                this.txt_Codigo.Text = producto.Codigo;
                this.txt_Nombre.Text = producto.Nombre;
                this.txt_PrecioCompra.Text = producto.PrecioCompra.ToString();
                this.txt_PrecioVenta.Text = producto.PrecioVenta.ToString();
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
            if(modo == "Modificar")
            {
                
            }
            enumerado = (Enumerado.ECategoria)this.cmb_Categoria.SelectedIndex;
            if (Validaciones.ValidarCampos(this.txt_Codigo.Text, this.txt_Nombre.Text, enumerado.ToString(), this.txt_PrecioVenta.Text, this.txt_PrecioCompra.Text, this.txt_Cantidad.Text))
            {                
                Producto productoAux = new Producto(this.txt_Codigo.Text, this.txt_Nombre.Text, enumerado, int.Parse(this.txt_PrecioVenta.Text), int.Parse(this.txt_PrecioCompra.Text), int.Parse(this.txt_Cantidad.Text));
                if(productoAux != null)
                {
                    Sistema.EliminarProducto(this.txt_Codigo.Text);
                    if (Sistema.Agregar(productoAux))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al ingresar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Error datos invalidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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
    public partial class Form_AMCliente : Form
    {
        private string dni;
        private string modo;
        Cliente cliente;
        public Form_AMCliente(string dni, string modo) : this()
        {
            this.dni = dni;
            this.modo = modo;
        }
        public Form_AMCliente()
        {
            InitializeComponent();
        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_ModificarCliente_Load(object sender, EventArgs e)
        {
            if (this.modo == "Modificar")
            {
                cliente = Sistema.BuscarCliente(this.dni);

                this.txt_Apellido.Text = cliente.Apellido;
                this.txt_Direccion.Text = cliente.Direccion;
                this.txt_DNI.Text = cliente.Dni.ToString();
                this.txt_Nombre.Text = cliente.Nombre;
                this.txt_Telefono.Text = cliente.Telefono.ToString();
            }
            if (this.modo == "Alta")
            {
                this.btn_Modificar.Text = "CREAR";
                this.txt_DNI.ReadOnly = false;
                this.lbl_Titulo.Text = "CREAR CLIENTE";
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarCamposClientes(this.txt_Nombre.Text, this.txt_Apellido.Text, this.txt_DNI.Text, this.txt_Telefono.Text, this.txt_Direccion.Text))
            {
                Cliente clienteAux = new Cliente(this.txt_Nombre.Text, this.txt_Apellido.Text, int.Parse(this.txt_DNI.Text), this.txt_Direccion.Text, int.Parse(this.txt_Telefono.Text));
                if (clienteAux != null)
                {
                    Sistema.EliminarCliente(this.dni);
                    Sistema.Agregar(clienteAux);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Error al ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

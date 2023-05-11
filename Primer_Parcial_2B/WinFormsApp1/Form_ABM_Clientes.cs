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
    public partial class Form_ABM_Clientes : Form
    {
        Empleado empleado;
        Cliente cliente;
        string modo;
        public Form_ABM_Clientes(string modo)
        {
            this.modo = modo;
            InitializeComponent();
        }

        private void Form_ABM_Clientes_Load(object sender, EventArgs e)
        {
            this.btn_Buscar.Visible = false;
            if (modo == "registro")
            {
                this.lbl_Telefono.Text = "Usuario";
                this.lbl_Direccion.Text = "Password";
                this.txt_Direccion.PasswordChar = '*';
            }
            if (modo == "baja")
            {
                this.txt_Apellido.Enabled = false;
                this.txt_Direccion.Enabled = false;
                this.txt_Nombre.Enabled = false;
                this.txt_Telefono.Enabled = false;
            }
            if(modo == "modificar")
            {
                this.btn_Buscar.Visible = true;
            }
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            if (modo == "registro")
            {
                if (Validaciones.ValidarCampos(this.txt_Nombre.Text, this.txt_Apellido.Text, this.txt_DNI.Text, this.txt_Telefono.Text, this.txt_Direccion.Text))
                {
                    empleado = new Empleado(this.txt_Nombre.Text, this.txt_Apellido.Text, int.Parse(this.txt_DNI.Text), this.txt_Telefono.Text, this.txt_Direccion.Text);
                    if (empleado != null)
                    {
                        Sistema.listaEmpleados.Add(empleado);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar al usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Error al ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (modo == "alta")
            {
                if (Validaciones.ValidarCamposClientes(this.txt_Nombre.Text, this.txt_Apellido.Text, this.txt_DNI.Text, this.txt_Telefono.Text, this.txt_Direccion.Text))
                {
                    cliente = new Cliente(this.txt_Nombre.Text, this.txt_Apellido.Text, int.Parse(this.txt_DNI.Text), this.txt_Direccion.Text, int.Parse(this.txt_Telefono.Text));
                    Sistema.listaClientes.Add(cliente);
                    this.Close();
                }
            }
            if (modo == "baja")
            {
                if (!String.IsNullOrEmpty(this.txt_DNI.Text))
                {
                    if (Sistema.EliminarCliente(this.txt_DNI.Text))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if(modo == "modificar")
            {
                Sistema.EliminarCliente(this.txt_DNI.Text);
                Cliente clienteAux = new Cliente(this.txt_Nombre.Text, this.txt_Apellido.Text, int.Parse(this.txt_DNI.Text), this.txt_Direccion.Text, int.Parse(this.txt_Telefono.Text));
                if (Sistema.Agregar(clienteAux))
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al modificar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txt_DNI.Text))
            {
                Cliente cliente = Sistema.BuscarCliente(this.txt_DNI.Text);
                if (cliente != null)
                {
                    this.txt_DNI.Text = cliente.Dni.ToString();
                    this.txt_Nombre.Text = cliente.Nombre;
                    this.txt_Apellido.Text = cliente.Apellido;
                    this.txt_Direccion.Text = cliente.Direccion;
                    this.txt_Telefono.Text = cliente.Telefono.ToString();

                    this.txt_Nombre.Enabled = true;
                    this.txt_DNI.Enabled = true;
                    this.txt_Apellido.Enabled = true;
                    this.txt_Direccion.Enabled = true;
                    this.txt_Telefono.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Codigo Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

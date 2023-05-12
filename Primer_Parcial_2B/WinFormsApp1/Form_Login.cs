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
    public partial class Form_Login : Form
    {
        Empleado empleado;
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(this.txt_Usuario.Text)) && !(string.IsNullOrEmpty(this.txt_Password.Text)))
            {
                empleado = Sistema.LoguearUsuario(this.txt_Usuario.Text, this.txt_Password.Text);
                if (empleado != null)
                {
                    if(empleado is Administrador) 
                    {
                        Form_MenuPrincipal form_MenuPrincipal = new Form_MenuPrincipal("admin");
                        form_MenuPrincipal.Show();
                    }
                    else
                    {
                        Form_MenuPrincipal form_MenuPrincipal = new Form_MenuPrincipal("empleado");
                        form_MenuPrincipal.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error al ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Registrarse_Click(object sender, EventArgs e)
        {
            Form_ABM_Clientes form_CrearUsuario = new Form_ABM_Clientes("registro");
            form_CrearUsuario.ShowDialog();
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            foreach (Empleado empleado in Sistema.listaEmpleados)
            {
                if (empleado is Administrador)
                {
                    this.txt_Usuario.Text = empleado.Usuario;
                    this.txt_Password.Text = empleado.Password;
                    break;
                }
            }
        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            foreach (Empleado empleado in Sistema.listaEmpleados)
            {
                if (empleado is Empleado)
                {
                    this.txt_Usuario.Text = empleado.Usuario;
                    this.txt_Password.Text = empleado.Password;
                    break;
                }
            }
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }

        private void txt_Usuario_Enter(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "USUARIO")
            {
                this.txt_Usuario.Text = "";
                this.txt_Usuario.ForeColor = Color.LightGray;
            }
        }

        private void txt_Usuario_Leave(object sender, EventArgs e)
        {
            if (this.txt_Usuario.Text == "")
            {
                this.txt_Usuario.Text = "USUARIO";
                this.txt_Usuario.ForeColor = Color.Gray;
            }
        }

        private void txt_Password_Enter(object sender, EventArgs e)
        {
            if (this.txt_Password.Text == "CONTRASEÑA")
            {
                this.txt_Password.Text = "";
                this.txt_Password.ForeColor = Color.LightGray;
                this.txt_Password.UseSystemPasswordChar = true;
            }
        }

        private void txt_Password_Leave(object sender, EventArgs e)
        {
            if (this.txt_Password.Text == "")
            {
                this.txt_Password.Text = "CONTRASEÑA";
                this.txt_Password.ForeColor = Color.Gray;
                this.txt_Password.UseSystemPasswordChar = false;
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

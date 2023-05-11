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
                    Form_MenuPrincipal form_MenuPrincipal = new Form_MenuPrincipal();
                    form_MenuPrincipal.Show();
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
            foreach(Empleado empleado in Sistema.listaEmpleados)
            {
                if(empleado is Administrador)
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
    }
}

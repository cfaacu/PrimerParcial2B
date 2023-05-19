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
            string modo;
            if (!(string.IsNullOrEmpty(this.txt_Usuario.Text)) && !(string.IsNullOrEmpty(this.txt_Password.Text)))
            {
                empleado = Sistema.LoguearUsuario(this.txt_Usuario.Text, this.txt_Password.Text);
                if (empleado != null)
                {
                    if (empleado.Admin == true)
                    {
                        modo = "admin";
                    }
                    else
                    {
                        modo = "empleado";
                    }
                    Form_MenuPrincipal form_MenuPrincipal = new Form_MenuPrincipal(modo);
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

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            foreach (Empleado empleado in Sistema.listaEmpleados)
            {
                if (empleado.Admin == true)
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
                if (empleado.Admin == false)
                {
                    this.txt_Usuario.Text = empleado.Usuario;
                    this.txt_Password.Text = empleado.Password;
                    break;
                }
            }
        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

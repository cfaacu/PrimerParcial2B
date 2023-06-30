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
    public partial class Form_Login : Form
    {
        Empleado empleado;
        EmpleadoDB dbEmpleadoService;

        public Form_Login()
        {
            InitializeComponent();
            dbEmpleadoService = new EmpleadoDB();
        }

        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            string modo;
            try
            {
                if(Validaciones.StringCargado(this.txt_Usuario.Text) && Validaciones.StringCargado(this.txt_Password.Text))
                empleado = dbEmpleadoService.TraerUser(this.txt_Usuario.Text, this.txt_Password.Text);
                if(empleado.Admin)
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
            catch(DatosInvalidosException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("El usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                 
        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            empleado = dbEmpleadoService.TraerAdmin();
            this.txt_Usuario.Text = empleado.Usuario;
            this.txt_Password.Text = empleado.Password;
        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            empleado = dbEmpleadoService.TraerEmpleado();
            this.txt_Usuario.Text = empleado.Usuario;
            this.txt_Password.Text = empleado.Password;
        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

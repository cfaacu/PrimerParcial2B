using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Entidades.DB_SQL;

namespace Formularios
{
    public partial class Form_MenuPrincipal : Form
    {
        string modo;
        private Form formularioActivo = null;
        public Form_MenuPrincipal(string modo)
        {
            InitializeComponent();
            PersonalizarDisenio();
            this.modo = modo;
        }

        private void PersonalizarDisenio()
        {
            panelSubMenuReparaciones.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (panelSubMenuReparaciones.Visible == true)
            {
                panelSubMenuReparaciones.Visible = false;
            }
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            Form_Productos form_Productos = new Form_Productos();
            AbrirFormularioHijo(form_Productos);
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Form_Clientes form_Clientes = new Form_Clientes();
            AbrirFormularioHijo(form_Clientes);
        }

        private void AbrirFormularioHijo(Form formularioHijo)
        {
            OcultarSubMenu();
            if (formularioActivo != null)
            {
                formularioActivo.Close();
            }
            formularioActivo = formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formularioHijo);
            panelContenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();
        }

        private void btn_AgregarReparacion_Click(object sender, EventArgs e)
        {
            Form_AltaReparacion form_AltaReparacion = new Form_AltaReparacion();
            AbrirFormularioHijo(form_AltaReparacion);
        }

        private void btn_ModificarReparacion_Click(object sender, EventArgs e)
        {
            Form_ModificarReparacion form_modificarReparacion = new Form_ModificarReparacion();
            AbrirFormularioHijo(form_modificarReparacion);
        }

        private void btn_MostrarReparaciones_Click(object sender, EventArgs e)
        {
            Form_Listado form_Listado = new Form_Listado("reparacion");
            AbrirFormularioHijo(form_Listado);
        }

        private void btn_Reparacion_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(this.panelSubMenuReparaciones);
        }

        private void btn_GenerarVenta_Click(object sender, EventArgs e)
        {
            Form_Ventas form_Ventas = new Form_Ventas();
            AbrirFormularioHijo(form_Ventas);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.formularioActivo != null)
            {
                this.formularioActivo.Close();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_MenuPrincipal_Load(object sender, EventArgs e)
        {
            if (this.modo == "admin")
            {
                this.btn_MostrarVentas.Visible = true;
                this.btn_AdministrarUsuario.Visible = true;
            }


            //this.logoImagen.ImageLocation = Path.Combine(Directory.GetCurrentDirectory(), "delete_remove_bin_icon-icons.com_72400.png");
            //panelSubMenuReparaciones.BackColor = ColorTranslator.FromHtml("#FF5733");
        }

        private void btn_MostrarVentas_Click(object sender, EventArgs e)
        {
            Form_Listado form_Listado = new Form_Listado("ventas");
            AbrirFormularioHijo(form_Listado);
        }

        private void btn_AdministrarUsuario_Click(object sender, EventArgs e)
        {
            Form_AdministrarUsuarios form_Admin = new Form_AdministrarUsuarios();
            form_Admin.Show();
        }
    }
}

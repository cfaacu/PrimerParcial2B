using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class Form_MenuPrincipal : Form
    {
        string modo;
        public Form_MenuPrincipal(string modo)
        {
            InitializeComponent();
            PersonalizarDisenio();
            this.modo = modo;
        }

        private void PersonalizarDisenio()
        {
            panelSubMenuClientes.Visible = false;
            panelSubMenuProductos.Visible = false;
            panelSubMenuReparaciones.Visible = false;
        }

        private void OcultarSubMenu()
        {
            if (panelSubMenuClientes.Visible == true)
            {
                panelSubMenuClientes.Visible = false;
            }
            if (panelSubMenuProductos.Visible == true)
            {
                panelSubMenuProductos.Visible = false;
            }
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
            MostrarSubMenu(this.panelSubMenuProductos);
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(this.panelSubMenuClientes);
        }

        private Form formularioActivo = null;
        private void AbrirFormularioHijo(Form formularioHijo)
        {
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

        private void btn_AgregarProducto_Click(object sender, EventArgs e)
        {
            Form_ABM_Productos form_Productos = new Form_ABM_Productos("alta");
            AbrirFormularioHijo(form_Productos);
            OcultarSubMenu();
        }

        private void btn_ModificarProducto_Click(object sender, EventArgs e)
        {
            Form_ABM_Productos form_Productos = new Form_ABM_Productos("modificar");
            AbrirFormularioHijo(form_Productos);
            OcultarSubMenu();
        }

        private void btn_EliminarProducto_Click(object sender, EventArgs e)
        {
            Form_ABM_Productos form_Productos = new Form_ABM_Productos("baja");
            AbrirFormularioHijo(form_Productos);
            OcultarSubMenu();
        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {
            Form_ABM_Clientes form_Clientes = new Form_ABM_Clientes("alta");
            AbrirFormularioHijo(form_Clientes);
            OcultarSubMenu();
        }

        private void btn_ModificarCliente_Click(object sender, EventArgs e)
        {
            Form_ABM_Clientes form_Clientes = new Form_ABM_Clientes("modificar");
            AbrirFormularioHijo(form_Clientes);
            OcultarSubMenu();
        }

        private void btn_EliminarCliente_Click(object sender, EventArgs e)
        {
            Form_ABM_Clientes form_Clientes = new Form_ABM_Clientes("baja");
            AbrirFormularioHijo(form_Clientes);
            OcultarSubMenu();
        }

        private void btn_MostrarClientes_Click(object sender, EventArgs e)
        {
            Form_Listado form_Listado = new Form_Listado("clientes");
            AbrirFormularioHijo(form_Listado);
            OcultarSubMenu();
        }

        private void btn_AgregarReparacion_Click(object sender, EventArgs e)
        {
            Form_AltaReparacion form_AltaReparacion = new Form_AltaReparacion();
            AbrirFormularioHijo(form_AltaReparacion);
            OcultarSubMenu();
        }

        private void btn_ModificarReparacion_Click(object sender, EventArgs e)
        {
            Form_ModificarReparacion form_modificarReparacion = new Form_ModificarReparacion();
            AbrirFormularioHijo(form_modificarReparacion);
            OcultarSubMenu();
        }

        private void btn_MostrarReparaciones_Click(object sender, EventArgs e)
        {
            Form_Listado form_Listado = new Form_Listado("reparacion");
            AbrirFormularioHijo(form_Listado);
            OcultarSubMenu();
        }

        private void btn_MostrarProducto_Click(object sender, EventArgs e)
        {
            Form_Listado form_Listado = new Form_Listado("productos");
            AbrirFormularioHijo(form_Listado);
            OcultarSubMenu();
        }

        private void btn_Reparacion_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(this.panelSubMenuReparaciones);
        }

        private void btn_GenerarVenta_Click(object sender, EventArgs e)
        {
            OcultarSubMenu();
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
            if (this.modo == "empleado")
            {
                this.btn_EliminarCliente.Enabled = false;
                this.btn_EliminarProducto.Enabled = false;
            }
            if (this.modo == "admin")
            {
                this.btn_MostrarVentas.Visible = true;
            }
        }

        private void btn_MostrarVentas_Click(object sender, EventArgs e)
        {
            Form_Listado form_Listado = new Form_Listado("ventas");
            AbrirFormularioHijo(form_Listado);
            OcultarSubMenu();
        }
    }
}

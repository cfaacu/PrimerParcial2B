using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class Form_AdministrarUsuarios : Form
    {
        Empleado empleado;
        bool flag;
        public Form_AdministrarUsuarios()
        {
            InitializeComponent();
        }

        private void Form_AdministrarUsuarios_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
            flag = false;
        }

        private void LlenarDataGridView()
        {
            dtg_ListadoUsuarios.Rows.Clear();
            foreach (Empleado empleado in Sistema.listaEmpleados)
            {
                int n = dtg_ListadoUsuarios.Rows.Add();

                dtg_ListadoUsuarios.Rows[n].Cells[0].Value = empleado.Dni;
                dtg_ListadoUsuarios.Rows[n].Cells[1].Value = empleado.Nombre;
                dtg_ListadoUsuarios.Rows[n].Cells[2].Value = empleado.Apellido;
                dtg_ListadoUsuarios.Rows[n].Cells[3].Value = empleado.Usuario;
                dtg_ListadoUsuarios.Rows[n].Cells[4].Value = empleado.Admin;
            }
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                Sistema.EliminarEmpleado(this.txt_DNI.Text);
                flag = false;
            }
            if (Validaciones.ValidarCampos(this.txt_Nombre.Text, this.txt_Apellido.Text, this.txt_DNI.Text, this.txt_Usuario.Text, this.txt_Password.Text))
            {
                empleado = new Empleado(this.txt_Nombre.Text, this.txt_Apellido.Text, int.Parse(this.txt_DNI.Text), this.txt_Usuario.Text, this.txt_Password.Text, chk_Admin.Checked);
                if (empleado != null)
                {
                    Sistema.listaEmpleados.Add(empleado);
                    LlenarDataGridView();
                }
            }
            else
            {
                MessageBox.Show("Error al ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_ListadoUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dtg_ListadoUsuarios.Columns[e.ColumnIndex].Name == "Modificar")
            {
                string? dni = this.dtg_ListadoUsuarios.CurrentRow.Cells["Dni"].Value.ToString();
                empleado = Sistema.BuscarEmpleado(dni);
                if (empleado != null)
                {
                    this.txt_DNI.Text = empleado.Dni.ToString();
                    this.txt_Nombre.Text = empleado.Nombre;
                    this.txt_Apellido.Text = empleado.Apellido;
                    this.txt_Usuario.Text = empleado.Usuario;
                    this.txt_Password.Text = empleado.Password;
                    if (empleado.Admin == true)
                    {
                        this.chk_Admin.Checked = true;
                    }
                    else
                    {
                        this.chk_Admin.Checked = false;
                    }
                    flag = true;
                }
            }
        }
    }
}

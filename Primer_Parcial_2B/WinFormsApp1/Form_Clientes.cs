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
using Entidades.DB_SQL;

namespace Formularios
{
    public partial class Form_Clientes : Form
    {
        Cliente cliente;
        List<Cliente> clientes;
        ClienteDB dbClienteService;
        public Form_Clientes()
        {
            InitializeComponent();
            clientes = new List<Cliente>();
            dbClienteService = new ClienteDB();
        }

        private void Form_Clientes_Load(object sender, EventArgs e)
        {
            LlenarDataGridView();
        }

        private void LlenarDataGridView()
        {
            try
            {
                dtg_Listado.Rows.Clear();
                clientes = dbClienteService.TraerTodo();
                foreach (Cliente cliente in clientes)
                {
                    int n = dtg_Listado.Rows.Add();

                    dtg_Listado.Rows[n].Cells[0].Value = cliente.Dni;
                    dtg_Listado.Rows[n].Cells[1].Value = cliente.Nombre;
                    dtg_Listado.Rows[n].Cells[2].Value = cliente.Apellido;
                    dtg_Listado.Rows[n].Cells[3].Value = cliente.Direccion;
                    dtg_Listado.Rows[n].Cells[4].Value = cliente.Telefono;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al traer los clientes", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtg_Listado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string? dni = this.dtg_Listado.CurrentRow.Cells["Dni"].Value.ToString();
            if (dtg_Listado.Columns[e.ColumnIndex].Name == "Editar")
            {
                Form_AMCliente form_Modificar = new Form_AMCliente(dni, "Modificar");
                form_Modificar.ShowDialog();
            }
            if (dtg_Listado.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DialogResult dg = MessageBox.Show("Desea eliminar el cliente?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dg == DialogResult.Yes)
                {
                    try
                    {
                        cliente = dbClienteService.Traer(dni);
                        cliente.Borrar();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al eliminar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            LlenarDataGridView();
        }

        private void btn_Continuar_Click(object sender, EventArgs e)
        {
            Form_AMCliente form_Modificar = new Form_AMCliente(null, "Alta");
            form_Modificar.ShowDialog();
            LlenarDataGridView();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
using Entidades.DB_SQL;

namespace Formularios
{
    public partial class Form_AltaReparacion : Form
    {
        Cliente cliente;
        ReparacionesDB dbReparacionService;
        public Form_AltaReparacion()
        {
            InitializeComponent();
            dbReparacionService = new ReparacionesDB();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txt_DNI.Text))
            {
                cliente = Sistema.BuscarCliente(this.txt_DNI.Text);
                if (cliente != null)
                {
                    this.txt_Nombre.Text = cliente.Nombre;
                    this.txt_Apellido.Text = cliente.Apellido;
                    this.txt_Direccion.Text = cliente.Direccion;
                    this.txt_Telefono.Text = cliente.Telefono.ToString();
                }
                else
                {
                    MessageBox.Show("Error DNI invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error ingrese un DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_AltaReparacion_Load(object sender, EventArgs e)
        {
            cmb_Tipo.SelectedIndex = 0;
            string[] valores = Enum.GetNames(typeof(Enumerado.ETiposDeReparaciones));
            cmb_Tipo.Items.AddRange(valores);

        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarCampos(this.txt_NumeroSerie.Text, this.cmb_Tipo.Text, this.txt_Falla.Text) && this.cliente != null)
            {
                Enumerado.ETiposDeReparaciones enumerado = (Enumerado.ETiposDeReparaciones)this.cmb_Tipo.SelectedIndex;
                Reparacion reparacion = new Reparacion(Guid.NewGuid(), this.txt_NumeroSerie.Text, enumerado, this.cliente, this.txt_Falla.Text);

                DialogResult resultado = MessageBox.Show("¿Desea confirmar la reparacion?", "Confirmación de reparacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    dbReparacionService.Agregar(reparacion);
                    this.Close();
                }
                else
                {
                    this.Close();
                }

            }
        }

        private void cmb_Tipo_MouseClick(object sender, MouseEventArgs e)
        {
            this.cmb_Tipo.Items.Remove("TIPO DE REPARACION");
        }
    }
}

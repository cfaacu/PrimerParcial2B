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
    public partial class Form_ModificarReparacion : Form
    {
        Reparacion reparacion;
        public Form_ModificarReparacion()
        {
            InitializeComponent();
        }

        private void Form_ModificarReparacion_Load(object sender, EventArgs e)
        {
            this.dtg_Reparaciones.DataSource = Sistema.listaReparaciones;
            string[] valores = Enum.GetNames(typeof(Enumerado.EEstado));
            cmb_Estado.Items.AddRange(valores);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txt_CodigoSerie.Text))
            {
                reparacion = Sistema.BuscarReparacion(this.txt_CodigoSerie.Text);
                if (reparacion != null)
                {
                    this.txt_CodigoSerie.Enabled = false;
                    this.txt_Precio.Enabled = true;
                    this.txt_Presupuesto.Enabled = true;
                    this.cmb_Estado.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Error Numero de serie invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error ingrese un Numero de serie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if(Validaciones.ValidarCamposReparacion(this.txt_Presupuesto.Text,this.cmb_Estado.Text,this.txt_Precio.Text))
            {
                this.reparacion.Presupuesto = this.txt_Presupuesto.Text;
                this.reparacion.Estado = (Enumerado.EEstado)this.cmb_Estado.SelectedIndex;
                this.reparacion.Precio = double.Parse(this.txt_Precio.Text);

                Sistema.EliminarReparacion(this.txt_CodigoSerie.Text);
                Sistema.listaReparaciones.Add(this.reparacion);

                this.Close();
            }
        }
    }
}

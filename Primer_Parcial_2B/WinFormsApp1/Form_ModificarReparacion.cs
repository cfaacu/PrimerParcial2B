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
    public partial class Form_ModificarReparacion : Form
    {
        Reparacion reparacion;
        ReparacionesDB dbReparacionesService;
        ArchivoTexto archivo;
        public Form_ModificarReparacion()
        {
            InitializeComponent();
            dbReparacionesService = new ReparacionesDB();
            reparacion = new Reparacion();
            archivo = new ArchivoTexto();
        }

        private void Form_ModificarReparacion_Load(object sender, EventArgs e)
        {
            this.cmb_Estado.SelectedIndex = 0;
            dtg_Reparaciones.Columns.Add("Serie", "SERIE");
            dtg_Reparaciones.Columns.Add("Cliente", "CLIENTE");
            dtg_Reparaciones.Columns.Add("Tipo", "TIPO");
            dtg_Reparaciones.Columns.Add("Falla", "FALLA");
            dtg_Reparaciones.Columns.Add("Estado", "ESTADO");
            dtg_Reparaciones.Columns.Add("Presupuesto", "PRESUPUESTO");
            dtg_Reparaciones.Columns.Add("Precio", "PRESUPUESTO");

            LlenarDataGrid();

            string[] valores = Enum.GetNames(typeof(Enumerado.EEstado));
            cmb_Estado.Items.AddRange(valores);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(this.txt_CodigoSerie.Text))
            {
                reparacion = reparacion.BuscarReparacion(this.txt_CodigoSerie.Text);
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
            try
            {
                if (Validaciones.ValidarCamposReparacion(this.txt_Presupuesto.Text, this.cmb_Estado.Text, this.txt_Precio.Text))
                {
                    this.reparacion.Presupuesto = this.txt_Presupuesto.Text;
                    this.reparacion.Estado = (Enumerado.EEstado)this.cmb_Estado.SelectedIndex;
                    this.reparacion.Precio = double.Parse(this.txt_Precio.Text);

                    //Sistema.EliminarReparacion(this.txt_CodigoSerie.Text);
                    //Sistema.listaReparaciones.Add(this.reparacion);

                    dbReparacionesService.Editar(reparacion);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                archivo.LogErrores(ex);
                MessageBox.Show("Error en los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            
        }

        private void LlenarDataGrid()
        {
            try
            {
                foreach (Reparacion reparacion in dbReparacionesService.TraerTodo())
                {
                    int n = dtg_Reparaciones.Rows.Add();

                    dtg_Reparaciones.Rows[n].Cells[0].Value = reparacion.NumeroSerie;
                    dtg_Reparaciones.Rows[n].Cells[1].Value = reparacion.Cliente.Nombre;
                    dtg_Reparaciones.Rows[n].Cells[2].Value = reparacion.TipoDeReparacion;
                    dtg_Reparaciones.Rows[n].Cells[3].Value = reparacion.Falla;
                    dtg_Reparaciones.Rows[n].Cells[4].Value = reparacion.Estado;
                    dtg_Reparaciones.Rows[n].Cells[5].Value = reparacion.Presupuesto;
                    dtg_Reparaciones.Rows[n].Cells[6].Value = reparacion.Precio;
                }
            }
            catch (Exception ex)
            {
                archivo.LogErrores(ex);
                MessageBox.Show("Error al traer las reparaciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtg_Reparaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = dtg_Reparaciones.CurrentRow.Index;
            txt_CodigoSerie.Text = dtg_Reparaciones[0, posicion].Value.ToString();
        }

        private void cmb_Estado_MouseClick(object sender, MouseEventArgs e)
        {
            this.cmb_Estado.Items.Remove("ESTADO");
        }
    }
}

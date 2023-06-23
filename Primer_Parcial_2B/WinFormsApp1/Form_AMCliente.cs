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
    public partial class Form_AMCliente : Form
    {
        private string dni;
        private string modo;
        Cliente cliente;
        ClienteDB dbClienteService;
        public Form_AMCliente(string dni, string modo) : this()
        {
            this.dni = dni;
            this.modo = modo;
            dbClienteService = new ClienteDB();
            cliente = new Cliente();
        }
        public Form_AMCliente()
        {
            InitializeComponent();
        }
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_ModificarCliente_Load(object sender, EventArgs e)
        {
            if (this.modo == "Modificar")
            {
                try
                {
                    cliente = dbClienteService.Traer(this.dni);

                    this.txt_Apellido.Text = cliente.Apellido;
                    this.txt_Direccion.Text = cliente.Direccion;
                    this.txt_DNI.Text = cliente.Dni.ToString();
                    this.txt_Nombre.Text = cliente.Nombre;
                    this.txt_Telefono.Text = cliente.Telefono.ToString();
                }
                catch (Exception)
                {

                    MessageBox.Show("Error encontrar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (this.modo == "Alta")
            {
                this.btn_Modificar.Text = "CREAR";
                this.txt_DNI.ReadOnly = false;
                this.lbl_Titulo.Text = "CREAR CLIENTE";
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                Validaciones.ValidarCamposClientes(this.txt_Nombre.Text, this.txt_Apellido.Text, this.txt_DNI.Text, this.txt_Telefono.Text, this.txt_Direccion.Text);
                
                Cliente clienteAux = new Cliente(this.txt_Nombre.Text, this.txt_Apellido.Text, int.Parse(this.txt_DNI.Text), this.txt_Direccion.Text, int.Parse(this.txt_Telefono.Text));
                if (clienteAux != null)
                {
                    if (this.modo == "Modificar")
                    {
                        DialogResult resultado = MessageBox.Show("¿Confirma la modificacion?", "Confirmación de modificacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (resultado == DialogResult.Yes)
                        {
                            cliente.Modificar(clienteAux);
                            this.Close();
                        }
                        else
                        {
                            this.Close();
                        }
                    }

                    if(this.modo == "Alta")
                    {
                        clienteAux.Agregar();
                        this.Close();
                    }
                }                
            }
            catch(DatosInvalidosException ex)
            {
                MessageBox.Show("ERROR Datos incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

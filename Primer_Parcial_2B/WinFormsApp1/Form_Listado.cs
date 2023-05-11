﻿using System;
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
    public partial class Form_Listado : Form
    {
        private string modo;
        public Form_Listado(string modo)
        {
            InitializeComponent();
            this.modo = modo;
        }

        private void Form_Listado_Load(object sender, EventArgs e)
        {
            if(this.modo == "productos")
            {
                //dtg_Listado.DataSource = Sistema.listaProductos;
                dtg_Listado.Columns.Add("Codigo","Codigo Producto");
                dtg_Listado.Columns.Add("Nombre","Nombre Producto");
                dtg_Listado.Columns.Add("Categoria","Categoria");
                dtg_Listado.Columns.Add("Cantidad","Cantidad");
                dtg_Listado.Columns.Add("PrecioVenta","Precio De Venta");
                dtg_Listado.Columns.Add("PrecioCompra","Precio De Compra");
            }
            if(this.modo == "clientes")
            {
                dtg_Listado.Columns.Add("DNI", "DNI");
                dtg_Listado.Columns.Add("Nombre", "Nombre");
                dtg_Listado.Columns.Add("Apellido", "Apellido");
                dtg_Listado.Columns.Add("Direccion", "Direccion");
                dtg_Listado.Columns.Add("Telefono", "Telefono");
                //dtg_Listado.DataSource = Sistema.listaClientes;
            }
            if (modo == "reparacion")
            {
                
            }
            LlenarDataGrid();
        }

        private void LlenarDataGrid()
        {
            if(this.modo == "productos")
            {
                foreach (Producto producto in Sistema.listaProductos)
                {
                    int n = dtg_Listado.Rows.Add();

                    dtg_Listado.Rows[n].Cells[0].Value = producto.Codigo;
                    dtg_Listado.Rows[n].Cells[1].Value = producto.Nombre;
                    dtg_Listado.Rows[n].Cells[2].Value = producto.Categoria;
                    dtg_Listado.Rows[n].Cells[3].Value = producto.Cantidad;
                    dtg_Listado.Rows[n].Cells[4].Value = producto.PrecioVenta;
                    dtg_Listado.Rows[n].Cells[5].Value = producto.PrecioCompra;                    
                }
            }
            else
            {
                if(this.modo == "clientes")
                {
                    foreach (Cliente cliente in Sistema.listaClientes)
                    {
                        int n = dtg_Listado.Rows.Add();

                        dtg_Listado.Rows[n].Cells[0].Value = cliente.Dni;
                        dtg_Listado.Rows[n].Cells[1].Value = cliente.Nombre;
                        dtg_Listado.Rows[n].Cells[2].Value = cliente.Apellido;
                        dtg_Listado.Rows[n].Cells[3].Value = cliente.Direccion;
                        dtg_Listado.Rows[n].Cells[4].Value = cliente.Telefono;
                    }
                }
                else
                {
                    if(this.modo == "reparacion")
                    {
                        dtg_Listado.DataSource = Sistema.listaReparaciones;
                    }
                }
            }
        }
    }
}

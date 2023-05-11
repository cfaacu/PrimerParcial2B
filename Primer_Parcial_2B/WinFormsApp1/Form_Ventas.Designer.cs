namespace Formularios
{
    partial class Form_Ventas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Confirmar = new Button();
            grp_Cliente = new GroupBox();
            txt_Apellido = new TextBox();
            lbl_Apellido = new Label();
            btn_Buscar = new Button();
            txt_Direccion = new TextBox();
            lbl_Direccion = new Label();
            txt_Telefono = new TextBox();
            lbl_Telefono = new Label();
            txt_Nombre = new TextBox();
            lbl_Nombre = new Label();
            txt_DNI = new TextBox();
            lbl_DNI = new Label();
            lbl_Total = new Label();
            txt_Total = new TextBox();
            dtg_Productos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            txt_Codigo = new TextBox();
            lbl_Codigo = new Label();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            txt_Cantidad = new TextBox();
            lbl_Cantidad = new Label();
            btn_Agregar = new Button();
            grp_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Productos).BeginInit();
            SuspendLayout();
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.Location = new Point(662, 212);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(125, 57);
            btn_Confirmar.TabIndex = 0;
            btn_Confirmar.Text = "Confirmar";
            btn_Confirmar.UseVisualStyleBackColor = true;
            btn_Confirmar.Click += btn_Confirmar_Click;
            // 
            // grp_Cliente
            // 
            grp_Cliente.Controls.Add(txt_Apellido);
            grp_Cliente.Controls.Add(lbl_Apellido);
            grp_Cliente.Controls.Add(btn_Buscar);
            grp_Cliente.Controls.Add(txt_Direccion);
            grp_Cliente.Controls.Add(lbl_Direccion);
            grp_Cliente.Controls.Add(txt_Telefono);
            grp_Cliente.Controls.Add(lbl_Telefono);
            grp_Cliente.Controls.Add(txt_Nombre);
            grp_Cliente.Controls.Add(lbl_Nombre);
            grp_Cliente.Controls.Add(txt_DNI);
            grp_Cliente.Controls.Add(lbl_DNI);
            grp_Cliente.Location = new Point(25, 26);
            grp_Cliente.Name = "grp_Cliente";
            grp_Cliente.Size = new Size(164, 271);
            grp_Cliente.TabIndex = 1;
            grp_Cliente.TabStop = false;
            grp_Cliente.Text = "Datos del cliente";
            // 
            // txt_Apellido
            // 
            txt_Apellido.Enabled = false;
            txt_Apellido.Location = new Point(16, 143);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(100, 23);
            txt_Apellido.TabIndex = 11;
            // 
            // lbl_Apellido
            // 
            lbl_Apellido.AutoSize = true;
            lbl_Apellido.Location = new Point(16, 124);
            lbl_Apellido.Name = "lbl_Apellido";
            lbl_Apellido.Size = new Size(51, 15);
            lbl_Apellido.TabIndex = 10;
            lbl_Apellido.Text = "Apellido";
            // 
            // btn_Buscar
            // 
            btn_Buscar.Location = new Point(130, 49);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(24, 21);
            btn_Buscar.TabIndex = 9;
            btn_Buscar.UseVisualStyleBackColor = true;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txt_Direccion
            // 
            txt_Direccion.Enabled = false;
            txt_Direccion.Location = new Point(16, 237);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(100, 23);
            txt_Direccion.TabIndex = 8;
            // 
            // lbl_Direccion
            // 
            lbl_Direccion.AutoSize = true;
            lbl_Direccion.Location = new Point(16, 219);
            lbl_Direccion.Name = "lbl_Direccion";
            lbl_Direccion.Size = new Size(57, 15);
            lbl_Direccion.TabIndex = 7;
            lbl_Direccion.Text = "Direccion";
            // 
            // txt_Telefono
            // 
            txt_Telefono.Enabled = false;
            txt_Telefono.Location = new Point(17, 189);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(100, 23);
            txt_Telefono.TabIndex = 6;
            // 
            // lbl_Telefono
            // 
            lbl_Telefono.AutoSize = true;
            lbl_Telefono.Location = new Point(17, 171);
            lbl_Telefono.Name = "lbl_Telefono";
            lbl_Telefono.Size = new Size(52, 15);
            lbl_Telefono.TabIndex = 5;
            lbl_Telefono.Text = "Telefono";
            // 
            // txt_Nombre
            // 
            txt_Nombre.Enabled = false;
            txt_Nombre.Location = new Point(17, 98);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 23);
            txt_Nombre.TabIndex = 4;
            // 
            // lbl_Nombre
            // 
            lbl_Nombre.AutoSize = true;
            lbl_Nombre.Location = new Point(17, 80);
            lbl_Nombre.Name = "lbl_Nombre";
            lbl_Nombre.Size = new Size(51, 15);
            lbl_Nombre.TabIndex = 3;
            lbl_Nombre.Text = "Nombre";
            // 
            // txt_DNI
            // 
            txt_DNI.Location = new Point(17, 50);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(100, 23);
            txt_DNI.TabIndex = 2;
            // 
            // lbl_DNI
            // 
            lbl_DNI.AutoSize = true;
            lbl_DNI.Location = new Point(17, 32);
            lbl_DNI.Name = "lbl_DNI";
            lbl_DNI.Size = new Size(27, 15);
            lbl_DNI.TabIndex = 1;
            lbl_DNI.Text = "DNI";
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Location = new Point(704, 76);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(32, 15);
            lbl_Total.TabIndex = 3;
            lbl_Total.Text = "Total";
            // 
            // txt_Total
            // 
            txt_Total.Enabled = false;
            txt_Total.Location = new Point(674, 103);
            txt_Total.Name = "txt_Total";
            txt_Total.Size = new Size(100, 23);
            txt_Total.TabIndex = 4;
            // 
            // dtg_Productos
            // 
            dtg_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_Productos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Cantidad, Precio });
            dtg_Productos.Location = new Point(334, 26);
            dtg_Productos.Name = "dtg_Productos";
            dtg_Productos.RowTemplate.Height = 25;
            dtg_Productos.Size = new Size(312, 301);
            dtg_Productos.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Codigo Producto";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nombre Producto";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            // 
            // txt_Codigo
            // 
            txt_Codigo.Location = new Point(219, 76);
            txt_Codigo.Name = "txt_Codigo";
            txt_Codigo.Size = new Size(100, 23);
            txt_Codigo.TabIndex = 7;
            // 
            // lbl_Codigo
            // 
            lbl_Codigo.AutoSize = true;
            lbl_Codigo.Location = new Point(211, 58);
            lbl_Codigo.Name = "lbl_Codigo";
            lbl_Codigo.Size = new Size(117, 15);
            lbl_Codigo.TabIndex = 6;
            lbl_Codigo.Text = "Codigo del Producto";
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Column1";
            Codigo.Name = "Codigo";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Column1";
            Nombre.Name = "Nombre";
            // 
            // txt_Cantidad
            // 
            txt_Cantidad.Location = new Point(219, 129);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new Size(100, 23);
            txt_Cantidad.TabIndex = 9;
            // 
            // lbl_Cantidad
            // 
            lbl_Cantidad.AutoSize = true;
            lbl_Cantidad.Location = new Point(211, 111);
            lbl_Cantidad.Name = "lbl_Cantidad";
            lbl_Cantidad.Size = new Size(55, 15);
            lbl_Cantidad.TabIndex = 8;
            lbl_Cantidad.Text = "Cantidad";
            // 
            // btn_Agregar
            // 
            btn_Agregar.Location = new Point(229, 181);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(75, 23);
            btn_Agregar.TabIndex = 10;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = true;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // Form_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 362);
            Controls.Add(btn_Agregar);
            Controls.Add(txt_Cantidad);
            Controls.Add(lbl_Cantidad);
            Controls.Add(txt_Codigo);
            Controls.Add(lbl_Codigo);
            Controls.Add(dtg_Productos);
            Controls.Add(txt_Total);
            Controls.Add(lbl_Total);
            Controls.Add(grp_Cliente);
            Controls.Add(btn_Confirmar);
            Name = "Form_Ventas";
            Text = "Form_Ventas";
            Load += Form_Ventas_Load;
            grp_Cliente.ResumeLayout(false);
            grp_Cliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Productos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Confirmar;
        private GroupBox grp_Cliente;
        private TextBox txt_Direccion;
        private Label lbl_Direccion;
        private TextBox txt_Telefono;
        private Label lbl_Telefono;
        private TextBox txt_Nombre;
        private Label lbl_Nombre;
        private TextBox txt_DNI;
        private Label lbl_DNI;
        private Label lbl_Total;
        private TextBox txt_Total;
        private DataGridView dtg_Productos;
        private TextBox txt_Codigo;
        private Label lbl_Codigo;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Precio;
        private TextBox txt_Cantidad;
        private Label lbl_Cantidad;
        private Button btn_Agregar;
        private Button btn_Buscar;
        private TextBox txt_Apellido;
        private Label lbl_Apellido;
    }
}
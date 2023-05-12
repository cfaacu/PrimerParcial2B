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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btn_Confirmar = new Button();
            grp_Cliente = new GroupBox();
            txt_Apellido = new TextBox();
            btn_Buscar = new Button();
            txt_Direccion = new TextBox();
            txt_Telefono = new TextBox();
            txt_Nombre = new TextBox();
            txt_DNI = new TextBox();
            lbl_Total = new Label();
            txt_Codigo = new TextBox();
            Codigo = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            txt_Cantidad = new TextBox();
            btn_Agregar = new Button();
            dtg_Productos = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Lbl_PrecioTotal = new Label();
            grp_Cliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_Productos).BeginInit();
            SuspendLayout();
            // 
            // btn_Confirmar
            // 
            btn_Confirmar.BackColor = Color.White;
            btn_Confirmar.FlatAppearance.BorderSize = 0;
            btn_Confirmar.FlatStyle = FlatStyle.Flat;
            btn_Confirmar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Confirmar.Location = new Point(497, 335);
            btn_Confirmar.Name = "btn_Confirmar";
            btn_Confirmar.Size = new Size(125, 53);
            btn_Confirmar.TabIndex = 0;
            btn_Confirmar.Text = "Confirmar";
            btn_Confirmar.UseVisualStyleBackColor = false;
            btn_Confirmar.Click += btn_Confirmar_Click;
            // 
            // grp_Cliente
            // 
            grp_Cliente.Controls.Add(txt_Apellido);
            grp_Cliente.Controls.Add(btn_Buscar);
            grp_Cliente.Controls.Add(txt_Direccion);
            grp_Cliente.Controls.Add(txt_Telefono);
            grp_Cliente.Controls.Add(txt_Nombre);
            grp_Cliente.Controls.Add(txt_DNI);
            grp_Cliente.Location = new Point(12, 25);
            grp_Cliente.Name = "grp_Cliente";
            grp_Cliente.Size = new Size(164, 271);
            grp_Cliente.TabIndex = 1;
            grp_Cliente.TabStop = false;
            grp_Cliente.Text = "Datos del cliente";
            // 
            // txt_Apellido
            // 
            txt_Apellido.BackColor = Color.SteelBlue;
            txt_Apellido.Enabled = false;
            txt_Apellido.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Apellido.ForeColor = Color.White;
            txt_Apellido.Location = new Point(16, 127);
            txt_Apellido.Name = "txt_Apellido";
            txt_Apellido.Size = new Size(100, 29);
            txt_Apellido.TabIndex = 11;
            txt_Apellido.Text = "APELLIDO";
            // 
            // btn_Buscar
            // 
            btn_Buscar.BackColor = Color.White;
            btn_Buscar.FlatAppearance.BorderSize = 0;
            btn_Buscar.FlatStyle = FlatStyle.Flat;
            btn_Buscar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Buscar.Location = new Point(130, 39);
            btn_Buscar.Name = "btn_Buscar";
            btn_Buscar.Size = new Size(24, 17);
            btn_Buscar.TabIndex = 9;
            btn_Buscar.UseVisualStyleBackColor = false;
            btn_Buscar.Click += btn_Buscar_Click;
            // 
            // txt_Direccion
            // 
            txt_Direccion.BackColor = Color.SteelBlue;
            txt_Direccion.Enabled = false;
            txt_Direccion.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Direccion.ForeColor = Color.White;
            txt_Direccion.Location = new Point(16, 221);
            txt_Direccion.Name = "txt_Direccion";
            txt_Direccion.Size = new Size(100, 29);
            txt_Direccion.TabIndex = 8;
            txt_Direccion.Text = "DIRECCION";
            // 
            // txt_Telefono
            // 
            txt_Telefono.BackColor = Color.SteelBlue;
            txt_Telefono.Enabled = false;
            txt_Telefono.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Telefono.ForeColor = Color.White;
            txt_Telefono.Location = new Point(17, 173);
            txt_Telefono.Name = "txt_Telefono";
            txt_Telefono.Size = new Size(100, 29);
            txt_Telefono.TabIndex = 6;
            txt_Telefono.Text = "TELEFONO";
            // 
            // txt_Nombre
            // 
            txt_Nombre.BackColor = Color.SteelBlue;
            txt_Nombre.Enabled = false;
            txt_Nombre.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Nombre.ForeColor = Color.White;
            txt_Nombre.Location = new Point(17, 82);
            txt_Nombre.Name = "txt_Nombre";
            txt_Nombre.Size = new Size(100, 29);
            txt_Nombre.TabIndex = 4;
            txt_Nombre.Text = "NOMBRE";
            // 
            // txt_DNI
            // 
            txt_DNI.BackColor = Color.SteelBlue;
            txt_DNI.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_DNI.ForeColor = Color.White;
            txt_DNI.Location = new Point(17, 34);
            txt_DNI.Name = "txt_DNI";
            txt_DNI.Size = new Size(100, 29);
            txt_DNI.TabIndex = 2;
            txt_DNI.Text = "DNI";
            // 
            // lbl_Total
            // 
            lbl_Total.AutoSize = true;
            lbl_Total.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Total.ForeColor = Color.White;
            lbl_Total.Location = new Point(397, 335);
            lbl_Total.Name = "lbl_Total";
            lbl_Total.Size = new Size(64, 32);
            lbl_Total.TabIndex = 3;
            lbl_Total.Text = "Total";
            // 
            // txt_Codigo
            // 
            txt_Codigo.BackColor = Color.SteelBlue;
            txt_Codigo.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Codigo.ForeColor = Color.White;
            txt_Codigo.Location = new Point(39, 358);
            txt_Codigo.Name = "txt_Codigo";
            txt_Codigo.Size = new Size(100, 29);
            txt_Codigo.TabIndex = 7;
            txt_Codigo.Text = "CODIGO";
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
            txt_Cantidad.BackColor = Color.SteelBlue;
            txt_Cantidad.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Cantidad.ForeColor = Color.White;
            txt_Cantidad.Location = new Point(156, 358);
            txt_Cantidad.Name = "txt_Cantidad";
            txt_Cantidad.Size = new Size(100, 29);
            txt_Cantidad.TabIndex = 9;
            txt_Cantidad.Text = "CANTIDAD";
            // 
            // btn_Agregar
            // 
            btn_Agregar.BackColor = Color.White;
            btn_Agregar.FlatAppearance.BorderSize = 0;
            btn_Agregar.FlatStyle = FlatStyle.Flat;
            btn_Agregar.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Agregar.Location = new Point(278, 358);
            btn_Agregar.Name = "btn_Agregar";
            btn_Agregar.Size = new Size(75, 30);
            btn_Agregar.TabIndex = 10;
            btn_Agregar.Text = "Agregar";
            btn_Agregar.UseVisualStyleBackColor = false;
            btn_Agregar.Click += btn_Agregar_Click;
            // 
            // dtg_Productos
            // 
            dtg_Productos.AllowUserToAddRows = false;
            dtg_Productos.AllowUserToDeleteRows = false;
            dtg_Productos.AllowUserToResizeColumns = false;
            dtg_Productos.AllowUserToResizeRows = false;
            dtg_Productos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtg_Productos.BackgroundColor = Color.SteelBlue;
            dtg_Productos.BorderStyle = BorderStyle.None;
            dtg_Productos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dtg_Productos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtg_Productos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtg_Productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dtg_Productos.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, Cantidad, PrecioVenta });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.SteelBlue;
            dataGridViewCellStyle2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtg_Productos.DefaultCellStyle = dataGridViewCellStyle2;
            dtg_Productos.EnableHeadersVisualStyles = false;
            dtg_Productos.GridColor = Color.White;
            dtg_Productos.Location = new Point(203, 19);
            dtg_Productos.Name = "dtg_Productos";
            dtg_Productos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.SteelBlue;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dtg_Productos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dtg_Productos.RowHeadersVisible = false;
            dtg_Productos.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtg_Productos.RowTemplate.Height = 25;
            dtg_Productos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtg_Productos.Size = new Size(419, 296);
            dtg_Productos.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "CODIGO";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "CANTIDAD";
            Cantidad.Name = "Cantidad";
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "PRECIO VENTA";
            PrecioVenta.Name = "PrecioVenta";
            // 
            // Lbl_PrecioTotal
            // 
            Lbl_PrecioTotal.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Lbl_PrecioTotal.ForeColor = Color.White;
            Lbl_PrecioTotal.Location = new Point(376, 378);
            Lbl_PrecioTotal.Name = "Lbl_PrecioTotal";
            Lbl_PrecioTotal.Size = new Size(115, 30);
            Lbl_PrecioTotal.TabIndex = 12;
            Lbl_PrecioTotal.Text = "$";
            Lbl_PrecioTotal.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(651, 657);
            Controls.Add(Lbl_PrecioTotal);
            Controls.Add(dtg_Productos);
            Controls.Add(btn_Agregar);
            Controls.Add(txt_Cantidad);
            Controls.Add(txt_Codigo);
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
        private TextBox txt_Telefono;
        private TextBox txt_Nombre;
        private TextBox txt_DNI;
        private Label lbl_Total;
        private TextBox txt_Codigo;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Nombre;
        private TextBox txt_Cantidad;
        private Button btn_Agregar;
        private Button btn_Buscar;
        private TextBox txt_Apellido;
        private DataGridView dtg_Productos;
        private Label Lbl_PrecioTotal;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioVenta;
    }
}